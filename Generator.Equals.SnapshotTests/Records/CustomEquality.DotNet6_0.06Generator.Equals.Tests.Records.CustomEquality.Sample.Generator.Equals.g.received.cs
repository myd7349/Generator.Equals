//HintName: Generator.Equals.Tests.Records.CustomEquality.Sample.Generator.Equals.g.cs
namespace Generator.Equals.Tests.Records {
partial class CustomEquality {
partial record Sample {
#nullable enable
#pragma warning disable CS0612,CS0618
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public virtual bool Equals(global::Generator.Equals.Tests.Records.CustomEquality.Sample? other) {
return !ReferenceEquals(other, null) && EqualityContract == other.EqualityContract
&& global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(Name1!, other.Name1!)
&& global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(Name2!, other.Name2!)
&& global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(Name3!, other.Name3!)
;
}
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public override int GetHashCode() {
                var hashCode = new global::System.HashCode();
            
hashCode.Add(this.EqualityContract);
hashCode.Add(this.Name1!, global::System.Collections.Generic.EqualityComparer<global::System.String>.Default);
hashCode.Add(this.Name2!, global::System.Collections.Generic.EqualityComparer<global::System.String>.Default);
hashCode.Add(this.Name3!, global::System.Collections.Generic.EqualityComparer<global::System.String>.Default);
return hashCode.ToHashCode();
}
#pragma warning restore CS0612,CS0618
#nullable restore

}
}
}
