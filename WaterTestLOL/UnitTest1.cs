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
    }
}