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
    /// Interaction logic for EditAccountMenu.xaml
    /// </summary>
    public partial class EditAccountMenu : Page
    {
        public string Firstname, Surname, Username, Position, Password;
        public int StaffID;
        public DateTime DOB;
        
        public EditAccountMenu()
        {
            InitializeComponent();
            StaffSearch.Height = 0;
            MemberSearch.Height = 0;
            StaffAccountInfo.Visibility = Visibility.Hidden;
            MemberAccountInfo.Visibility = Visibility.Hidden;

        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new Accounts_Menu();
            }
        }

        private void SearchStaffID_Click(object sender, RoutedEventArgs e)
        {
            staffaccount staff = new staffaccount();
            StaffID = Convert.ToInt32(SearchStaffIDTextbox.Text);
            staff.SetStaffID(StaffID);
            if (staff.SearchLogin())
            {
                StaffAccountInfo.Visibility = Visibility.Visible;
                MemberAccountInfo.Visibility = Visibility.Hidden;

                List<string> staffdetails = staff.GetStaffDetails();
                StaffFirstName.Text = staffdetails[0];
                StaffSurname.Text = staffdetails[1];
                StaffDOB.Text = staffdetails[2];
                StaffPassword.Text = staffdetails[3];
                StaffPosition.Text = staffdetails[4];
                StaffID = Convert.ToInt32(SearchStaffIDTextbox.Text);
            }
            else
            {
                StaffSearchError.Text = "The Staff account entered could not be found";
            }
            


        }

        private void SearchUsername_Click(object sender, RoutedEventArgs e)
        {
            memberaccount member = new memberaccount();
            Username = SearchUsernameTextbox.Text;
            member.SetUserName(Username);
            if (member.SearchLogin())
            {
                StaffAccountInfo.Visibility = Visibility.Hidden;
                MemberAccountInfo.Visibility = Visibility.Visible;

                List<string> memberdetails = member.GetMemberDetails();
                MemberFirstName.Text = memberdetails[0];
                MemberSurname.Text = memberdetails[1];
                MemberDOB.Text = memberdetails[2];
                MemberUsername.Text = memberdetails[3];
                MemberPassword.Text = memberdetails[4];
            }
            else
            {
                MemberSearchError.Text = "The Member account entered could not be found";
            }

            

        }

        private void Member_Account_Click(object sender, RoutedEventArgs e)
        {
            StaffSearch.Height = 0;
            MemberSearch.Height = 400;
            StaffAccountInfo.Visibility = Visibility.Hidden;
            MemberAccountInfo.Visibility = Visibility.Hidden;
        }

        private void Staff_Account_Click(object sender, RoutedEventArgs e)
        {
            StaffSearch.Height = 400;
            MemberSearch.Height = 0 ;
            StaffAccountInfo.Visibility = Visibility.Hidden;
            MemberAccountInfo.Visibility = Visibility.Hidden;
        }

        
        private void MemberEditAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StaffEditAccount_Click(object sender, RoutedEventArgs e)
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

                staff.SetStaffID(StaffID);
                staff.SetPassword(Password);
                staff.SetDOB(DOB);
                staff.SetFirstname(Firstname);
                staff.SetSurname(Surname);
                staff.SetStaffPosition(Position);
                bool checkage = staff.CheckAge();
                if (checkage == true)
                {
                    if (staff.IsPasswordSecure())
                    {
                        staff.UpdateAccount();

                        





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
    }
}
