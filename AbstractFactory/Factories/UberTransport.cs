﻿using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Car();
        }
    }
}
