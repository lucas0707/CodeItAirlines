using System;
using System.Collections.Generic;
using System.Text;
using CodeITAirlines.Actors;

namespace CodeITAirlines.Context
{
    public class FourTwo
    {
        public FourTwo()
        {
        }

        public Actor Driver { get; set; }
        public Actor Passenger { get; set; }

        public FourTwo Ride (FourTwo fourTwo, Actor driver, Actor passenger)
        {
            fourTwo.Driver = driver;
            fourTwo.Passenger = passenger;
            return fourTwo;
        }

    }
}
