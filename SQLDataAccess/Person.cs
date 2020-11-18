using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDataAccess
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{FirstName} {LastName} ({EmailAddress})";
            }
        }
    }
}
