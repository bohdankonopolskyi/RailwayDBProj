using System;
namespace RailwaySystem.Models
{
    public class Station
    {
        public int StationID { get; set; }
        public string StationName { get; set; }
        public string Locality { get; set; }

        public Station()
        {
        }
        public Station(int StationId, string stationName, string Locality)
        {
            this.StationID = StationId;
            this.StationName = StationName;
            this.Locality = this.Locality;
        }
    }
}
