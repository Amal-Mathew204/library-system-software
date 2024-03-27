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

namespace Login_Interface
{
    /// <summary>
    /// Interaction logic for Loan_Menu.xaml
    /// </summary>
    public partial class Loan_Menu : Page
    {
        public Loan_Menu()
        {
            InitializeComponent();
        }
        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new Books_Menu();
            }
        }

        private void AddLoan_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new AddBookLoan();
            }
        }
    }
}
