using System;

namespace AbstractFactory.Aircrafts
{
    public class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, direção sudeste!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo. ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!");
        }
    }
}
