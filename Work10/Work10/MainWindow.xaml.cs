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

            if (WorkerCons.IsChecked == true) lPassport.Content = "***********";

        }

        private void SaveEdit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Номер изменен!\nБыл {lNumber.Content}\nСтал {EditInform.Text}");
            lNumber.Content = EditInform.Text;
            db[ClientList.SelectedIndex].phoneNumber = EditInform.Text;
            EditInform.Clear();
        }

        private void lNumber_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            EditInform.Text = lNumber.Content.ToString();
        }
    }
}
