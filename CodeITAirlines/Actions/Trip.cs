using CodeITAirlines.Actions.Interface;
using CodeITAirlines.Context;
using System;
using CodeITAirlines.Actors;

namespace CodeITAirlines.Actions
{
    public class Trip : ITrip
    {
        public string ValidateTrip(FourTwo fourTwo)
        {

            if (!ValidateDriver(fourTwo.Driver))
            {
                return "Motorista invalido.";
            }

            if (!ValidateDuo(fourTwo.Driver, fourTwo.Passenger))
            {
                return "Viagem Invalida!";
            }

            return "Viagem Valida!";
        }

        public bool ValidateDuo(Actor driver, Actor passenger)
        {
            if (!(driver is Cop) && passenger is Prisoner)
            {
                return false;
            }

            if (driver is Pilot && passenger is Attendant)
            {
                return false;
            }

            if (driver is Chief && passenger is Oficial)
            {
                return false;
            }

            return true;
        }

        public bool ValidateDriver(Actor driver)
        {
            if (driver is Chief || driver is Pilot || driver is Cop)
            {
                return true;
            }
            return false;
        }

        public void WriteAirport(Airport airport)
        {
            Console.WriteLine($"Estao no aeroporto: ");
            foreach (var item in airport.Actors)
            {
                Console.WriteLine("#" + item.Name);
            }
        }

        public void WriteAirplane(Airplane airplane)
        {
            Console.WriteLine($"Estao no aviao: ");
            foreach (var item in airplane.Actors)
            {
                Console.WriteLine("#" + item.Name);
            }
        }

    }
}
