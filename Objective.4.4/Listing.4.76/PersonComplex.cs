using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Listing_4_76
{
    [Serializable]
    public class PersonComplex : ISerializable
    {
        private bool _isDirty = false;

        public int Id { get; set; }

        public string Name { get; set; }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Value1", Id);
            info.AddValue("Value2", Name);
            info.AddValue("Value3", _isDirty);
        }

        protected PersonComplex(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("Value1");
            Name = info.GetString("Value2");
            _isDirty = info.GetBoolean("Value3");
        }

        public PersonComplex() { }
    }
}
