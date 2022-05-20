using System;
namespace RailwaySystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(int userID, string surname, string name, string patronymic, string login, string password)
        {
            UserID = userID;
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic));
            Login = login ?? throw new ArgumentNullException(nameof(login));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public User()
        {
        }
    }
}
