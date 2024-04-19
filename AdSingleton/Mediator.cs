using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdSingleton
{
    public class Mediator
    {
        private SmartHomeFacade smartHome;

        public Mediator(SmartHomeFacade smartHome)
        {
            this.smartHome = smartHome;
        }

        public void TurnOnLights()
        {
            Console.WriteLine("Mediator: Turning on lights...");
            smartHome.TurnOnLights();
        }

        public void TurnOffLights()
        {
            Console.WriteLine("Mediator: Turning off lights...");
            smartHome.TurnOffLights();
        }

        public void LockDoors()
        {
            Console.WriteLine("Mediator: Locking doors...");
            smartHome.LockDoors();
        }

        public void UnlockDoors()
        {
            Console.WriteLine("Mediator: Unlocking doors...");
            smartHome.UnlockDoors();
        }
    }
}
