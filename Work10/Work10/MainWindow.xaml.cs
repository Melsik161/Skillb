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
using System.Collections.ObjectModel;
using System.IO;

namespace Work10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Clients> db = new ObservableCollection<Clients>();
        byte tempClick;
        public MainWindow()
        {
            InitializeComponent();
            int id = 0;
            string line;
            string[] tempLin;
            using (StreamReader sr = new StreamReader("Clients.txt"))
            {

                while ((line = sr.ReadLine()) != null)
                {

                    tempLin = line.Split('#');
                    if (line == "") continue; // Если есть пустая строка в файле, то + итерация.
                    db.Add(new Clients(++id, tempLin[1], tempLin[2], tempLin[3], tempLin[4], tempLin[5]));

                }

            }
            ClientList.ItemsSource = db;

        }

        private void ClientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lSurname.Content = db[ClientList.SelectedIndex].Surname;
            lName.Content = db[ClientList.SelectedIndex].Name;
            lMiddleName.Content = db[ClientList.SelectedIndex].middleName;
            lNumber.Content = db[ClientList.SelectedIndex].phoneNumber;

            if (Worker.SelectedIndex == 0) lPassport.Content = "***********";
            else lPassport.Content = db[ClientList.SelectedIndex].Passport;

        }

        private void SaveEdit_Click(object sender, RoutedEventArgs e)
        {
            switch (tempClick)
            {
                case 1:
                    MessageBox.Show($"Паспорт изменен!\nБыл {lPassport.Content}\nСтал {EditInform.Text}");
                    lPassport.Content = EditInform.Text;
                    db[ClientList.SelectedIndex].Passport = EditInform.Text;
                    EditInform.Clear();
                    break;
                case 2:
                    MessageBox.Show($"Отчество изменено!\nБыло {lMiddleName.Content}\nСтал {EditInform.Text}");
                    lMiddleName.Content = EditInform.Text;
                    db[ClientList.SelectedIndex].middleName = EditInform.Text;
                    EditInform.Clear();
                    break;
                case 3:
                    MessageBox.Show($"Имя изменен!\nБыл {lName.Content}\nСтал {EditInform.Text}");
                    lName.Content = EditInform.Text;
                    db[ClientList.SelectedIndex].Name = EditInform.Text;
                    EditInform.Clear();
                    break;
                case 4:
                    MessageBox.Show($"Фамилия изменена!\nБыл {lSurname.Content}\nСтал {EditInform.Text}");
                    lSurname.Content = EditInform.Text;
                    db[ClientList.SelectedIndex].Surname = EditInform.Text;
                    EditInform.Clear();
                    break;
                case 5:
                    MessageBox.Show($"Номкер изменен!\nБыл {lNumber.Content}\nСтал {EditInform.Text}");
                    lNumber.Content = EditInform.Text;
                    db[ClientList.SelectedIndex].phoneNumber = EditInform.Text;
                    EditInform.Clear();
                    break;
            }
        }

        private void lPassport_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex == 1)
            {
                EditInform.Text = lPassport.Content.ToString();
                tempClick = 1;
            }
            else MessageBox.Show("Нет прав доступа!");
        }

        private void lMiddleName_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex == 1)
            {
                EditInform.Text = lMiddleName.Content.ToString();
                tempClick = 2;
            }
            else MessageBox.Show("Нет прав доступа!");
        }

        private void lName_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex == 1)
            {
                EditInform.Text = lName.Content.ToString();
                tempClick = 3;
            }
            else MessageBox.Show("Нет прав доступа!");
        }

        private void lSurname_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex == 1)
            {
                EditInform.Text = lSurname.Content.ToString();
                tempClick = 4;
            }
            else MessageBox.Show("Нет прав доступа!");
        }

        private void lNumber_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Worker.SelectedIndex >= 0)
            {
                EditInform.Text = lNumber.Content.ToString();
                tempClick = 5;
            }
        }
    }
}
