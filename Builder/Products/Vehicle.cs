using Builder.Components;

namespace Builder.Products
{
    public class Vehicle
    {
        public VehicleType vehicleType { get; set; }
        public int seats { get; set; }
        public Engine engine { get; set; }
        public Transmission transmission { get; set; }
        public bool airbag { get; set; }
    }
}
