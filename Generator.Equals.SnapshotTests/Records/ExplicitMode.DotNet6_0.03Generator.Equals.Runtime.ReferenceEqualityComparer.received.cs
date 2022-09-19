//HintName: Generator.Equals.Runtime.ReferenceEqualityComparer.cs
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Generator.Equals
{
    internal class ReferenceEqualityComparer<T> : IEqualityComparer<T> where T : class
    {
        public static ReferenceEqualityComparer<T> Default { get; } = new ReferenceEqualityComparer<T>();

        public bool Equals(T? x, T? y)
        {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode(T? obj)
        {
#pragma warning disable RS1024
            return RuntimeHelpers.GetHashCode(obj);
#pragma warning restore
        }
    }
}