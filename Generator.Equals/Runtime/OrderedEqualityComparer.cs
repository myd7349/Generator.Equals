﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Generator.Equals
{
    internal class OrderedEqualityComparer<T> : IEqualityComparer<IEnumerable<T>>
    {
        public static OrderedEqualityComparer<T> Default { get; } = new OrderedEqualityComparer<T>();

        public IEqualityComparer<T> EqualityComparer { get; }

        public OrderedEqualityComparer() : this(EqualityComparer<T>.Default)
        {
        }

        public OrderedEqualityComparer(IEqualityComparer<T> equalityComparer)
        {
            EqualityComparer = equalityComparer;
        }

        public bool Equals(IEnumerable<T>? x, IEnumerable<T>? y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (x == null || y == null)
                return false;

            return x.SequenceEqual(y);
        }

        public int GetHashCode(IEnumerable<T>? obj)
        {
            if (obj == null)
                return 0;

            var hashCode = new HashCode();

            foreach (var item in obj)
                hashCode.Add(item, EqualityComparer);

            return hashCode.ToHashCode();
        }
    }
}