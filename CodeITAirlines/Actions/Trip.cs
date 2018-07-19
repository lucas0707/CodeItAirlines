using CodeITAirlines.Actions.Interface;
using CodeITAirlines.Actors;
using CodeITAirlines.Context;
using System;
using CodeITAirlines.Actors.Interface;

namespace CodeITAirlines.Actions
{
    public class Trip : ITrip
    {
        public void WriteAirport(Airport airport)
        {
            Console.WriteLine($"Estao no aeroporto: ");
            foreach (var item in airport.PersonList)
            {
                Console.WriteLine("#" + item.Name);
            }
        }

        public void WriteAirplane(Airplane airplane)
        {
            Console.WriteLine($"Estao no aviao: ");
            foreach (var item in airplane.PersonList)
            {
                Console.WriteLine("#" + item.Name);
            }
        }
    }
}
