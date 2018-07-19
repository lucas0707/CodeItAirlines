using CodeITAirlines.Actors.Interface;

namespace CodeITAirlines.Actors
{
    public class Cop : Person, IDriver, IPassenger
    {
        public override string Name { get; set; } = "Policial";

        public bool ValidatePassenger(IPassenger passenger)
        {
            return true;
        }
    }
}
