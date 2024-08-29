using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var suv = new SUV();
            suv.Year = 2024;
            suv.Name = "Yukon";
            suv.Model = "GMC"; 
            suv.NumberOfSeats = 7;
            suv.SeatCanBeRemoved = true;
            suv.WebPage = true;
            suv.AgeOfCompany = 24;


            var truck = new Truck();
            truck.Year = 2022;
            truck.Name = "3500 Tradesman";
            truck.Model = "Ram";
            truck.NumberOfTires = 6;
            truck.HasTruckBed = true;
            truck.WebPage = true;
            truck.AgeOfCompany = 35;
            
            var car = new Car();
            car.Year = 1998;
            car.Name = "Camaro";
            car.Model = "Chevy";
            car.FoldingSeat = true;
            car.HasTrunk = true;
            car.WebPage = true;
            car.AgeOfCompany = 80;
            
            Console.WriteLine($"This is my {car.Year} {car.Model} {car.Name}.\nIt's {car.FoldingSeat} the seat fold.");
            Console.WriteLine($"{car.HasTrunk} i can reach the trunk form folding seats.\nThe {car.Name} has been around for about {car.AgeOfCompany} years.");

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
