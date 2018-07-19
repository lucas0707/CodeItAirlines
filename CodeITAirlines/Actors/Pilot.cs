using System;
using CodeITAirlines.Actors.Interface;

namespace CodeITAirlines.Actors
{
    public class Pilot : Person, IDriver, IPassenger
    {
        public override string Name { get; set; } = "Piloto";


        public bool ValidatePassenger(IPassenger passenger)
        {
            return !(passenger is Attendant);
        }
    }
}
