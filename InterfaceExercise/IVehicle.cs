using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {

        public int TopSpeed { get; set; }
        public string CrashTestRating { get; set;  }
        public int CostInDollars { get; set; }

        public void Turn(string direction);


    }
}
