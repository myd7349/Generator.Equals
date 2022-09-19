﻿//HintName: Generator.Equals.Tests.Classes.CustomEquality.Sample.Generator.Equals.g.cs
namespace Generator.Equals.Tests.Classes {
partial class CustomEquality {
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
public static bool operator ==(global::Generator.Equals.Tests.Classes.CustomEquality.Sample? left, global::Generator.Equals.Tests.Classes.CustomEquality.Sample? right) => global::System.Collections.Generic.EqualityComparer<global::Generator.Equals.Tests.Classes.CustomEquality.Sample?>.Default.Equals(left, right);
/// <summary>
        /// Indicates whether the object on the left is not equal to the object on the right.
        /// </summary>
        /// <param name="left">The left object</param>
        /// <param name="right">The right object</param>
        /// <returns>true if the objects are not equal; otherwise, false.</returns>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public static bool operator !=(global::Generator.Equals.Tests.Classes.CustomEquality.Sample? left, global::Generator.Equals.Tests.Classes.CustomEquality.Sample? right) => !(left == right);
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public override bool Equals(object? obj) => Equals(obj as global::Generator.Equals.Tests.Classes.CustomEquality.Sample);
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public bool Equals(global::Generator.Equals.Tests.Classes.CustomEquality.Sample? other) {
return !ReferenceEquals(other, null) && this.GetType() == other.GetType()
&& global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(Name1!, other.Name1!)
&& global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(Name2!, other.Name2!)
&& global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(Name3!, other.Name3!)
;
}
/// <inheritdoc/>
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
public override int GetHashCode() {
                var hashCode = new global::System.HashCode();
            
hashCode.Add(this.GetType());
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
