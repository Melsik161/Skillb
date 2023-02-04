using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Workd._10.Model;

namespace Workd._10.Controllers
{
    class Manager : BaseController, IController
    {
        public Clients EditClient(Clients clients, int id, string Surname, string Name, string middlename, string pNumber, string Passport)
        {
            Clients newClient = clients;
            if (pNumber != null)
            {
                newClient.Surname = Surname;
                newClient.Name = Name;
                newClient.middleName = middlename;
                newClient.Passport = Passport;
                newClient.pNumber = pNumber;
            }
            return newClient;
        }

        public ObservableCollection<Clients> ShowClients()
        {
            ObservableCollection<Clients> db = new ObservableCollection<Clients>();
            foreach (Clients item in clients)
            {
                Clients tempClient = item;
                db.Add(tempClient);
            }
            return db;
        }

        public ObservableCollection<Logs> ShowLogs()
        {
            throw new NotImplementedException();
        }
    }
}
