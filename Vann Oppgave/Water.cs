using System;
using System.Collections.Generic;
using System.Text;

namespace Vann_Oppgave
{
    public class Water
    {
        public int Amount;
        public int Temperature;
        public WaterState State;

        public Water(int amount, int temperature)
        {
            if (temperature <= 0) State = WaterState.Ice;
            else if (temperature > 0 && temperature < 100) State = WaterState.Fluid;
            else if (temperature >= 100) State = WaterState.Gas;

            Amount = amount;
            Temperature = temperature;
        }
        public enum WaterState
        {
            Fluid, Ice, Gas,/* FluidAndGas, IceAndFluid*/
        }
    }
}
