using System;
using System.IO;
using System.Text;


namespace Work6
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("Staff.txt"))
            {
                FileInfo nFile = new FileInfo("Staff.txt");
                FileStream fs = nFile.Create();
                fs.Close();
            }
            Console.WriteLine("База сотрудников. Хотите прочитать базу? Нажмите '1' и кнопку Enter. Хотите записать в базу? Нажмите '2' и Enter");
            byte option = Convert.ToByte(Console.ReadLine());
            if (new FileInfo("Staff.txt").Length == 0)
            {
                char key = 'д';
                Console.WriteLine("Файл c сотрудниками пуст");
                Console.WriteLine("Хотите заполнить? Если Да- нажмите кнопку д, если хотите выйти с программы нажмите любую другую копоку");
                key = Console.ReadKey(true).KeyChar; ;
                if (key == 'д' || key=='l') setStaff();
                else Environment.Exit(0);
            }
            if (option == 1) getStaffWrite();
            else if (option == 2) setStaff();
        }
        static void getStaffWrite()
        {
 
                using(StreamReader sr = new StreamReader("Staff.txt"))
                {
                        string line;
                        Console.WriteLine($"Id {" Время добавления сот",5} {"Фио сотрудника",5} {"Возраст",5} {"Рост",5} {"Дата рождения",3} {"Место рождения"}");
                        while ((line = sr.ReadLine()) !=null)
                        {
                        string[] data = line.Split('#');
                        Console.WriteLine($"{data[0]} || {data[1]} || {data[2]} || {data[3]} || {data[4]} || {data[5]} || {data[6]}");
                        }
                }
        }
        static void setStaff()
        {
            using (StreamWriter sw = new StreamWriter("Staff.txt", true, Encoding.Unicode))
            {
                char key = 'д';
                do
                {
                    string note = string.Empty;
                    Console.Write("Введите ID сотрудника:");
                    note += $"{Console.ReadLine()}#";

                    DateTime dateNow = DateTime.Now;
                    string now = Convert.ToString(dateNow);
                    Console.WriteLine($"Время и дата добавления сотрудник:{dateNow:g}");
                    note += $"{now:g}#";

                    Console.Write("Введите полно ФИО сотрудника:");
                    note += Console.ReadLine() + "#";

                    Console.Write("Введите возраст сотрудника:");
                    note += Console.ReadLine() + "#";

                    Console.Write("Введите рост сотрудника:");
                    note += Console.ReadLine() + "#";

                    Console.Write("Введите дату рождения сотрудника:");
                    note += Console.ReadLine() + "#";

                    Console.Write("Введите место рождения сотрудника:");
                    note += Console.ReadLine();
                    sw.WriteLine(note);

                    Console.Write("Продолжить заполнение? Да- нажмите кнопку Д, Нет - Нажмите н");
                    key = Console.ReadKey(true).KeyChar;
                    Console.WriteLine();
                } while (char.ToLower(key) == 'д');
            }
        }

        
    }
}
