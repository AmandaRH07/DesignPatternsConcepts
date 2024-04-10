using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    public class Application
    {
        private IAircraft aircraft;
        private ILandVehicle landVehicle;

        public Application(ITransportFactory transportFactory)
        {
            aircraft = transportFactory.CreateTransportAircraft();
            landVehicle = transportFactory.CreateTransportLandVehicle();
        }

        public void StartRoute()
        {
            landVehicle.StartRoute();
            aircraft.StartRoute();
        }
    }
}
