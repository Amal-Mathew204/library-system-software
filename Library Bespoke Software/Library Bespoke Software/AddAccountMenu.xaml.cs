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
    /// Interaction logic for AddAccountMenu.xaml
    /// </summary>
    public partial class AddAccountMenu : Page
    {
        public string Firstname, Surname, Username, Position, Password;
        public int StaffID;
        public DateTime DOB;
        public AddAccountMenu()
        {
            InitializeComponent();
            MemberAccountInfo.Width = 0;
            StaffAccountInfo.Width = 0;
        }
        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new Accounts_Menu();
            }
        }

        private void Staff_Account_Click(object sender, RoutedEventArgs e)
        {
            MemberAccountInfo.Width = 0;
            StaffAccountInfo.Width = 425;
            MemberAccountInfo.Margin = new Thickness(600, 100, 0, 0);
            StaffAccountInfo.Margin = new Thickness(310, 100, 0, 0);
        }

        private void Member_Account_Click(object sender, RoutedEventArgs e)
        {
            MemberAccountInfo.Width = 425;
            StaffAccountInfo.Width = 0;

            MemberAccountInfo.Margin = new Thickness(310, 100, 0, 0);
            StaffAccountInfo.Margin = new Thickness(600, 100, 0, 0);
        }

        private void StaffAddAccount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DOB = Convert.ToDateTime(StaffDOB.Text);
                Password = StaffPassword.Text;
                Firstname = StaffFirstName.Text;
                Surname = StaffSurname.Text;
                Position = StaffPosition.Text;



                staffaccount staff = new staffaccount();
                Staff_Main_Menu x = new Staff_Main_Menu();

                staff.SetPassword(Password);
                staff.SetDOB(DOB);
                staff.SetFirstname(Firstname);
                staff.SetSurname(Surname);
                staff.SetStaffID(staff.CreateStaffID());
                staff.SetStaffPosition(Position);
                bool checkage = staff.CheckAge();
                if (checkage == true)
                {
                    if (staff.IsPasswordSecure())
                    {
                        staff.SetStaffInfoINTODatabase();
                        Delay();
                    }
                    else
                    {
                        StaffError.Text = "Password must have 8 CharLength with Number/Upper/Lowercase Letters";
                        StaffPassword.Foreground = Brushes.Red;
                    }
                }
                else
                {
                    StaffError.Text = "You Must be older than 12 to Register";
                    StaffDOB.Foreground = Brushes.Red;
                }



            }
            catch (FormatException)
            {
                StaffError.Text = "Type DateofBirth in format DD/MM/YYYY";
                StaffDOB.Foreground = Brushes.Red;
            }
            
        }

       

        private void MemberAddAccount_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {


                Username = MemberUsername.Text;
                Password = MemberPassword.Text;
                Firstname = MemberFirstName.Text;
                Surname = MemberSurname.Text;
                DOB = Convert.ToDateTime(MemberDOB.Text);

                memberaccount member = new memberaccount();
                member.SetUserName(Username);
                member.SetPassword(Password);

                member.SetDOB(DOB);
                member.SetFirstname(Firstname);
                member.SetSurname(Surname);
                bool usernamecheck = member.CheckUsername();
                bool checkage = member.CheckAge();

                if (checkage == true)
                {
                    if (usernamecheck == true)
                    {
                        if (member.IsPasswordSecure())
                        {

                            member.SetMemeberInfoINTODatabase();
                            Delay();
                        }
                        else
                        {
                            MemberError.Text = "Password must have 8 CharLength with Number/Upper/Lowercase Letters";
                            MemberPassword.Foreground = Brushes.Red;
                        }
                    }
                    else
                    {
                        MemberError.Text = "The Username Entered is Taken";
                        MemberUsername.Foreground = Brushes.Red;
                    }

                }
                else
                {
                    MemberError.Text = "You Must be older than 12 to Register";
                    MemberDOB.Foreground = Brushes.Red;
                }



            }
            catch (FormatException)
            {
                MemberError.Text = "Type DateofBirth in format DD/MM/YYYY";
                MemberDOB.Foreground = Brushes.Red;
            }

        }
        private async void Delay()
        {
            
            await DelayTime();
        }
        private async Task DelayTime()
        {
            AccountAddedMessage x = new AccountAddedMessage();
            x.Show();
            await Task.Delay(5000);

            ResetMenu();
            x.Close();
        }

        private void ResetMenu()
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new AddAccountMenu();
            }
        }
    }
}
