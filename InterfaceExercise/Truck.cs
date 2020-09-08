using System;
namespace InterfaceExercise
{
    public class Truck
    {
        public Truck()
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

        public bool GunOwner { get; set; } = true;

        public int TowingTonage { get; set; }


    }
}
