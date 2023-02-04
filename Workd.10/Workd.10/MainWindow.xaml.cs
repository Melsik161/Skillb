using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Workd._10.Controllers;
using Workd._10.Model;
using System.Collections.ObjectModel;

namespace Workd._10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IController consultant = new Consultant();
        IController manager = new Manager();
        byte clicked;
        ObservableCollection<Clients> db;
        ObservableCollection<Logs> logs;
        public MainWindow()
        {
            InitializeComponent();
            ClientLogs(BoxShow.SelectedIndex);

        }

        private void Worker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BoxShow.Items.Clear();
            switch (Worker.SelectedIndex)
            {
                case 0:
                    db = consultant.ShowClients();
                    foreach (var item in db)
                    {
                        BoxShow.Items.Add($"Id#{item.Id} {item.Surname} {item.Name} {item.middleName}");
                    }
                    break;
                case 1:
                    db = manager.ShowClients();
                    foreach (var item in db)
                    {
                        BoxShow.Items.Add($"Id#{item.Id} {item.Surname} {item.Name} {item.middleName}");

                    }
                    break;
                default:
                    break;
            }

           

        }

        private void BoxShow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BoxLogs.Items.Clear();
            if (BoxShow.Items.Count == 0) return;// если 0 колонок то выходим. Когда переключаешь Комбобокс и есть данные, то крашится программа.
            lSurname.Content = db[BoxShow.SelectedIndex].Surname;
            lName.Content = db[BoxShow.SelectedIndex].Name;
            lMiddleName.Content = db[BoxShow.SelectedIndex].middleName;
            lpNumber.Content = db[BoxShow.SelectedIndex].pNumber;
            lPassport.Content = db[BoxShow.SelectedIndex].Passport;
            UpadateLogs(BoxShow.SelectedIndex);


        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            switch (clicked)
            {
                case 0:
                    manager.EditClient(db[BoxShow.SelectedIndex], BoxShow.SelectedIndex, EditText.Text, db[BoxShow.SelectedIndex].Name,
                        db[BoxShow.SelectedIndex].middleName, db[BoxShow.SelectedIndex].pNumber, db[BoxShow.SelectedIndex].Passport);
                    logs.Add(new Logs(db[BoxShow.SelectedIndex].Id-1, DateTime.Now.ToString("dd.MM.yyyy"), $"Было:{lSurname.Content} Стало{EditText.Text}", "Фамилию", Worker.Text));
                    BoxLogs.Items.Add("Время:"+DateTime.Now.ToString("dd.MM.yyyy")+ " Что меняли:Фамилия Было:" + lSurname.Content+ " Стало:"+EditText.Text+ "Кто:"+Worker.Text);
                    lSurname.Content = EditText.Text;
                    EditText.Clear();
                    break;
                case 1:
                    manager.EditClient(db[BoxShow.SelectedIndex], BoxShow.SelectedIndex, db[BoxShow.SelectedIndex].Surname, EditText.Text,
                        db[BoxShow.SelectedIndex].middleName, db[BoxShow.SelectedIndex].pNumber, db[BoxShow.SelectedIndex].Passport);
                    logs.Add(new Logs(db[BoxShow.SelectedIndex].Id - 1, DateTime.Now.ToString("dd.MM.yyyy"), $"Было:{lName.Content} Стало{EditText.Text}", "Фамилию", Worker.Text));
                    BoxLogs.Items.Add("Время:" + DateTime.Now.ToString("dd.MM.yyyy") + " Что меняли:Имя Было:" + lSurname.Content + " Стало:" + EditText.Text + "Кто:" + Worker.Text);
                    lName.Content = EditText.Text;
                    EditText.Clear();
                    break;
                case 2:
                    manager.EditClient(db[BoxShow.SelectedIndex], BoxShow.SelectedIndex, db[BoxShow.SelectedIndex].Surname, db[BoxShow.SelectedIndex].Name,
                        EditText.Text, db[BoxShow.SelectedIndex].pNumber, db[BoxShow.SelectedIndex].Passport);
                    logs.Add(new Logs(db[BoxShow.SelectedIndex].Id - 1, DateTime.Now.ToString("dd.MM.yyyy"), $"Было:{lSurname.Content} Стало{EditText.Text}", "Фамилию", Worker.Text));
                    BoxLogs.Items.Add("Время:" + DateTime.Now.ToString("dd.MM.yyyy") + " Что меняли:Отчество Было:" + lMiddleName.Content + " Стало:" + EditText.Text + "Кто:" + Worker.Text);
                    lMiddleName.Content = EditText.Text;
                    EditText.Clear();
                    break;
                case 3:
                    consultant.EditClient(db[BoxShow.SelectedIndex], BoxShow.SelectedIndex, db[BoxShow.SelectedIndex].Surname, db[BoxShow.SelectedIndex].Name, 
                        db[BoxShow.SelectedIndex].middleName, EditText.Text, db[BoxShow.SelectedIndex].Passport);
                    logs.Add(new Logs(db[BoxShow.SelectedIndex].Id - 1, DateTime.Now.ToString("dd.MM.yyyy"), $"Было:{lpNumber.Content} Стало{EditText.Text}", "Фамилию", Worker.Text));
                    BoxLogs.Items.Add("Время:" + DateTime.Now.ToString("dd.MM.yyyy") + " Что меняли:Номер Было:" + lpNumber.Content + " Стало:" + EditText.Text + "Кто:" + Worker.Text);
                    lpNumber.Content = EditText.Text;
                    EditText.Clear();
                    break;
                case 4:
                    manager.EditClient(db[BoxShow.SelectedIndex], BoxShow.SelectedIndex, db[BoxShow.SelectedIndex].Surname, db[BoxShow.SelectedIndex].Name,
                        db[BoxShow.SelectedIndex].middleName, db[BoxShow.SelectedIndex].pNumber, EditText.Text);
                        logs.Add(new Logs(db[BoxShow.SelectedIndex].Id - 1, DateTime.Now.ToString("dd.MM.yyyy"), $"Было:{lpNumber.Content} Стало{EditText.Text}", "Фамилию", Worker.Text));
                        BoxLogs.Items.Add("Время:" + DateTime.Now.ToString("dd.MM.yyyy") + " Что меняли:Паспорт Было:"+lPassport.Content+ "Стало:"+EditText.Text+ " Кто:" + Worker.Text);
                        
                    lPassport.Content = EditText.Text;
                    EditText.Clear();
                    break;
                default:
                    break;
            }
        }

        public void UpadateLogs(int id)
        {
            BoxLogs.Items.Clear();
            foreach (var item in logs)
            {
                    BoxLogs.Items.Add($"Время:{item.Data} Что меняли: {item.typeChanged} {item.Changed} Кто:{item.whoChanged}");
                
            }
        }
        private void ClientLogs(int id)
        {
            logs = consultant.ShowLogs();
            foreach (var item in logs)
            {
                if (item.id != id) continue;
                BoxLogs.Items.Add($"Время:{item.Data} Что меняли: {item.typeChanged} {item.Changed} Кто:{item.whoChanged}");
            }
        }
        //BoxLogs.Items.Add(new Logs($"Время: {item.Data} Что меняли: {item.typeChanged} Какое поле меняли:{item.Changed} Кто:{item.whoChanged}"));
        private void lSurname_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex != 1) return;
            EditText.Text = lSurname.Content.ToString();
            clicked = 0;
        }

        private void lName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex != 1) return;
            EditText.Text = lName.Content.ToString();
            clicked = 1;
        }

        private void lMiddleName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex != 1) return;
            EditText.Text = lMiddleName.Content.ToString();
            clicked = 2;
        }
        private void lpNumber_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            EditText.Text = lpNumber.Content.ToString();
            clicked = 3;
        }

        private void lPassport_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex != 1) return;
            EditText.Text = lPassport.Content.ToString();
            clicked = 4;
        }

        private void LoadLogs_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BoxLogs.Items.Clear();
            foreach (var item in logs)
            {
                BoxLogs.Items.Add($"{item.id} Время:{item.Data} Что меняли: {item.typeChanged} {item.Changed} Кто:{item.whoChanged}");
            }
        }
    }
}
