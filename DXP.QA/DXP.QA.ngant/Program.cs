using System;
namespace VehicleSpace
{
    class SuperVehicle
    {
        class Vehicle
        {
            public void VehicleKind(string vehicle_name)
            {
                Console.WriteLine("Kind of vehicle is: " + vehicle_name);
            }
        }

        class Car : Vehicle
        {
            public void CarName(string car_brand, string car_name)
            {
                Console.WriteLine($"Brand: {car_brand}, Name: {car_name}");
            }
        }

        class Motorbike : Vehicle
        {
            public void MotorbikeName(string motorbike_brand, string motorbike_name)
            {
                Console.WriteLine($"Brand: {motorbike_brand}, Name: {motorbike_name}");
            }
        }

        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.VehicleKind("Car");
            myCar.CarName("Hyundai", "Elantra");
            Motorbike myMotorbike = new Motorbike();
            myMotorbike.VehicleKind("Motorbike");
            myMotorbike.MotorbikeName("Ducati", "Monster 937");
        }
    }
}

