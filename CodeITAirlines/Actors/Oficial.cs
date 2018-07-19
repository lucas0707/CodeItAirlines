using CodeITAirlines.Actors.Interface;

namespace CodeITAirlines.Actors
{
    public class Oficial : Person, IPassenger
    {
        public override string Name { get; set; }
    }
}
