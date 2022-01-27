using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Application.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime OrderDate { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
