using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workd._10
{
    public class Clients
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string middleName { get; set; }
        public string pNumber { get; set; }
        public string Passport { get; set; }
        public Clients(int id, string Surname, string Name, string middleName, string pNumber, string Passport)
        {
            Id = id;
            this.Surname = Surname;
            this.Name = Name;
            this.middleName = middleName;
            this.pNumber = pNumber;
            this.Passport = Passport;
        }

    }
}
