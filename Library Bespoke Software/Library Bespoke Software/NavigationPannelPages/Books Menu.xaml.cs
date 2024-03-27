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
    /// Interaction logic for Books_Menu.xaml
    /// </summary>
    public partial class Books_Menu : Page
    {
        public Books_Menu()
        {
            InitializeComponent();
        }

        private void ViewBook_button_Click(object sender, RoutedEventArgs e)
        {

            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if(staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new ViewBookMenu();
            }
        }

        private void AddBook_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new AddBookMenu();
            }
        }

        private void DeleteBook_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new DeleteBookMenu();
            }
        }

        private void EditBook_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new EditBookMenu();
            }
        }
    }
}
