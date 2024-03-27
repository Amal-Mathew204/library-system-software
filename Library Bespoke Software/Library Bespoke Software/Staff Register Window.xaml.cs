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
    /// Interaction logic for Staff_Register_Window.xaml
    /// </summary>
    public partial class Staff_Register_Window : Window
        
    {
        public string Firstname1, Surname1, Position1, Password1;
        public DateTime DOB1;

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        

        public Staff_Register_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
       
            StaffLogin x = new StaffLogin();
            x.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                DOB1 = Convert.ToDateTime(DOB.Text);
                Password1 = Password.Text;
                Firstname1 = FirstName.Text;
                Surname1 = Surname.Text;
                Position1 = StaffPosition.Text;

                
                
                    staffaccount staff = new staffaccount();
                    Staff_Main_Menu x = new Staff_Main_Menu();
 
                    staff.SetPassword(Password1);
                    staff.SetDOB(DOB1);
                    staff.SetFirstname(Firstname1);
                    staff.SetSurname(Surname1);
                    staff.SetStaffID(staff.CreateStaffID());
                    staff.SetStaffPosition(Position1);
                DateTime DOBLB = Convert.ToDateTime("01/01/2009");
                if (DOB1<DOBLB)
                {
                    if (staff.IsPasswordSecure())
                    {
                        DataBase query = new DataBase();
                        string hostName = Dns.GetHostName();
                        string IPAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
                        query.AddActiveUser(Convert.ToString(staff.GetStaffID()), IPAddress);

                        Staff_Main_Menu y = new Staff_Main_Menu();
                        staff.SetStaffInfoINTODatabase();
                        y.Show();
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


    }
}
