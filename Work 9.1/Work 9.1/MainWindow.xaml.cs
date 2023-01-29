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

namespace Work_9._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnShare_Click(object sender, RoutedEventArgs e)
        {
            ListBox.Items.Clear();
            string[] Proposal;
            Proposal = TextBox.Text.Split(' ');

            for (int i = Proposal.Length; i != 0; i--)
            {
                ListBox.Items.Add(Proposal[i-1]);
            }
        }

        private void BtnOut_Click(object sender, RoutedEventArgs e)
        {
            string[] Proposal;
            Label1.Content = string.Empty;
            Proposal = TextBox2.Text.Split(' ');

            for (int i = Proposal.Length; i != 0; i--)
            {
                Label1.Content += Proposal[i - 1] + " ";
            }
        }
    }
}
