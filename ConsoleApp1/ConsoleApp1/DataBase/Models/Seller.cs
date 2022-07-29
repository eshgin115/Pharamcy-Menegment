using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataBase.Models
{
    class Seller : User
    {
        public string Education { get; set; }
        public string Experience { get; set; }

        public Seller(string name, string lastName, string fIN,string education,string experience)
            : base(name, lastName, fIN)

        {
            Education = education;
            Experience = experience;
        }
    }
}
