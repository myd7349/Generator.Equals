using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

[assembly: InternalsVisibleTo("Generator.Equals.SnapshotTests")]

namespace Generator.Equals
{
    [Generator]
    class EqualsGenerator : ISourceGenerator
    {
        bool _runtimeIncluded;

        public void Initialize(GeneratorInitializationContext context)
        {
#if DEBUG
            Debugger.Launch();
#endif
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }


        void EnsureRuntimeIncluded(GeneratorExecutionContext context)
        {
            if (_runtimeIncluded) return;

            var generatorAssembly = typeof(EqualsGenerator).Assembly;

            foreach (var item in generatorAssembly.GetManifestResourceNames())
            {
                if (!item.StartsWith("Generator.Equals.Runtime"))
                    continue;

                using var stream = generatorAssembly.GetManifestResourceStream(item);
                using var reader = new StreamReader(stream!);
                var source = reader.ReadToEnd();

                context.AddSource(item, source);
            }

            _runtimeIncluded = true;
        }

        public void Execute(GeneratorExecutionContext context)
        {
            if (!(context.SyntaxReceiver is SyntaxReceiver s)) return;

            EnsureRuntimeIncluded(context);


            var attributesMetadata = new AttributesMetadata(
                "Equatable",
                "DefaultEquality",
                "OrderedEquality",
                "IgnoreEquality",
                "UnorderedEquality",
                "ReferenceEquality",
                "SetEquality",
                "CustomEqualityB"
            );

            var handledSymbols = new HashSet<string>();

            foreach (var node in s.CandidateSyntaxes)
            {
                var model = context.Compilation.GetSemanticModel(node.SyntaxTree);
                var symbol = model.GetDeclaredSymbol(node, context.CancellationToken) as ITypeSymbol;

                var equatableAttributeData = symbol?.GetAttribute(attributesMetadata.Equatable);
                
                if (equatableAttributeData == null)
                    continue;

                var symbolDisplayString = symbol!.ToDisplayString();

                if (handledSymbols.Contains(symbolDisplayString))
                    continue;

                handledSymbols.Add(symbolDisplayString);

                var explicitMode = equatableAttributeData.NamedArguments
                    .FirstOrDefault(pair => pair.Key == "Explicit")
                    .Value.Value is true;
                var ignoreInheritedMembers = equatableAttributeData.NamedArguments
                    .FirstOrDefault(pair => pair.Key == "IgnoreInheritedMembers")
                    .Value.Value is true;
                var source = node switch
                {
                    RecordDeclarationSyntax _ => RecordEqualityGenerator.Generate(symbol!, attributesMetadata,
                        explicitMode, ignoreInheritedMembers),
                    ClassDeclarationSyntax _ => ClassEqualityGenerator.Generate(symbol!, attributesMetadata,
                        explicitMode, ignoreInheritedMembers),
                    _ => throw new Exception("should not have gotten here.")
                };

                var fileName = $"{EscapeFileName(symbolDisplayString)}.Generator.Equals.g.cs"!;
                context.AddSource(fileName, source);
            }

            static string EscapeFileName(string fileName) => new[] { '<', '>', ',' }
                .Aggregate(new StringBuilder(fileName), (s, c) => s.Replace(c, '_')).ToString();
        }


        class SyntaxReceiver : ISyntaxReceiver
        {
            readonly List<SyntaxNode> _candidateSyntaxes = new List<SyntaxNode>();

            public IReadOnlyList<SyntaxNode> CandidateSyntaxes => _candidateSyntaxes;

            public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
            {
                if (!(syntaxNode is ClassDeclarationSyntax c) && !(syntaxNode is RecordDeclarationSyntax))
                    return;

                _candidateSyntaxes.Add(syntaxNode);
            }
        }
    }
}