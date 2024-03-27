using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Login_Interface
{
    class Accounts
    {
        protected string Firstname, Surname, Password;
        protected DateTime DOB;

        public void SetFirstname(string n)
        {
            Firstname = n;
        }
        public void SetSurname(string n)
        {
            Surname = n;
        }
 

        public void SetPassword(string n)
        {
            Password = n;
        }
        public void SetDOB(DateTime n)
        {
            DOB = n;
        }
        public bool IsPasswordSecure()
        {
            bool x = true;
            int count = 0;
            string passRule = "[A-Z]";
            while (count != 2)
            {

                Regex password_checker = new Regex(passRule);
                if (password_checker.IsMatch(Password))
                {
                }
                else
                {
                    x = false;
                }
                passRule = "[a-z]";
                if (count == 1)
                {
                    passRule = "[0-9]";
                }

                count++;

            }
            if (Password.Length < 8)
            {
                x = false;
            }

            return x;

        }
        public virtual bool Login()
        {
            bool x = false;





            return x;
        }
        

        public virtual void UpdateAccount()
        {

        }


    }





    class memberaccount : Accounts
    {
        protected string Username, Email;
        public memberaccount() : base()
        {

        }
        public bool CheckUsername()
        {
            bool x = true;
            DataBase query = new DataBase();
            List<string> currentusernames = query.MemberUsernameQuery();
            foreach (var c in currentusernames)
            {
                if (c == Username)
                {
                    x = false;
                }
            }
            return x;
        }
        public virtual void SetUserName(string n)
        {
            Username = n;
        }
        public override bool Login()
        {
            bool x = false;
            DataBase query = new DataBase();
            string DatabasePassword = query.MemberLoginQuery(Username);
            if (Password == DatabasePassword)
            {
                x = true;
            }
            return x;
        }
        public bool SearchLogin()
        {
            bool x = false;
            DataBase query = new DataBase();

            List<string> MemberAccountDetails = query.MemberAccountDetails(Username);
            if (MemberAccountDetails.Count > 0)
            {
                x = true;
                SetPassword(MemberAccountDetails[0]);
                SetFirstname(MemberAccountDetails[1]);
                SetSurname(MemberAccountDetails[2]);
                SetDOB(Convert.ToDateTime(MemberAccountDetails[3]));
            }
            

            return x;
        }




        public void SetMemeberInfoINTODatabase()
        {
            DataBase query = new DataBase();
            query.InsertIntoMemberTable(Username, Password, Firstname, Surname, DOB);





        }
        public bool CheckAge()
        {
            bool x = false;
            int todaydate = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            int checkDOB = int.Parse(DOB.ToString("yyyyMMdd"));
            int y = (todaydate - checkDOB) / 10000;
            if (y > 12 || y < 200)
            {
                x = true;
            }

            return x;
        }

        public List<string> GetMemberDetails()
        {
            List<string> x = new List<string>();
            x.Add(Firstname);
            x.Add(Surname);
            x.Add(DOB.ToString("dd/MM/yyyy"));
            x.Add(Username);
            x.Add(Password);
            

            return x;

        }

        public override void UpdateAccount()
        {


            DataBase query = new DataBase();
            query.DeleteMember(Username);
            SetMemeberInfoINTODatabase();
            
        }
        
    }




    








    class staffaccount : Accounts
    {
        protected int StaffID;
        protected string StaffPosition;

        public staffaccount() : base()
        {

        }

        public override bool Login()
        {
            bool x = false;
            DataBase query = new DataBase();
            string DatabasePassword = query.StaffLoginQuery(StaffID);
            if (Password == DatabasePassword)
            {
                x = true;
            }
            return x;
        }
        public int CreateStaffID()
        {
            DataBase query = new DataBase();
            int x = query.CreateNewstaffID();





            return x;
        }
        public void SetStaffID(int n)
        {
            StaffID = n;
        }
        public int GetStaffID()
        {
            return StaffID;
        }

        public void SetStaffPosition(string n)
        {
            StaffPosition = n;
        }


        public void SetStaffInfoINTODatabase()
        {
            DataBase query = new DataBase();
            query.InsertIntoStaffTable(StaffID, Password, Firstname, Surname, DOB, StaffPosition);





        }


        public bool CheckAge()
        {
            bool x = false;
            int todaydate = int.Parse(DateTime.Today.ToString("yyyyMMdd"));
            int checkDOB = int.Parse(DOB.ToString("yyyyMMdd"));
            int y = (todaydate - checkDOB) / 10000;
            if (y > 12)
            {
                x = true;
            }


            return x;
        }

        public bool SearchLogin()
        {
            bool x = false;
            DataBase query = new DataBase();

            List<string> StaffAccountDetails = query.StaffAccountDetails(Convert.ToString(StaffID));
            if (StaffAccountDetails.Count > 0)
            {
                x = true;
                SetPassword(StaffAccountDetails[0]);
                SetFirstname(StaffAccountDetails[1]);
                SetSurname(StaffAccountDetails[2]);
                SetDOB(Convert.ToDateTime(StaffAccountDetails[3]));
                SetStaffPosition(StaffAccountDetails[4]);
            }


            return x;
        }
        public List<string> GetStaffDetails()
        {
            List<string> x = new List<string>();
            x.Add(Firstname);
            x.Add(Surname);
            x.Add(DOB.ToString("dd/MM/yyyy"));
            x.Add(Password);
            x.Add(StaffPosition);

            return x;

        }

        public override void UpdateAccount()
        {
            DataBase query = new DataBase();
            query.DeleteStaff(StaffID);
            SetStaffInfoINTODatabase();
        }
        


    }
}



