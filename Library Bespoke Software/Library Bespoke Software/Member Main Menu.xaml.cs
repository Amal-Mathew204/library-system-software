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
using System.IO;
using System.Security;
using Microsoft.Win32;

namespace Login_Interface
{
    /// <summary>
    /// Interaction logic for Member_Main_Menu.xaml
    /// </summary>
    public partial class Member_Main_Menu : Window
    {
        public Member_Main_Menu()
        {
            InitializeComponent();
        }

        private void Home_Selected(object sender, RoutedEventArgs e)
        {
            MenuFrame.Content = new Home_Menu();
        }
        private void BookSearch_Selected(object sender, RoutedEventArgs e)
        {
            MenuFrame.Content = new MemberBookMenu(); 
        }

    }
}
