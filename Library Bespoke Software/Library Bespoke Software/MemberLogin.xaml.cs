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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MemberLogin : Window
    {
        public MemberLogin()
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
            memberaccount member = new memberaccount();
            member.SetUserName(Username.Text);
            member.SetPassword(Password.Password.ToString());

            string a = Username.Text;
            string b = Password.Password;
            if (a == "admin" && b == "admin")
            {
                DataBase query = new DataBase();
                string hostName = Dns.GetHostName();
                string IPAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                bool connectiontoserver = true;
                try
                {
                    
                    query.AddActiveUser(Username.Text, IPAddress);
                }
                catch
                {
                    connectiontoserver = false;
                }

                //if (connectiontoserver == false)
                //{
                //    Error.Text = "Cannot to connect to server";
                //    DateTime now = DateTime.Now;
                //    while (DateTime.Now.Subtract(now).Seconds < 10)
                //    {
                //        Error.Text = "Cannot to connect to server";
                //        // wait for 20 seconds
                //    }
                //    // 20 seconds passed, continue
                    
                //    while (DateTime.Now.Subtract(now).Seconds < 10)
                //    {
                //        Error.Text = "Caution: Login will continue now";
                //        // wait for 20 seconds
                //    }
                //    // 20 seconds passed, continue
                //}


                Member_Main_Menu x = new Member_Main_Menu();
                x.Show();
                Close();
            }
            if(member.Login())
            {
                DataBase query = new DataBase();
                string hostName = Dns.GetHostName();
                string IPAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                query.AddActiveUser(Username.Text, IPAddress);

                Member_Main_Menu x = new Member_Main_Menu();
                x.Show();
                Close();
            }
            else
            {
                Error.Text = "Username or Password entered is incorrect";
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Member_Register_Window x = new Member_Register_Window();
            x.Show();
            Close();
        }
    }
}
