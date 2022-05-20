using System;
namespace RailwaySystem.Models
{
    public class Route
    {
        public  int RouteID { get; set; }
        public Train Train { get; set; }
        public string Association { get; set; }
        
        public Route()
        {
        }
    }
}
