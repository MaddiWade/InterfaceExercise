using System;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Color = "Blue", Logo = "A Ram", MilesPerGallon = 25, NumberOfWheels = 4, PubliclyTraded = true, RowOfSeats = 2, MiddleSeatBelt = false, Trunk = true };
            Truck truck = new Truck() { Color = "Red", RowOfSeats = 1, PubliclyTraded = true, NumberOfWheels = 4, MilesPerGallon = 17, BedLength = 6, Logo = "Jeep", MiddleFrontSeat = false };
            SUV suv = new SUV() { Logo = "4 interlocking rings", MilesPerGallon = 20, NumberOfWheels = 4, PubliclyTraded = true, RowOfSeats = 3, AutomaticDoor = true, Color = "Grey", TvInstallation = true };

            

            Console.WriteLine("Hello! thanks for renting a car from us! This is what we have left for you to choose from!:");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine("car");
            Console.WriteLine("truck");
            Console.WriteLine("suv");
            Console.WriteLine("Please enter which vehicle you would like to rent!");
           
            String rental = Console.ReadLine();
            string lowercase = rental.ToLower();
            
            

            
            
                
                if  (lowercase.Contains("car"))
                {
                    Console.WriteLine("Great we have the perfect one in stock!!");
                    Console.WriteLine($" It is a {car.Color} Ram with {car.RowOfSeats} rows of seats! ");     
                }
                else if (lowercase.Contains("truck"))
                {
                    Console.WriteLine("Great we have the perfect one in stock!!");
                    Console.WriteLine($"It is a {truck.Color} Jeep with a {truck.BedLength} foot bed!");    
                }
                else if (lowercase.Contains("suv"))
                {
                    Console.WriteLine("Great we have the perfect one in stock!!");
                    Console.WriteLine($"It is a {suv.Color} Audi with {suv.MilesPerGallon} Miles Per Gallon!");
                }
                else
                {
                    Console.WriteLine("Im sorry we do not have that in stock currently!!");
                    Console.WriteLine("Sorry to disapoint! please reenter the program to select a different type!");  
                }
            
            
                

                 
                
            
            


        }
    }
}