using System;
namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public Car()
        {
        }
        public string Name { get; set; }
        public bool AreTheyCool { get; set; }

        public int TopSpeed { get; set; }
        public string CrashTestRating { get; set; }
        public int CostInDollars { get; set; }

        public void Turn(string direction)
        {
            Console.WriteLine($"I'm making a {direction} turn.");
        }


        public string WhichFandF { get; set; } = "it wasn't in a f&f";
        public string BigTrunk { get; set; } = "not really";    
    }
}
