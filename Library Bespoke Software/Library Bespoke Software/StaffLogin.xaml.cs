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
using System.Net;
namespace Login_Interface
{
    /// <summary>
    /// Interaction logic for StaffLogin.xaml
    /// </summary>
    public partial class StaffLogin : Window
    {
        
        public StaffLogin()
        {
            InitializeComponent();
            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            
     
            
            string a = Username.Text;
            string b = Password.Password;
            bool CheckStaffIDInput = int.TryParse(a, out int number);
            if (a == "admin" && b == "admin")
            {



                // LibrarySoftwareUserServerClient client = new LibrarySoftwareUserServerClient(Username.Text);

                //DataBase query = new DataBase();
                //string hostName = Dns.GetHostName();
                //string IPAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();


                //query.AddActiveUser(Username.Text, IPAddress);

                Staff_Main_Menu x = new Staff_Main_Menu();
                x.Show();
                Close();
            }
            if(CheckStaffIDInput)
            {
                staffaccount staff = new staffaccount();
                staff.SetStaffID(int.Parse(Username.Text));
                staff.SetPassword(Password.Password.ToString());
                if (staff.Login())
                {
                    DataBase query = new DataBase();
                    string hostName = Dns.GetHostName();
                    string IPAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    query.AddActiveUser(Username.Text, IPAddress);

                    Staff_Main_Menu x = new Staff_Main_Menu();
                    x.Show();
                    //LibrarySoftwareUserServerClient client = new LibrarySoftwareUserServerClient(Username.Text);
                    Close();
                }
                else
                {
                    Error.Text = "Username or Password entered is incorrect";
                }
            }
            
            else
            {
                
                Error.Text = "Username or Password entered is incorrect";
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Staff_Register_Window x = new Staff_Register_Window();
            x.Show();
            Close();
        }
    }


}

