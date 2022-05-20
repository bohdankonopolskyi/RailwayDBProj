using System;
namespace RailwaySystem.Models
{
    public class Train
    {
        public int TrainID { get; set; }
        public string Train_number { get; set; }
        public string Association { get; set; }

        public Train()
        {

        }

        public Train(int Train_Id, string Train_Number, string Association)
        {
            TrainID = Train_Id;
            Train_number = Train_Number;
            this.Association = Association;
        }
    }
}
