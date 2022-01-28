

using PhoneBook.Entities;
using System.Collections.Generic;

namespace PhoneBook.Repositories
{
    public class UsersRepository
    {
        public static List<User> Items { get; set; }

        static UsersRepository()
        {
            Items = new List<User>()
            {
                new User()
                {
                    ID = 1,
                    Username = "sadawfga",
                    Password = "password",
                    FirstName = "Petar",
                    LastName = "Valchanov",
                },
                new User()
                {
                    ID = 2,
                    Username = "fdggfhjfgh",
                    Password = "password",
                    FirstName = "Gosho",
                    LastName = "Ivanov",
                },
                new User()
                {
                    ID = 3,
                    Username = "gdfgafgawes",
                    Password = "password",
                    FirstName = "Ivan",
                    LastName = "Petkov",
                },
                new User()
                {
                    ID = 4,
                    Username = "efshfdszer",
                    Password = "password",
                    FirstName = "Miro",
                    LastName = "Dobrev",
                }

            };
        }
    }
}
