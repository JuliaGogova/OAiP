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

namespace _1406
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] login = new string[3] { "Prodavec", "StProdavec", "Admin" };
            string[] password = new string[3] { "Prodavec", "StProdavec", "Admin" };

            if (LogginBox.Text.Equals(login[0]) & PasswordBox.Password.Equals(password[0]))
            {
                MessageBox.Show("Вы зашли за продовца");
                Prodawec winprodawec = new Prodawec();
                winprodawec.Show();
                Close();
            }
            else if (LogginBox.Text.Equals(login[1]) & PasswordBox.Password.Equals(password[1]))
            {
                MessageBox.Show("Вы зашли за сменного");
                Smena winsmena = new Smena();
                winsmena.Show();
                Close();
            }
            else if (LogginBox.Text.Equals(login[2]) & PasswordBox.Password.Equals(password[2]))
            {
                MessageBox.Show("Вы зашли за Администратора");
                Admin winAdmin = new Admin();
                winAdmin.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Введены неправвильные данные");
            }
        }
    }
}
