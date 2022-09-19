//HintName: Generator.Equals.Runtime.Attributes.cs
using System;
using System.Diagnostics;

namespace Generator.Equals
{
    [Conditional("GENERATOR_EQUALS")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    internal class EquatableAttribute : Attribute
    {
        /// <summary>
        /// IEquatable will only be generated for explicitly defined attributes.
        /// </summary>
        public bool Explicit { get; set; }

        /// <summary>
        /// Equality and hash code do not consider members of base classes.
        /// </summary>
        public bool IgnoreInheritedMembers { get; set; }
    }

    [Conditional("GENERATOR_EQUALS")]
    [AttributeUsage(AttributeTargets.Property)]
    internal class DefaultEqualityAttribute : Attribute
    {
    }

    [Conditional("GENERATOR_EQUALS")]
    [AttributeUsage(AttributeTargets.Property)]
    internal class OrderedEqualityAttribute : Attribute
    {
    }

    [Conditional("GENERATOR_EQUALS")]
    [AttributeUsage(AttributeTargets.Property)]
    internal class IgnoreEqualityAttribute : Attribute
    {
    }

    [Conditional("GENERATOR_EQUALS")]
    [AttributeUsage(AttributeTargets.Property)]
    internal class UnorderedEqualityAttribute : Attribute
    {
    }

    [Conditional("GENERATOR_EQUALS")]
    [AttributeUsage(AttributeTargets.Property)]
    internal class ReferenceEqualityAttribute : Attribute
    {
    }

    [Conditional("GENERATOR_EQUALS")]
    [AttributeUsage(AttributeTargets.Property)]
    internal class SetEqualityAttribute : Attribute
    {
    }

    [Conditional("GENERATOR_EQUALS")]
    [AttributeUsage(AttributeTargets.Property)]
    internal class CustomEqualityAttribute : Attribute
    {
        public Type EqualityType { get; }
        public string FieldOrPropertyName { get; }

        public CustomEqualityAttribute(Type equalityType, string fieldOrPropertyName = "Default")
        {
            EqualityType = equalityType;
            FieldOrPropertyName = fieldOrPropertyName;
        }
    }
}