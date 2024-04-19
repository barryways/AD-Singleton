using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdSingleton.Subsistems;

namespace AdSingleton
{
    public class SmartHomeFacade
    {
        private LightSystem lightSystem;
        private DoorSystem doorSystem;

        public SmartHomeFacade()
        {
            lightSystem = new LightSystem();
            doorSystem = new DoorSystem();
        }

        public void TurnOnLights()
        {
            lightSystem.TurnOn();
        }

        public void TurnOffLights()
        {
            lightSystem.TurnOff();
        }

        public void LockDoors()
        {
            doorSystem.Lock();
        }

        public void UnlockDoors()
        {
            doorSystem.Unlock();
        }
    }
}
