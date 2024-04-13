using Builder.Directors;
using Builder.Products;
using System;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {sedan.vehicleType}");


            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {truck.vehicleType}");

            director.ConstructSUV();
            Vehicle suv = builder.GetVehicle();

            Console.WriteLine($"Criado um veículo do tipo: {suv.vehicleType}");

            Console.ReadLine();
        }
    }
}
