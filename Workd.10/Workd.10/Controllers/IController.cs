using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workd._10.Model;

namespace Workd._10.Controllers
{
    public interface IController
    {
        ObservableCollection<Clients> ShowClients();
        ObservableCollection<Logs> ShowLogs();
        
        Clients EditClient(Clients clients, int id, string Surname, string Name, string middlename, string pNumber, string Passport);
    }
}
