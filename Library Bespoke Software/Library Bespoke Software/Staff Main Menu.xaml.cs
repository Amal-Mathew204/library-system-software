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
using System.Windows.Shapes;

namespace Login_Interface
{
    /// <summary>
    /// Interaction logic for Staff_Main_Menu.xaml
    /// </summary>
    public partial class Staff_Main_Menu : Window
    {
        public Staff_Main_Menu()
        {
            InitializeComponent();


            

        }

        private void Home_Selected(object sender, RoutedEventArgs e)
        {
            MenuFrame.Content = new Home_Menu();
        }

        private void Books_Selected(object sender, RoutedEventArgs e)
        {
            MenuFrame.Content = new Books_Menu();
        }

        private void Accounts_Selected(object sender, RoutedEventArgs e)
        {
            MenuFrame.Content = new Accounts_Menu();
        }
        private void Email_Selected(object sender, RoutedEventArgs e)
        {
            MenuFrame.Content = new Email_Menu();
        }

        

        private void Settings_Selected(object sender, RoutedEventArgs e)
        {
            MenuFrame.Content = new Settings_Menu();
        }

     

        private void Loan_Selected(object sender, RoutedEventArgs e)
        {
            MenuFrame.Content = new Loan_Menu();
        }
    }
}
