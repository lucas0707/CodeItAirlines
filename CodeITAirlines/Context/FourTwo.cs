using System;
using CodeITAirlines.Actors;
using CodeITAirlines.Actors.Interface;

namespace CodeITAirlines.Context
{
    public class FourTwo
    {
        public IDriver Driver { get; set; }
        public IPassenger Passenger { get; set; }

        public string Ride (IDriver driver, IPassenger passenger)
        {
            if (driver.ValidatePassenger(passenger) || passenger == null)
            {
                return "Viagem de sucesso!";
            }

            throw new Exception("Viagem inválida.");
        }

        public string Ride(IDriver driver)
        {
            return Ride(driver, null);
        }
    }
}
