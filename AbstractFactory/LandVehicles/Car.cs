using System;

namespace AbstractFactory.LandVehicles
{
    public class Car : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto!");
        }
    }
}
