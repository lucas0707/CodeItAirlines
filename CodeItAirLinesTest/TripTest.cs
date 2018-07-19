using CodeITAirlines;
using CodeITAirlines.Actions;
using CodeITAirlines.Actors;
using CodeITAirlines.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeItAirLinesTest
{
    [TestClass]
    public class TripTest
    {
        readonly Pilot pilot = new Pilot();
        readonly Chief chief = new Chief();
        readonly Attendant attendant = new Attendant();
        readonly Oficial oficial = new Oficial();
        readonly Cop cop = new Cop();
        readonly Prisoner prisoner = new Prisoner();
        readonly FourTwo fourTwo = new FourTwo();
        readonly Trip trip = new Trip();


        [TestMethod]
        public void TripTestMethodCopAndPrisoner()
        {
            Assert.AreEqual(trip.ValidateTrip(fourTwo.Ride(fourTwo, cop, prisoner)), "Viagem Valida!");
        }

        [TestMethod]
        public void TripTestMethodPilotAndOficial()
        {
            Assert.AreEqual(trip.ValidateTrip(fourTwo.Ride(fourTwo, pilot, oficial)), "Viagem Valida!");
        }

        [TestMethod]
        public void TripTestMethodChiefAndAttendant()
        {
            Assert.AreEqual(trip.ValidateTrip(fourTwo.Ride(fourTwo, chief, attendant)), "Viagem Valida!");
        }

        [TestMethod]
        public void TripTestMethodChiefAndOficial()
        {
            Assert.AreEqual(trip.ValidateTrip(fourTwo.Ride(fourTwo, chief, oficial)), "Viagem Invalida!");
        }

        [TestMethod]
        public void TripTestMethodPilotAndAttendant()
        {
            Assert.AreEqual(trip.ValidateTrip(fourTwo.Ride(fourTwo, pilot, attendant)), "Viagem Invalida!");
        }

    }
}
