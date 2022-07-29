using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataBase.Models
{
   public abstract class User
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FIN { get; set; }
        public User(string name, string lastName, string fIN)
        {
            Name = name;
            LastName = lastName;
            FIN = fIN;
        }
    }
}
