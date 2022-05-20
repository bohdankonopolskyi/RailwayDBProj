using System;
namespace RailwaySystem.Models
{
    public class Passenger
    {
        public int PassengerID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string DocumentNumber { get; set; }

        public Passenger()
        {
        }

        public Passenger(int passengerID, string surname, string name, string patronymic, string documentNumber)
        {
            PassengerID = passengerID;
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic));
            DocumentNumber = documentNumber ?? throw new ArgumentNullException(nameof(documentNumber));
        }
    }
}
