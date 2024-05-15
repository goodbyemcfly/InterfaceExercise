using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // DONE Create 2 Interfaces called IVehicle & ICompany

            // DONE Create 3 classes called Car , Truck , & SUV

            // DONE Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            var carOne = new Car()
            {
                Color = "Blue",
                TireSize = 15,
                NumberOfWheels = 4,
                Model = "Prius",
                NumberOfDoors = 4,
                HasTrunk = true,
                CompanyName = "Toyota",
                CountryOfOrigin = "Japan",

            };

            var suvOne = new SUV()
            {
                HasSpareTire = true,
                NumberOfSeats = 8,
                NumberOfWheels = 4,
                Model = "Trailblazer",
                NumberOfDoors = 4,
                HasTrunk = true,
                CompanyName = "Chevy",
                CountryOfOrigin = "the sUnited States",
            };

            var truckOne = new Truck()
            {
                BedSize = 8,
                HasFourWheelDrive = true,
                NumberOfWheels = 4,
                Model = "F-150",
                NumberOfDoors = 2,
                HasTrunk = false,
                CompanyName = "Ford",
                CountryOfOrigin = "the United States",
            };

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            Console.WriteLine("Welcome to the vehicle lot. We currently have three vehicles on display.");
            Console.WriteLine("Please choose the car you would like to see the specs for:");
            Console.WriteLine("1: Toyota Prius");
            Console.WriteLine("2: Chevy Trailblazer");
            Console.WriteLine("3: Ford F-150");

            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine($"This {carOne.CompanyName} {carOne.Model} was made in {carOne.CountryOfOrigin}.");
                Console.WriteLine($"It has {carOne.NumberOfDoors} doors as well as {carOne.NumberOfWheels} wheels with {carOne.TireSize}cm tires.");
                Console.WriteLine($"The only color we currently hav availble is {carOne.Color}.");
            }

            if (userInput == 2)
            {
                Console.WriteLine($"This {suvOne.CompanyName} {suvOne.Model} was made in {suvOne.CountryOfOrigin}.");
                Console.WriteLine($"It has {suvOne.NumberOfDoors} doors as well as {suvOne.NumberOfWheels} wheels and seats {suvOne.NumberOfSeats} people total.");

                if (suvOne.HasSpareTire = true)
                {
                    Console.WriteLine("This model DOES come with a spare tire completely free");
                }
                else
                {
                    Console.WriteLine("This model DOES NOT come with a spare tire.");
                }
            }
            if (userInput == 3)
            {
                Console.WriteLine($"This {truckOne.CompanyName} {truckOne.Model} was made in {truckOne.CountryOfOrigin}.");
                Console.WriteLine($"It has {truckOne.NumberOfDoors} doors as well as {truckOne.NumberOfWheels} wheels with a bed size of {truckOne.BedSize}ft.");
                
                if (truckOne.HasFourWheelDrive = true)
                {
                    Console.WriteLine("This model also features four wheel drive!");
                }
                else
                {
                    Console.WriteLine("This model does not feature four wheel drive.");
                }
            }
            else
            {
                Console.WriteLine($"I'm sorry, your input of '{userInput}' is not a valid input. Please reopen the applicaton and try again.");
            }
        }
    }
}
