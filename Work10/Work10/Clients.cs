using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Work10
{
    class Clients
    {
        int id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string middleName { get; set; }
        public string phoneNumber { get; set; }
        public string Passport { get; set; }

        public Clients (int id, string Surname, string Name, string middleName, string phoneNumber, string Passport)
        {
            this.id = id;
            this.Surname = Surname;
            this.Name = Name;
            this.middleName = middleName;
            this.phoneNumber = phoneNumber;
            this.Passport = Passport;
        }
    }
   
}
