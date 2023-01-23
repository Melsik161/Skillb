using System;

namespace Work7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Repository rep = new Repository();
            Worker 
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Добро пожаловать в базу данных сотрудников.");
            Console.ResetColor();
            rep.checkFile(); // Проверка существует ли файл Staff.txt
                           // w.startProg(); // Запуск текста помощи.
            while (true)
            {
                char key;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Помощь по программе:");
                Console.ResetColor();
                Console.WriteLine("Чтобы посмотреть список всех сотрудников. Нажите кнопку П");
                Console.WriteLine("Посмотреть информацию о сотруднике по его ID. Нажмите кнопку И");
                Console.WriteLine("Хотите добавить нового сотрудника. Нажмите кнопку Д");
                Console.WriteLine("Хотите удалить сотрудника. Нажмите кнопку У");
                Console.WriteLine("Зарузить записи по выбранному полю. Нажмите кнопку З");
                Console.WriteLine("Хотите закрыть программу. Нажмите лубую другую кнопку");

                key = Console.ReadKey(true).KeyChar;
                if (key == 'п' || key == 'g') rep.GetAllWorkers();
                else if (key == 'и' || key == 'b')
                {
                    Console.Clear();
                    Console.Write("Введите ID сотрудника информация которого нужна: ");
                    rep.getStaffId(Convert.ToInt32(Console.ReadLine()));
                }
                else if (key == 'д' || key == 'l') rep.AddWorker();
                else if (key == 'у' || key == 'e')
                {
                    Console.Clear();
                    Console.WriteLine("Введите ид сотрудника которого хотите удалить: ");
                    rep.DeleteWorker(Convert.ToInt32(Console.ReadLine()));

                }
                else if (key == 'з' || key == 'p')
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Выберете в каком порядке хотите загрузить данные.");
                    Console.ResetColor();
                    Console.WriteLine("Загрузить по алфавиту ФИО. Нажмите кнопку - 1");
                    Console.WriteLine("Загрузить по дате рождения. Нажмите кнопку - 2");
                    Console.WriteLine("Загрузить по возрасту. Нажмите - 3");
                    Console.WriteLine("Загрузить по росту. Нажмите - 4");
                    Console.WriteLine("Загрузить по дате рождения. Нажмите - 5");
                    key = Console.ReadKey(true).KeyChar;
                    if(key == 1 )
                    {
                        var result = rep.OrderBy(t => rep);
                        foreach (w FIO in result)
                        {
                            Console.WriteLine(rep.ToString());
                        }
                    }

                }
                else Environment.Exit(0);
            }
            



        } 
    }
}
