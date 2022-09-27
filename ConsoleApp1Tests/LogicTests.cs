using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void PassengerCameWhileTrainWasParked()
        {
            var a = 1; var b = 0;
            var c = 3; var d = 5;
            var n = 1; var m = 50;

            var timeTrainArrival = Logic.GetTime(a, b);
            var timeTrainDeparture = Logic.GetTime(c, d);
            var timePassenger = Logic.GetTime(n, m);
            var message = Logic.Compare(timeTrainArrival, timeTrainDeparture, timePassenger);

            Assert.AreEqual(60, timeTrainArrival);
            Assert.AreEqual(185, timeTrainDeparture);
            Assert.AreEqual(110, timePassenger);
            Assert.AreEqual("Поезд будет стоять на платформе во время прихода пассажира", message);

        }

        [TestMethod()]
        public void PassengerCameWhileTrainWasNotParked()
        {
            var a = 3; var b = 7;
            var c = 4; var d = 30;
            var n = 5; var m = 20;

            var timeTrainArrival = Logic.GetTime(a, b);
            var timeTrainDeparture = Logic.GetTime(c, d);
            var timePassenger = Logic.GetTime(n, m);
            var message = Logic.Compare(timeTrainArrival, timeTrainDeparture, timePassenger);

            Assert.AreEqual(187, timeTrainArrival);
            Assert.AreEqual(270, timeTrainDeparture);
            Assert.AreEqual(320, timePassenger);
            Assert.AreEqual("Поезд не будет стоять на платформе во время прихода пассажира", message);
        }
    }
}