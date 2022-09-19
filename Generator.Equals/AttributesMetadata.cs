using Microsoft.CodeAnalysis;

namespace Generator.Equals
{
    public class AttributesMetadata
    {
        public string Equatable { get; }
        public string DefaultEquality { get; }
        public string OrderedEquality { get; }
        public string IgnoreEquality { get; }
        public string UnorderedEquality { get; }
        public string ReferenceEquality { get; }
        public string SetEquality { get; }
        public string CustomEquality { get; }

        public AttributesMetadata(
            string equatable,
            string defaultEquality,
            string orderedEquality,
            string ignoreEquality,
            string unorderedEquality, 
            string referenceEquality, 
            string setEquality,
            string customEquality)
        {
            Equatable = equatable;
            DefaultEquality = defaultEquality;
            OrderedEquality = orderedEquality;
            IgnoreEquality = ignoreEquality;
            UnorderedEquality = unorderedEquality;
            ReferenceEquality = referenceEquality;
            SetEquality = setEquality;
            CustomEquality = customEquality;
        }
    }
}
