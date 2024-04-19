using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdSingleton.Subsistems
{
    public class DoorSystem
    {
        private bool doorsUnlocked = true;
        public void Lock()
        {
            if (doorsUnlocked)
            {
                doorsUnlocked = false;
                Console.WriteLine("Doors are locked.");
            }
            else
            {
                Console.WriteLine("Doors are already locked ");
            }
        }

        public void Unlock()
        {
            if (!doorsUnlocked)
            {
                doorsUnlocked = true;
                Console.WriteLine("Doors are unlocked.");
            }
            else
            {
                Console.WriteLine("Doors are already unlocked ");
            }
        }
    }
}
