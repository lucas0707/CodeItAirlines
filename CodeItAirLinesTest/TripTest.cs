using System;
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
        private readonly Pilot pilot = new Pilot();
        private readonly Chief chief = new Chief();
        private readonly Attendant attendant = new Attendant();
        private readonly Oficial oficial = new Oficial();
        private readonly Cop cop = new Cop();
        private readonly Prisoner prisoner = new Prisoner();
        private readonly FourTwo fourTwo = new FourTwo();


        #region Cop tests
        [TestMethod]
        public void TripTestMethodCopAndPrisoner()
        {
            Assert.AreEqual(fourTwo.Ride(cop, prisoner), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodCopAndPilot()
        {
            Assert.AreEqual(fourTwo.Ride(cop, pilot), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodCopAndChief()
        {
            Assert.AreEqual(fourTwo.Ride(cop, chief), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodCopAndAttendant()
        {
            Assert.AreEqual(fourTwo.Ride(cop, attendant), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodCopAndOficial()
        {
            Assert.AreEqual(fourTwo.Ride(cop, oficial), "Viagem de sucesso!");
        }
        #endregion

        #region Pilot tests

        [TestMethod]
        public void TripTestMethodPilotAndOficial()
        {
            Assert.AreEqual(fourTwo.Ride(pilot, oficial), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodPilotAndAttendant()
        {
            try
            {
                fourTwo.Ride(pilot, attendant);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Viagem invalida.");
            }
        }

        [TestMethod]
        public void TripTestMethodPilotAndChief()
        {
            Assert.AreEqual(fourTwo.Ride(pilot, chief), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodPilotAndCop()
        {
            Assert.AreEqual(fourTwo.Ride(pilot, cop), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodPilotAndPrisoner()
        {
            Assert.AreEqual(fourTwo.Ride(pilot, prisoner), "Viagem de sucesso!");
        }

        #endregion

        #region Chief tests

        [TestMethod]
        public void TripTestMethodChiefAndAttendant()
        {
            Assert.AreEqual(fourTwo.Ride(chief, attendant), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodChiefAndOficial()
        {
            try
            {
                fourTwo.Ride(chief, oficial);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Viagem invalida.");
            }
        }

        [TestMethod]
        public void TripTestMethodChiefAndCop()
        {
            Assert.AreEqual(fourTwo.Ride(chief, cop), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodChiefAndPilot()
        {
            Assert.AreEqual(fourTwo.Ride(chief, pilot), "Viagem de sucesso!");
        }

        [TestMethod]
        public void TripTestMethodChiefAndPrisoner()
        {
            Assert.AreEqual(fourTwo.Ride(chief, prisoner), "Viagem de sucesso!");
        }

        #endregion
    }
}
