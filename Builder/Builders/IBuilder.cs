using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();

        void SetSeats(int seats);
        void SetEngine(Engine engine);
        void setTransmission(Transmission transmission);
        void setVehicleType(VehicleType vehicleType);
        void setAirbag(bool airbag);
    }
}
