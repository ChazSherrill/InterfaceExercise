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
            var supra = new Car() { AreTheyCool = false, Name = "Toyota", CostInDollars = 55000, BigTrunk = "lol no", CrashTestRating = "No one knows", TopSpeed = 155, WhichFandF = "Fast and Furious1" };
            var yukon = new SUV() { TopSpeed = 120, CrashTestRating = "pretty good", CostInDollars = 75000, Name = "chevy", AreTheyCool = false, IsOwnedBySoccerMom = true };
            var titain = new Truck() { AreTheyCool = false, Name = "Nissan", CostInDollars = 30000, CrashTestRating = "probably good", GunOwner = true, TopSpeed = 114, TowingTonage = 1023103123 };

            for (int i = 0; i < 3; i++)
            {
                if (supra.TopSpeed > yukon.TopSpeed && supra.TopSpeed > titain.TopSpeed )
                {
                    Console.WriteLine("Vrrom vrrom there goes the supra.");
                }
            }

            yukon.IsTransformer();

            Console.WriteLine("Do you need to tow? ");
            string answer = Console.ReadLine();
            if("yes" == answer.ToLower())
            {
                Console.WriteLine("How much do you need to tow");
                int tonnnaagee = int.Parse(Console.ReadLine());
                if (tonnnaagee < titain.TowingTonage)
                {
                    Console.WriteLine("Let's get it moving!");
                }
                else
                {
                    Console.WriteLine("You're shit outta luck");
                }
            }
        }
    }
}
