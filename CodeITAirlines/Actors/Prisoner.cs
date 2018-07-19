using CodeITAirlines.Actors.Interface;

namespace CodeITAirlines.Actors
{
    public class Prisoner : Person, IPassenger
    {
        public override string Name { get; set; } = "Prisioneiro";
    }
}
