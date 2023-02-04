using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Workd._10.Model;

namespace Workd._10.Controllers
{
    public class Consultant : BaseController, IController
    {
        public Consultant() : base() { }

        public ObservableCollection<Logs> ShowLogs()
        {
            ObservableCollection<Logs> logDb = new ObservableCollection<Logs>();
            foreach (Logs item in logs)
            {
                Logs tempLogs = item;
                logDb.Add(tempLogs);
            }
            return logDb;
        }
        public ObservableCollection<Clients> ShowClients()
        {
            ObservableCollection<Clients> dbclients = new ObservableCollection<Clients>();
            
            foreach (Clients client in clients)
            {
                Clients tempClient = client;
                if(client.Passport != null)
                {
                    tempClient.Passport = "***********";
                }
                dbclients.Add(tempClient);

            }
            return dbclients;
        }

        Clients IController.EditClient(Clients clients, int id, string Surname, string Name, string middlename, string pNumber, string Passport)
        {
            Clients newClient = clients;
            if (pNumber != null)
            {
                newClient.pNumber = pNumber;
            }
            return newClient;
        }

    }
}
