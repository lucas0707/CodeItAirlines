using CodeITAirlines.Actors;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CodeITAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            Trip validate = new Trip();

            var pilot = new Pilot();
            var oficialOne = new Oficial { Name = "Primeiro Oficial"};
            var oficialTwo = new Oficial { Name = "Segundo Oficial" };
            var chief = new Chief();
            var attendantOne = new Attendant { Name = "Primeira Comissaria" };
            var attendantTwo = new Attendant { Name = "Segunda Comissaria" };
            var cop = new Cop();
            var prisoner = new Prisoner();

            var airport = new Context.Context
            {
                Actors = new List<Actor>
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

            var airplane = new Context.Context();
            airplane.Actors = new List<Actor>();

            validate.WriteAirport(airport);

            Console.WriteLine($"\n{pilot.Name} e {chief.Name} se dirigem ao aviao");
            Thread.Sleep(3000);

            validate.ValidateTrip(pilot, attendantOne);

            airport.Actors.Remove(chief);
            airplane.Actors.Add(chief);

            Console.WriteLine($"\n{pilot.Name} retorna ao aeroporto");
            Thread.Sleep(3000);

            Console.WriteLine($"\n{cop.Name} e {prisoner.Name} se dirigem ao aviao");
            Thread.Sleep(3000);

            airport.Actors.Remove(cop);
            airport.Actors.Remove(prisoner);

            airplane.Actors.Add(cop);
            airplane.Actors.Add(prisoner);

            Console.WriteLine($"\n{chief.Name} retorna ao aeroporto");
            Thread.Sleep(3000);

            airplane.Actors.Remove(chief);

            Console.WriteLine($"\n{pilot.Name} e {oficialOne.Name} se dirigem ao aviao.");
            Thread.Sleep(3000);

            airport.Actors.Remove(oficialOne);
            airplane.Actors.Add(oficialOne);

            Console.WriteLine($"\n{pilot.Name} retorna ao aeroporto.");
            Thread.Sleep(3000);

            Console.WriteLine($"\n{pilot.Name} e {oficialTwo.Name} se dirigem ao aviao.");
            Thread.Sleep(3000);

            airport.Actors.Remove(oficialTwo);
            airplane.Actors.Add(oficialTwo);

            Console.WriteLine($"\n{pilot.Name} retorna ao aeroporto.");
            Thread.Sleep(3000);

            Console.WriteLine($"\n{pilot.Name} e {chief.Name} se dirigem ao aviao.");
            Thread.Sleep(3000);

            airport.Actors.Remove(pilot);
            airplane.Actors.Add(pilot);

            Console.WriteLine($"\n{chief.Name} retorna ao aeroporto.");
            Thread.Sleep(3000);

            Console.WriteLine($"\n{chief.Name} e {attendantOne.Name} se dirigem ao aviao.");
            Thread.Sleep(3000);

            airport.Actors.Remove(attendantOne);
            airplane.Actors.Add(attendantOne);

            Console.WriteLine($"\n{chief.Name} retorna ao aeroporto.");
            Thread.Sleep(3000);

            Console.WriteLine($"\n{chief.Name} e {attendantTwo.Name} se dirigem ao aviao.");
            Thread.Sleep(3000);

            airport.Actors.Remove(attendantTwo);
            airport.Actors.Remove(chief);

            airplane.Actors.Add(attendantTwo);
            airplane.Actors.Add(chief);

            Console.WriteLine($"\nTodos embarcaram!");
            Thread.Sleep(3000);

            validate.WriteAirplane(airplane);
            Thread.Sleep(3000);
        }
    }

    public interface ITrip
    {
        void WriteAirport(Context.Context airport);
        void WriteAirplane(Context.Context airplane);

    }

    public class Trip : ITrip
    {
        public void WriteAirport(Context.Context airport)
        {
            Console.WriteLine($"\nEstao no aeroporto: ");
            foreach (var item in airport.Actors)
            {
                Console.WriteLine("#" + item.Name);
            }
        }

        public void WriteAirplane(Context.Context airplane)
        {
            Console.WriteLine($"\nEstao no aviao: ");
            foreach (var item in airplane.Actors)
            {
                Console.WriteLine("#" + item.Name);
            }
        }

        public void ValidateTrip(Actor driver, Actor passenger)
        {
            var valDriver = driver.GetType();
            var valPassenger = passenger.GetType();

            if (valDriver != typeof(Pilot) || valPassenger != typeof(Attendant))
                return;

            if (valDriver != typeof(Chief) || valPassenger != typeof(Oficial))
                return;

            if (valDriver != typeof(Cop) || valPassenger != typeof(Prisoner))
            {
                
            }

            Console.WriteLine($"\nViagem invalida!");
            Console.OpenStandardError();

        }
    }
}
