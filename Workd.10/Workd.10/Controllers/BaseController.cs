using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workd._10.Model;

namespace Workd._10.Controllers
{
    public class BaseController
    {
        protected private List<Clients> clients;
        protected private List<Logs> logs;
        public BaseController()
        {
            Repository repository = new Repository();
            clients = repository.GetClients();
            logs = repository.GetLogs();

        }
    }
}
