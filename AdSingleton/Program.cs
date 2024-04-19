using System;

namespace AdSingleton
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Crear el facade y el mediador
            SmartHomeFacade smartHome = new SmartHomeFacade();
            Mediator mediator = new Mediator(smartHome);

            // Ejemplo de uso
            mediator.TurnOnLights();
            mediator.TurnOnLights();

            mediator.LockDoors();
            mediator.LockDoors();

            mediator.UnlockDoors();

            mediator.TurnOffLights();

            Console.ReadKey();
        }
    }
}