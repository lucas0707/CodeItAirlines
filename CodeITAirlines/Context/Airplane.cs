using CodeITAirlines.Actors;
using System.Collections.Generic;

namespace CodeITAirlines.Context
{
    public class Airplane
    {
        public ICollection<Person> PersonList { get; set; }

    }
}
