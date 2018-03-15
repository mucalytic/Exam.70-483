using System.Diagnostics;

namespace Listing_3_43
{
    [DebuggerDisplay("Name = {FirstName} {LastName}")]
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
