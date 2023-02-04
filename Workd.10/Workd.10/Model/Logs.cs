using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workd._10.Model
{
    public class Logs
    {
        public int id { get; set; }
        public string Data { get; set; }
        public string Changed { get; set; }
        public string typeChanged { get; set; }
        public string whoChanged { get; set; }
        
        public Logs(int id, string data, string changed, string typeChanged, string whoChanged)
        {
            this.id = id;
            this.Data = data;
            this.Changed = changed;
            this.typeChanged = typeChanged;
            this.whoChanged = whoChanged;
        }
    }
}
