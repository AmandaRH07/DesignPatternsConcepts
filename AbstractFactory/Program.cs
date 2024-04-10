using AbstractFactory.App;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    public class Program
    {
        static Application ConfigureApplication()
        {
            Application app;
            ITransportFactory transportFactory;

            string company = "Lime";

            if (company == "Uber")
            {
                transportFactory = new UberTransport();
            }
            else if (company == "99")
            {
                transportFactory = new NineNineTransport();
            }
            else
            {
                transportFactory = new LimeTransports();
            }

            app = new Application(transportFactory);

            return app;
        }

        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();
            Console.ReadLine();
        }
    }
}
