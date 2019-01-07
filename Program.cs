using System;
using VechiclesClassLibrary.LibraryData;

namespace VehicleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

           
            //Instansierar default vehicle för att får med överlagrad konstruktor i inlämningen eftersom det var krav på de
            DefaultVehicle New_DefaultVehicle = new DefaultVehicle("Tesla", 220, "Model X");

            Console.WriteLine("***********************************************");
            Console.WriteLine();

            Console.WriteLine("Welcome to the Vehicle Application");
            Console.WriteLine();

            Console.WriteLine("You have been assigned a default car");
            Console.WriteLine("Car info is below");

            //info om default vehicle

            Console.WriteLine(New_DefaultVehicle.Name);
            Console.WriteLine(New_DefaultVehicle.Model);
            Console.WriteLine(New_DefaultVehicle.TopSpeed + " km/h");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine();

            //Ger alternativ till att skapa en ny bil, för att få med polymorfism i uppfiten, skapas i facatory som skapas i Vehiclebase,
            //vilket ärvs av CarOne, CarTwo och CarThree, som är bilarna som skapas
            Console.WriteLine("Do you want to explore the other vehicles?");
            Console.WriteLine();
            Console.WriteLine("Press 1 to reveal the first car");
            Console.WriteLine("Press 2 to reveal the second car");
            Console.WriteLine("Press 3 to reveal the third car");

            //Begär indata för att lägga in siffran som argument i switchsatsen i factory för att skapa respektive bil
            int ChoiceInput = int.Parse(Console.ReadLine());
            VehiclesBase New_Vehicle = Factory.ChooseCar(ChoiceInput);

            Console.WriteLine("You have revealed the " + New_Vehicle.Name);
            Console.WriteLine("To get additional car info write info");

                string InfoInput = Console.ReadLine();

            //Begär indata i form av text för att sedan skriva ut info om respektive bil som skapats
            if(InfoInput == "info")
            {
                New_Vehicle.GetCarInfo();
            }

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();

            //Gjorde detta för att få med enum i uppgiften, riktningar ligger i enum och skapas som innan, med hjälp av
            //factory, blir to string sedan för att skriva ut vilket håll bilen åker i i konsollen
            Console.WriteLine("You can now choose to drive, type forward, backward, left or right!");
            Console.WriteLine();

            string DriveInput = Console.ReadLine();

            
            New_Vehicle.Drive(DriveInput);

            Console.WriteLine("******************************************");

            //Här har jag angett värden för calculatorn för att den ska ha data att jobba med.
            Calculator.NumberOne = 2;
            Calculator.NumberTwo = 3;

            Calculator.Calculate();

            Console.ReadLine();
        }
    }
}

