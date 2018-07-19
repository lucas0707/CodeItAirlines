using System;
using CodeITAirlines.Actors.Interface;

namespace CodeITAirlines.Actors
{
    public class Chief : Person, IDriver, IPassenger
    {
        public override string Name { get; set; } = "Chefe de Servico de Bordo";

        public bool ValidatePassenger(IPassenger passenger)
        {
            return !(passenger is Oficial || passenger is Prisoner);
        }
    }
}
