using System;
namespace InterfaceExercise
{
    public class SUV
    {
        public SUV()
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

        public bool IsOwnedBySoccerMom { get; set; } = true;

        public void IsTransformer ()
        {
            Console.WriteLine($"No, this {Name} is not a transformer...probably");
        }
    }
}
