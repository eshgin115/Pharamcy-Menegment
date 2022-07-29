using ConsoleApp1.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataBase.Repository
{
    public class UserRepo
    {
        private static int _idcounter;

        public static int IDCounter
        {
            get
            {
                _idcounter++;
                return _idcounter;
            }
        }
        private static int _numberOnTheList;




        public static List<User> users { get; set; } = new List<User>()
        {

        };


        public static User Add(User user)
        {
            users.Add(user);
            return user;
        }
        public static List<User> GetAll()
        {
           return users;
        }
        public static List<Owner> GetAllOwners()
        {
            List<Owner> owners = new List<Owner>();

            foreach (User user in users)
            {
                if (user is Owner)
                {
                    owners.Add((Owner)user);
                }
            }

            return owners;
        }
        public static List<Seller> GetAllSellers()
        {

        }



        public static void Delete(User user)
        {
            users.Remove(user);
        }

    }
}
