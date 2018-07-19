using CodeITAirlines.Actors;
using System.Collections.Generic;

namespace CodeITAirlines.Context
{
    public class Airport
    {
        public ICollection<Person> PersonList { get; set; }
    }
}
