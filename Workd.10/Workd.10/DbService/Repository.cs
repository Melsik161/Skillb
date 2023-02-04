using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Workd._10.Model;

namespace Workd._10
{
    public class Repository
    {
         List<Clients> db = new List<Clients>();
        List<Logs> logDb = new List<Logs>();

        public Repository()
        {
            int id = 0;
            string line;
            string[] tempLin;
            using (StreamReader sr = new StreamReader("Clients.txt"))
            {

                while ((line = sr.ReadLine()) != null)
                {

                    tempLin = line.Split('#');
                    if(line == "") continue; // Если есть пустая строка в файле, то + итерация.
                    db.Add(new Clients(++id, tempLin[1], tempLin[2], tempLin[3], tempLin[4], tempLin[5]));

                }

            }

            using (StreamReader sr = new StreamReader("Logs.txt"))
            {

                while ((line = sr.ReadLine()) != null)
                {

                    tempLin = line.Split('#');
                    if (line == "") continue; // Если есть пустая строка в файле, то + итерация.
                    logDb.Add(new Logs(int.Parse(tempLin[0]), tempLin[1], tempLin[2], tempLin[3], tempLin[4]));

                }

            }
        }

        public List<Clients> GetClients() { return db; }
        public List<Logs> GetLogs() { return logDb; }
         
    }
}
