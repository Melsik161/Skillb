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
        string Surname { get; set; }
        string Name { get; set; }
        string middleName { get; set; }
        string Passport { get; set; }

        public Clients (int id, string Surname, string Name, string middleName, string Passport)
        {
            this.id = id;
            this.Surname = Surname;
            this.Name = Name;
            this.middleName = middleName;
            this.Passport = Passport;
        }

        public override string ToString()
        {
            return String.Format($"{this.Surname}");
        }
    }
   
}
