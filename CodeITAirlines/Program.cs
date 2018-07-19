using CodeITAirlines.Actions;
using CodeITAirlines.Actors;
using CodeITAirlines.Context;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CodeITAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            var trip = new Trip();

            var pilot = new Pilot();
            var oficialOne = new Oficial { Name = "Primeiro Oficial"};
            var oficialTwo = new Oficial { Name = "Segundo Oficial" };
            var chief = new Chief();
            var attendantOne = new Attendant { Name = "Primeira Comissária" };
            var attendantTwo = new Attendant { Name = "Segunda Comissária" };
            var cop = new Cop();
            var prisoner = new Prisoner();
            var fourTwo = new FourTwo();

            var airport = new Airport
            {
                PersonList = new List<Person>
                {
                    pilot,
                    oficialOne,
                    oficialTwo,
                    chief,
                    attendantOne,
                    attendantTwo,
                    cop,
                    prisoner
                }
            };

            var airplane = new Airplane {PersonList = new List<Person>()};

            trip.WriteAirport(airport);

            fourTwo.Ride(pilot, chief);
            Console.WriteLine($"\n{pilot.Name} e {chief.Name} se dirigem ao avião.");
            Thread.Sleep(1500);

            airport.PersonList.Remove(chief);
            airplane.PersonList.Add(chief);

            fourTwo.Ride(pilot);
            Console.WriteLine($"\n{pilot.Name} retorna ao aeroporto.");
            Thread.Sleep(1500);

            fourTwo.Ride(cop, prisoner);
            Console.WriteLine($"\n{cop.Name} e {prisoner.Name} se dirigem ao avião.");
            Thread.Sleep(1500);

            airport.PersonList.Remove(cop);
            airport.PersonList.Remove(prisoner);

            airplane.PersonList.Add(cop);
            airplane.PersonList.Add(prisoner);

            fourTwo.Ride(chief);
            Console.WriteLine($"\n{chief.Name} retorna ao aeroporto.");
            Thread.Sleep(1500);

            airplane.PersonList.Remove(chief);

            fourTwo.Ride(pilot, oficialOne);
            Console.WriteLine($"\n{pilot.Name} e {oficialOne.Name} se dirigem ao avião.");
            Thread.Sleep(1500);

            airport.PersonList.Remove(oficialOne);
            airplane.PersonList.Add(oficialOne);
            fourTwo.Ride(pilot);
            Console.WriteLine($"\n{pilot.Name} retorna ao aeroporto.");
            Thread.Sleep(1500);

            fourTwo.Ride(pilot, oficialTwo);
            Console.WriteLine($"\n{pilot.Name} e {oficialTwo.Name} se dirigem ao avião.");
            Thread.Sleep(1500);

            airport.PersonList.Remove(oficialTwo);
            airplane.PersonList.Add(oficialTwo);

            fourTwo.Ride(pilot);
            Console.WriteLine($"\n{pilot.Name} retorna ao aeroporto.");
            Thread.Sleep(1500);

            fourTwo.Ride(pilot, chief);
            Console.WriteLine($"\n{pilot.Name} e {chief.Name} se dirigem ao avião.");
            Thread.Sleep(1500);

            airport.PersonList.Remove(pilot);
            airplane.PersonList.Add(pilot);

            fourTwo.Ride(chief);
            Console.WriteLine($"\n{chief.Name} retorna ao aeroporto.");
            Thread.Sleep(1500);

            fourTwo.Ride(chief, attendantOne);
            Console.WriteLine($"\n{chief.Name} e {attendantOne.Name} se dirigem ao avião.");
            Thread.Sleep(1500);

            airport.PersonList.Remove(attendantOne);
            airplane.PersonList.Add(attendantOne);

            fourTwo.Ride(chief);
            Console.WriteLine($"\n{chief.Name} retorna ao aeroporto.");
            Thread.Sleep(1500);

            fourTwo.Ride(chief, attendantTwo);
            Console.WriteLine($"\n{chief.Name} e {attendantTwo.Name} se dirigem ao avião.");
            Thread.Sleep(1500);

            airport.PersonList.Remove(attendantTwo);
            airport.PersonList.Remove(chief);

            airplane.PersonList.Add(attendantTwo);
            airplane.PersonList.Add(chief);

            Console.WriteLine($"\nTodos embarcaram!");
            Thread.Sleep(1500);

            trip.WriteAirplane(airplane);
            Thread.Sleep(1500);

            Console.ReadKey();
        }
    }
}
