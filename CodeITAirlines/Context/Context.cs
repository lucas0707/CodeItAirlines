using CodeITAirlines.Actors;
using System.Collections.Generic;

namespace CodeITAirlines.Context
{
    public class Context
    {
        public ICollection<Actor> Actors { get; set; }
    }
}
