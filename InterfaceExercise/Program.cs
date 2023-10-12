using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car = new Car
            {
                NumberOfWheels = 4,
                EngineType = "Gasoline",
                FuelEfficiency = 30.5,
                VehicleWeight = 3200.0,
                CompanyLogo = "CarCompanyLogo.png",
                CompanyDescription = "SedanCo.com, We build efficient and reliable cars.",
                TrunkSize = 15,
                Model = "Sedan",
                Make = "SedanCo",
                Year = 2023
            };

            Truck truck = new Truck
            {
                NumberOfWheels = 6,
                EngineType = "Diesel",
                FuelEfficiency = 15.5,
                VehicleWeight = 6500.0,
                CompanyLogo = "TruckCompanyLogo.png",
                CompanyDescription = "Truckco.com, Your go-to for heavy-duty trucks.",
                BedSize = 8.0,
                Model = "Heavy Hauler",
                Make = "TruckCo",
                Year = 2022
            };

            SUV suv = new SUV
            {
                NumberOfWheels = 4,
                EngineType = "Hybrid",
                FuelEfficiency = 25.0,
                VehicleWeight = 4200.0,
                CompanyLogo = "SUVCompanyLogo.png",
                CompanyDescription = "SUVco.com, Adventure-ready SUVs for your lifestyle.",
                CargoHoldSize = 50.0,
                Model = "Explorer",
                Make = "SUVCo",
                Year = 2024
            };

            // Display as a story or paragraph for each class
            Console.WriteLine("Car Information:");
            Console.WriteLine($"Introducing the {car.Year} {car.Make} {car.Model}!");
            Console.WriteLine($"It's powered by a {car.EngineType} engine with impressive fuel efficiency of {car.FuelEfficiency} MPG.");
            Console.WriteLine($"This stylish vehicle rolls on {car.NumberOfWheels} wheels and weighs in at {car.VehicleWeight} lbs.");
            Console.WriteLine($"With a spacious trunk of {car.TrunkSize} cubic feet, you'll have plenty of room for your belongings.");
            Console.WriteLine($"Learn more about us at {car.CompanyDescription} and check out our logo: {car.CompanyLogo}");

            Console.WriteLine("\nTruck Information:");
            Console.WriteLine($"Introducing the {truck.Year} {truck.Make} {truck.Model}!");
            Console.WriteLine($"It's equipped with a powerful {truck.EngineType} engine with fuel efficiency of {truck.FuelEfficiency} MPG.");
            Console.WriteLine($"This heavy-duty truck rides on {truck.NumberOfWheels} wheels and boasts a weight of {truck.VehicleWeight} lbs.");
            Console.WriteLine($"The truck bed is a spacious {truck.BedSize} feet, perfect for your cargo needs.");
            Console.WriteLine($"Discover more about us at {truck.CompanyDescription} and see our logo: {truck.CompanyLogo}");

            Console.WriteLine("\nSUV Information:");
            Console.WriteLine($"Introducing the {suv.Year} {suv.Make} {suv.Model}!");
            Console.WriteLine($"This eco-friendly SUV runs on a {suv.EngineType} engine, offering a fuel efficiency of {suv.FuelEfficiency} MPG.");
            Console.WriteLine($"With {suv.NumberOfWheels} wheels and a weight of {suv.VehicleWeight} lbs, it's perfect for your adventures.");
            Console.WriteLine($"The cargo hold provides ample space with {suv.CargoHoldSize} cubic feet to store all your gear.");
            Console.WriteLine($"Explore our SUVs at {suv.CompanyDescription} and take a look at our logo: {suv.CompanyLogo}");
        }
    }
}

