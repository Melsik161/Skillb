using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Work7
{
    class Repository
    {
        string[] lin;
        public int staff;
        private int count;
        Worker[] workers = new Worker[1];
        /// <summary>
        /// Метод для котрый меняет массив на количество строк в массиве
        /// </summary>
        public void leтWorkers()
        {
            using (StreamReader sr = new StreamReader("Staff.txt"))
            {
                string line;
                count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    Array.Resize(ref workers, count);
                    
                }

            }
        }
        
        /// <summary>
        /// Загрузка списка сотрудников
        /// </summary>
        public void loadStaffs()
        {
            string line;
            leтWorkers();
            using (StreamReader sr = new StreamReader("Staff.txt"))
            {
                staff = 0;
                
                while ((line = sr.ReadLine()) != null)
                {
                    
                    lin = line.Split('#');
                    if (line == "") continue; // Если есть пустая строка в файле, то + итерация.
                    workers[staff].id = Convert.ToInt32(lin[0]);
                    workers[staff].dateCreate = Convert.ToDateTime(lin[1]);
                    workers[staff].FIO = lin[2];
                    workers[staff].age = Convert.ToByte(lin[3]);
                    workers[staff].height = Convert.ToByte(lin[4]);
                    workers[staff].birthday = lin[5];
                    workers[staff].pBirth = lin[6];
                    staff++;

                }
            }
        }
        /// <summary>
        /// Проверка существования файла
        /// </summary>
        public void checkFile()
        {
            if (!File.Exists("Staff.txt"))
            {
                FileInfo nFile = new FileInfo("Staff.txt");
                FileStream fs = nFile.Create();
                fs.Close();
            }
            loadStaffs();
        }
        /// <summary>
        /// Вывод информации о всех сотрудниках
        /// </summary>
        /// <returns></returns>
        public Worker[] GetAllWorkers()

        {
            Console.Clear();
            Console.WriteLine($"Id {" Время добавления сот",5} {"Фио сотрудника",5} {"Возраст",5} {"Рост",5} {"Дата рождения",3} {"Место рождения"}");
            for (int i = 0; i < staff; i++)
            {
                Console.WriteLine($"{workers[i].id} || {workers[i].dateCreate,5} || {workers[i].FIO,5} || {workers[i].age,5} " +
                        $"|| {workers[i].height,5} || {workers[i].birthday,5} || {workers[i].pBirth,5}");
            }
                
            Console.WriteLine($"Количество сотрудников:{staff}");
            Console.WriteLine("_________________________________________________________________________________");
            return workers;
        }
        /// <summary>
        /// Вывод информации о сотруднике по ID
        /// </summary>
        /// <param name="id"></param>
        public void getStaffId(int id)
        {
            Console.Clear();
            if (id > -1 && id <= staff)
            {
                id--;
                Console.WriteLine($"Id {" Время добавления сот",5} {"Фио сотрудника",5} {"Возраст",5} {"Рост",5} {"Дата рождения",3} {"Место рождения"}");
                Console.WriteLine($"{workers[id].id} || {workers[id].dateCreate} || {workers[id].FIO} || {workers[id].age} " +
                            $"|| {workers[id].height} || {workers[id].birthday} || {workers[id].pBirth}");
            }     
            else 
            {
                Console.WriteLine("Такого сотрудника нет!");
            }
        }
        public void AddWorker()
        {
            Console.Clear();
            string line;
            StreamWriter sw = new StreamWriter("Staff.txt", append:true);
           
            staff++;
            line = staff + "#";
            line += DateTime.Now + "#";
            Console.Write("Введите Ф.И.О. сотрудника: ");
            line += Console.ReadLine()+"#";
            Console.Write("Введите возраст сотрудника: ");
            line += Console.ReadLine()+"#";
            Console.Write("Введите рост сотрудника: ");
            line += Console.ReadLine() + "#";
            Console.Write("Введите дату рождения сотрудника. Пример 01.01.1991: ");
            line += Console.ReadLine() + "#";
            Console.Write("Введите место рождения сотрудника: ");
            line += "город " + Console.ReadLine();
            sw.WriteLine(line);
            sw.Close();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Сотрудник внесе в базу. Его уникальный ид: {0}",staff);
            Console.ResetColor();
  
            loadStaffs();
            

        }
        /// <summary>
        /// Метод удаления сотрудника
        /// </summary>
        /// <param name="id"></param>
        public void DeleteWorker(int id)
        {
            StreamWriter sw = new StreamWriter("Staff.txt");
            string lin;
            for (int i = id-1; i < staff; i++)
            {
                if ((i+1) == count)
                {
                    Array.Resize(ref workers, i);
                    break;
                }
                workers[i].id = workers[i + 1].id;
                workers[i].dateCreate = workers[i + 1].dateCreate;
                workers[i].FIO = workers[i + 1].FIO;
                workers[i].age = workers[i + 1].age;
                workers[i].height = workers[i + 1].height;
                workers[i].birthday = workers[i + 1].birthday;
                workers[i].pBirth = workers[i + 1].pBirth;
                workers[i].id--;
            }
            for (int i = 0; i < workers.Length; i++)
            {
                lin = Convert.ToString(workers[i].id)+ "#" + workers[i].dateCreate + "#" + workers[i].FIO + "#" + Convert.ToString(workers[i].age)
                   + "#" + Convert.ToString(workers[i].height) + "#" + Convert.ToString(workers[i].birthday) + "#" + workers[i].pBirth;
                sw.WriteLine(lin);
            }
            sw.Close();
            staff--;
           
            GetAllWorkers();
        }
        
    }
}
