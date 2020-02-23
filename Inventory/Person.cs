using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string MyProperty
        {
            get
            {
                // "Tim Corey {test@test.com}
                return $"{ FirstName}{LastName}({ Email })";


            }
        }

    }
}
