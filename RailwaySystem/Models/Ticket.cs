using System;
namespace RailwaySystem.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public Payment Payment { get; set; }
        public StationInRoute DepatureStation { get; set; }
        public StationInRoute ArrivalStation { get; set; }
        public Passenger Passenger {get; set;}
        public string Status { get; set; }

        public Ticket(int ticketID, Payment payment, StationInRoute depatureStation, StationInRoute arrivalStation, Passenger passenger, string status)
        {
            TicketID = ticketID;
            Payment = payment;
            if (depatureStation != arrivalStation)
            {
                DepatureStation = depatureStation ?? throw new ArgumentNullException(nameof(depatureStation));
                ArrivalStation = arrivalStation ?? throw new ArgumentNullException(nameof(arrivalStation));

            }
            Passenger = passenger ?? throw new ArgumentNullException(nameof(passenger));
            Status = status ?? throw new ArgumentNullException(nameof(status));
        }

        public Ticket()
        {
        }
    }
}
