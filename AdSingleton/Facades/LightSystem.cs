using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdSingleton.Subsistems
{
    public class LightSystem
    {
        private bool isOff = true;
        public void TurnOn()
        {
            if (isOff)
            {
                isOff = false;
                Console.WriteLine("Lights are turned on.");
            }
            else
            {
                Console.WriteLine("Lights are on already.");
            }
        }

        public void TurnOff()
        {
            if (!isOff)
            {
                isOff = true;
                Console.WriteLine("Lights are turned off.");
            }
            else
            {
                Console.WriteLine("Lights are off already.");
            }

        }
    }
}
