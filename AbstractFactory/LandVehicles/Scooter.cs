using System;

namespace AbstractFactory.LandVehicles
{
    public class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando o trajeto!");
        }
    }
}
