using System;

namespace FactoryMethod.Vehicles
{
    class Motorcycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda com a Moto!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a entrega!");
        }
    }
}
