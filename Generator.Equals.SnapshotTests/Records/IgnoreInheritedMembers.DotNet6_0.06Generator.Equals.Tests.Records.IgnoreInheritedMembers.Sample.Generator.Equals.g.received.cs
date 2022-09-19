//HintName: Generator.Equals.Tests.Records.IgnoreInheritedMembers.Sample.Generator.Equals.g.cs
namespace Generator.Equals.Tests.Records {
partial class IgnoreInheritedMembers {
partial record Sample {
#nullable enable
#pragma warning disable CS0612,CS0618
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public virtual bool Equals(global::Generator.Equals.Tests.Records.IgnoreInheritedMembers.Sample? other) {
return base.Equals((global::Generator.Equals.Tests.Records.IgnoreInheritedMembers.SampleBase?)other)
&& global::System.Collections.Generic.EqualityComparer<global::System.Int32>.Default.Equals(Age!, other.Age!)
;
}
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public override int GetHashCode() {
                var hashCode = new global::System.HashCode();
            
hashCode.Add(base.GetHashCode());
hashCode.Add(this.Age!, global::System.Collections.Generic.EqualityComparer<global::System.Int32>.Default);
return hashCode.ToHashCode();
}
#pragma warning restore CS0612,CS0618
#nullable restore

}
}
}
