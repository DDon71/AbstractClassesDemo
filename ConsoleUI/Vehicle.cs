using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2021";
        public string Make { get; set; } = "Ferrari";
        public string Model { get; set; } = "SF90";

        public abstract void DriveAbstract(); // stubbed out method

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }

        
    }
}

