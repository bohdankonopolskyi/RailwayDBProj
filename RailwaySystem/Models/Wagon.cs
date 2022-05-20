using System;
using RailwaySystem.Models;
namespace RailwaySystem
{
    public class Wagon
    {
        public int WagonID { get; set; }
        public Train Train { get; set; }
        public int WagonNumber { get; set; }
        public int WagonClass { get; set; }
        public int AmountOfSeats { get; set; }


        public Wagon()
        {
        }

        public Wagon(int WagonID, Train Train, int WagonNumber,int WagonClass, int AmountOfSeats )
        {
            this.WagonID = WagonID;
            this.Train = Train;
            this.WagonNumber = WagonNumber;
            this.WagonClass = WagonClass;
            this.AmountOfSeats = AmountOfSeats;
        }
    }
}
