using System;
using System.Runtime.Serialization;

namespace Listing_4_73
{
    [Serializable]
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [OptionalField] private bool _optional;

        [NonSerialized] private bool _notSerialised;

        [OnSerializing]
        internal void OnSerialisingMethod(StreamingContext context)
        {
            Console.WriteLine("OnSerialising");
        }

        [OnSerialized]
        internal void OnSerialisedMethod(StreamingContext context)
        {
            Console.WriteLine("OnSerialised");
        }

        [OnDeserializing]
        internal void OnDeserialisingMethod(StreamingContext context)
        {
            Console.WriteLine("OnDeserialising");
        }

        [OnDeserialized]
        internal void OnDeserialisedMethod(StreamingContext context)
        {
            Console.WriteLine("OnDeserialised");
        }
    }
}
