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
    /// Interaction logic for ViewAccountMenu.xaml
    /// </summary>
    public partial class ViewAccountMenu : Page
    {
        public ViewAccountMenu()
        {
            InitializeComponent();
            ViewAccountTableFrame.Content = new StaffTablePage();
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new Accounts_Menu();
            }
        }

        private void View_Member_Accounts_Click(object sender, RoutedEventArgs e)
        {
            ViewAccountTableFrame.Content = new MemberTablePage();
            
        }

        private void View_Staff_Accounts_Click(object sender, RoutedEventArgs e)
        {
            ViewAccountTableFrame.Content = new StaffTablePage();

        }

    }
}
