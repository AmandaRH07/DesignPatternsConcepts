using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    public class Director
    {
        IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedanCar()
        {
            builder.setVehicleType(VehicleType.SEDAN);
            builder.SetEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.setTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.setVehicleType(VehicleType.TRUCK);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(5);
            builder.setTransmission(Transmission.MANUAL);
        }

        public void ConstructSUV()
        {
            builder.setVehicleType(VehicleType.SPORTCAR);
            builder.SetEngine(new Engine(4000));
            builder.SetSeats(5);
            builder.setTransmission(Transmission.AUTOMATIC_SEQUENTIAL);
            builder.setAirbag(true);
        }
    }
}
