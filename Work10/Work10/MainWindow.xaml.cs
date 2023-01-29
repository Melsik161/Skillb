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
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = 0;
            string line;
            string[] tempLin;
            using (StreamReader sr = new StreamReader("Clients.txt"))
            { 

                while ((line = sr.ReadLine()) != null)
                {

                    tempLin = line.Split('#');
                    if (line == "") continue; // Если есть пустая строка в файле, то + итерация.
                    db.Add(new Clients(++id, tempLin[1], tempLin[2], tempLin[3], tempLin[4]));

                }
                
            }
            
            ClientList.ItemsSource = db;
        }
    }
}
