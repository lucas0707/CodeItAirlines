using CodeITAirlines.Actors.Interface;

namespace CodeITAirlines.Actors
{
    public class Attendant : Person, IPassenger
    {
        public override string Name { get; set; }
    }
}
