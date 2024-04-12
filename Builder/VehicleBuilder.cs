using Builder.Builders;
using Builder.Components;
using Builder.Products;

namespace Builder
{
    public class VehicleBuilder : IBuilder
    {
        private Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            Vehicle result = vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            vehicle = new Vehicle();
        }

        public void setAirbag(bool airbag)
        {
            vehicle.airbag = airbag;
        }

        public void SetEngine(Engine engine)
        {
            vehicle.engine = engine;
        }

        public void SetSeats(int seats)
        {
            vehicle.seats = seats;
        }

        public void setTransmission(Transmission transmission)
        {
            vehicle.transmission = transmission;
        }

        public void setVehicleType(VehicleType vehicleType)
        {
            vehicle.vehicleType = vehicleType;
        }
    }
}
