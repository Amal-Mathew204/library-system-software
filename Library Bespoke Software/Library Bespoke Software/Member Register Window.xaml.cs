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
    /// Interaction logic for Member_Register_Window.xaml
    /// </summary>
    public partial class Member_Register_Window : Window
    {
        public string Firstname1, Surname1, Username1, Password1;
        public DateTime DOB1;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                DOB1 = Convert.ToDateTime(DOB.Text);
                Username1 = Username.Text;
                Firstname1 = FirstName.Text;
                Surname1 = Surname.Text;
                Password1 = Password.Text;

                

               
               
               
                
                    memberaccount member = new memberaccount();
                    member.SetUserName(Username1);
                    member.SetPassword(Password1);
                  
                    member.SetDOB(DOB1);
                    member.SetFirstname(Firstname1);
                    member.SetSurname(Surname1);
                    bool usernamecheck = member.CheckUsername();
                bool checkage = member.CheckAge();
                if (checkage==true)
                {
                    if (usernamecheck == true)
                    {
                        if (member.IsPasswordSecure())
                        {
                            DataBase query = new DataBase();
                            string hostName = Dns.GetHostName();
                            string IPAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                            query.AddActiveUser(Username.Text, IPAddress);

                            Member_Main_Menu x = new Member_Main_Menu();
                            member.SetMemeberInfoINTODatabase();
                            x.Show();
                            Close();
                        }
                        else
                        {
                            Error.Text = "Password must have 8 CharLength with Number/Upper/Lowercase Letters";
                            Password.Foreground = Brushes.Red;
                        }
                    }
                    else
                    {
                        Error.Text = "The Username Entered is Taken";
                        Username.Foreground = Brushes.Red;
                    }

                }
                else
                {
                    Error.Text = "You Must be older than 12 to Register";
                    DOB.Foreground = Brushes.Red;
                }
                
            }
            catch (FormatException)
            {
                Error.Text = "Type DateofBirth in format DD/MM/YYYY";
                DOB.Foreground = Brushes.Red;
            }


            
        }
        
        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        public Member_Register_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             MemberLogin x = new MemberLogin();
            x.Show();
            Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
