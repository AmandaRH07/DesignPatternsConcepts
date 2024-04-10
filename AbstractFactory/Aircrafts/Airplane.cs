using System;

namespace AbstractFactory.Aircrafts
{
    public class Airplane : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos, velocidade 25km!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo. voô autorizado.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!");
        }
    }
}
