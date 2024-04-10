using System;

namespace AbstractFactory.Aircrafts
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, direção nordeste, ok! ");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!");
        }
    }
}
