﻿//HintName: Generator.Equals.Tests.Classes.IgnoreInheritedMembers.Sample.Generator.Equals.g.cs
namespace Generator.Equals.Tests.Classes {
partial class IgnoreInheritedMembers {
partial class Sample : global::System.IEquatable<Sample> {
#nullable enable
#pragma warning disable CS0612,CS0618
/// <summary>
        /// Indicates whether the object on the left is equal to the object on the right.
        /// </summary>
        /// <param name="left">The left object</param>
        /// <param name="right">The right object</param>
        /// <returns>true if the objects are equal; otherwise, false.</returns>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public static bool operator ==(global::Generator.Equals.Tests.Classes.IgnoreInheritedMembers.Sample? left, global::Generator.Equals.Tests.Classes.IgnoreInheritedMembers.Sample? right) => global::System.Collections.Generic.EqualityComparer<global::Generator.Equals.Tests.Classes.IgnoreInheritedMembers.Sample?>.Default.Equals(left, right);
/// <summary>
        /// Indicates whether the object on the left is not equal to the object on the right.
        /// </summary>
        /// <param name="left">The left object</param>
        /// <param name="right">The right object</param>
        /// <returns>true if the objects are not equal; otherwise, false.</returns>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public static bool operator !=(global::Generator.Equals.Tests.Classes.IgnoreInheritedMembers.Sample? left, global::Generator.Equals.Tests.Classes.IgnoreInheritedMembers.Sample? right) => !(left == right);
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public override bool Equals(object? obj) => Equals(obj as global::Generator.Equals.Tests.Classes.IgnoreInheritedMembers.Sample);
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public bool Equals(global::Generator.Equals.Tests.Classes.IgnoreInheritedMembers.Sample? other) {
return base.Equals(other as global::Generator.Equals.Tests.Classes.IgnoreInheritedMembers.SampleBase)
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
