using System;
namespace RailwaySystem.Models
{
    public class StationInRoute
    {
        public int StationInRouteID { get; set; }
        public Station Station { get; set; }
        public Train Train { get; set; }
        public DateTime DepatureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }

        public StationInRoute()
        {
        }

        public StationInRoute(int stationInRouteID, Station station, Train train, DateTime depatureDateTime, DateTime arrivalDateTime)
        {
            this.StationInRouteID = stationInRouteID;
            this.Station = station;
            this.Train = train;
            this.DepatureDateTime = depatureDateTime;
            this.ArrivalDateTime = arrivalDateTime;
        }
    }
}
