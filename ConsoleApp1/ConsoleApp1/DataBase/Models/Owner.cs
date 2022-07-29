using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataBase.Models
{
    public class Owner : User
    {
        public Owner(string name, string lastName, string fIN) 
            : base(name, lastName, fIN)
        {

        }
    }
}
