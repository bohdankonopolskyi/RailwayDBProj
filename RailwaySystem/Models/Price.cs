using System;
using RailwaySystem.Models;
namespace RailwaySystem.Models
{
    public class WagonSeatPrice
    {
        public Wagon Wagon { get; set; }
        public decimal Price { get; set; }
        public DateTime ActualDate { get; set; }


        public WagonSeatPrice()
        {
        }
        public WagonSeatPrice(Wagon wagon, decimal price, DateTime actualdate)
        {
            this.Wagon = wagon;
            this.Price = price;
            this.ActualDate = actualdate;
        }
    }
}
