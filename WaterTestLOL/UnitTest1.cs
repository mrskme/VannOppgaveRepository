using System;
using NUnit.Framework;
using Vann_Oppgave;

namespace WaterTestLOL
{
    public class WaterStateControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Test1()
        {
            var water = new Water(50, 20);
            Assert.AreEqual(Water.WaterState.Fluid, water.State);
            Assert.AreEqual(20, water.Temperature);
            Assert.AreEqual(50, water.Amount);
        }
        [Test]
        public void Test02WaterAtMinus20Degrees()
        {
            var water = new Water(50, -20);
            Assert.AreEqual(Water.WaterState.Ice, water.State);
            Assert.AreEqual(-20, water.Temperature);
        }
        [Test]
        public void Test03WaterAt120Degrees()
        {
            var water = new Water(50, 120);
            Assert.AreEqual(Water.WaterState.Gas, water.State);
            Assert.AreEqual(120, water.Temperature);
        }
        //[Test]
        //// Ved 0 og 100 grader må vi angi en frivillig parameter til constructoren som angir hvor stor del 
        //// som er i den første fasen (altså is ved blanding av is og flytende - og flytende ved blanding 
        //// av flytende og gass). Denne testen sjekker at vi får exception om dette ikke er angitt og temperaturen
        //// er 100 grader. 
        //[ExpectedException(typeof(ArgumentException),
        //    "When temperature is 0 or 100, you must provide a value for proportion")]
        //public void Test04WaterAt100DegreesWithoutProportion()
        //{
        //    var water = new Water(50, 100);
        //}

        [Test]
        // Sjekker at vi får miks av flytende og gass, med 30% av det første
        public void Test05WaterAt100Degrees()
        {
            var water = new Water(50, 100, 0.3);
            Assert.AreEqual(Water.WaterState.FluidAndGas, water.State);
            Assert.AreEqual(100, water.Temperature);
            Assert.AreEqual(0.3, water.ProportionFirstState);
        }
    }
}