using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
namespace Login_Interface
{
    class DataBase

    {
        protected const String DB_IP = "10.207.71.1,1433"; //IPv4 
        //protected const String DB_IP = "192.168.0.147,1433"; //IPv4 

        protected SqlConnection conn;

        public DataBase()
        {
            // Connecting to SQL Constructor
            var datasource = $@"{DB_IP}\SQLEXPRESS;Network Library=DBMSSOCN";// server

            var database = "LibraryBespokeSoftware"; // database name
            var username = "sa"; //username 
            var password = "arman"; //password

            // connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //create instanace of database connection
            conn = new SqlConnection(connString);


            try
            {

                //open connection
                conn.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        public DataBase(string database)
        {
            // Connecting to SQL Constructor
            var datasource = $@"{DB_IP}\SQLEXPRESS;Network Library=DBMSSOCN";// server



            database = "LibraryBespokeSoftware";


            var username = "sa"; //username 
            var password = "arman"; //password

            // connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //create instanace of database connection
            conn = new SqlConnection(connString);


            try
            {

                //open connection
                conn.Open();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        public string StaffLoginQuery(int n)
        {
            string x = "";
            try
            {

                string query = $@"SELECT Password FROM Staff WHERE StaffID ={n}";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    x += rdr[0];
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }





            return x;
        }
        public string MemberLoginQuery(string n)
        {
            string x = "";
            try
            {

                string query = $@"SELECT Password FROM Member WHERE Username ='{n}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    x += rdr[0];
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }





            return x;
        }

        public List<string> MemberUsernameQuery()
        {
            List<string> x = new List<string>();
            try
            {

                string query = $@"SELECT Username FROM Member";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    x.Add(Convert.ToString(rdr[0]));
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }





            return x;
        }


        public void InsertIntoMemberTable(string n, string m, string o, string p, DateTime r)
        {
            string formatForSql = r.ToString("yyyy-MM-dd");
            string query = $@"INSERT INTO Member VALUES ( '{n}', '{m}', '{o}', '{p}','{formatForSql}', '')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();



        }



        public void InsertIntoStaffTable(int n, string m, string o, string p, DateTime r, string s)
        {
            string formatForSql = r.ToString("yyyy-MM-dd");
            string query = $@"INSERT INTO Staff VALUES ( {n}, '{m}', '{o}', '{p}','{formatForSql}', '{s}' )";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

        }



        public int CreateNewstaffID()
        {
            int y;
            List<int> x = new List<int>();
            try
            {

                string query = $@"SELECT StaffID FROM Staff";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    x.Add(Convert.ToInt32(rdr[0]));
                }
                rdr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            int xLength = x.Count - 1;
            y = x[xLength] + 1;


            return y;




        }
        public List<List<string>> DisplayMemberTable()
        {

            List<List<string>> MemberTable = new List<List<string>>();
            try
            {




                string query = "SELECT Username, Password, Firstname, Surname, DateOfBirth FROM Member";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();




                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string Username = dr.GetString(0);
                        string Password = dr.GetString(1);
                        string Firstname = dr.GetString(2);
                        string Surname = dr.GetString(3);
                        DateTime DOB = dr.GetDateTime(4);

                        //display retrieved record
                        //Console.WriteLine("{0},{1},{2},{3},{4}", Username, Password, Firstname, Surname, DOB.ToString());



                        List<string> DataCells = new List<string>();
                        DataCells.Add(Username);
                        DataCells.Add(Password);
                        DataCells.Add(Firstname);
                        DataCells.Add(Surname);
                        DataCells.Add(DOB.ToString("MM/dd/yyyy"));

                        MemberTable.Add(DataCells);



                    }
                }
                else
                {

                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


            return MemberTable;




        }

        public List<List<string>> DisplayStaffTable()
        {

            List<List<string>> StaffTable = new List<List<string>>();
            try
            {




                string query = "SELECT StaffID, Password, Firstname, Surname, DateOfBirth, Occupation FROM Staff";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();



                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int StaffID = dr.GetInt32(0);
                        string Password = dr.GetString(1);
                        string Firstname = dr.GetString(2);
                        string Surname = dr.GetString(3);
                        DateTime DOB = dr.GetDateTime(4);
                        string Occupation = dr.GetString(5);





                        List<string> DataCells = new List<string>();
                        DataCells.Add(Convert.ToString(StaffID));
                        DataCells.Add(Password);
                        DataCells.Add(Firstname);
                        DataCells.Add(Surname);
                        DataCells.Add(DOB.ToString("MM/dd/yyyy"));
                        DataCells.Add(Occupation);



                        StaffTable.Add(DataCells);



                    }
                }
                else
                {
                    // Console.WriteLine("No data found.");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


            return StaffTable;




        }




        public List<string> StaffAccountDetails(string n)
        {
            List<string> x = new List<string>();
            try
            {

                string query = $@"SELECT Password, Firstname, Surname, DateOfBirth, Occupation FROM Staff WHERE StaffID ={n}";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    x.Add(Convert.ToString(rdr[0]));
                    x.Add(Convert.ToString(rdr[1]));
                    x.Add(Convert.ToString(rdr[2]));
                    DateTime DOB = new DateTime();
                    DOB = Convert.ToDateTime(rdr[3]);
                    x.Add(Convert.ToString(DOB.ToString("dd/MM/yyyy")));
                    x.Add(Convert.ToString(rdr[4]));
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return x;
        }

        public List<string> MemberAccountDetails(string n)
        {
            List<string> x = new List<string>();
            try
            {

                string query = $@"SELECT Password, Firstname, Surname, DateOfBirth FROM Member WHERE Username ={n}";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    x.Add(Convert.ToString(rdr[0]));
                    x.Add(Convert.ToString(rdr[1]));
                    x.Add(Convert.ToString(rdr[2]));
                    DateTime DOB = new DateTime();
                    DOB = Convert.ToDateTime(rdr[3]);
                    x.Add(Convert.ToString(DOB.ToString("dd/MM/yyyy")));
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return x;
        }

        public void UpdateStaffAccount(int x)
        {

        }
        public void UpdateMemberAccount(string x)
        {

        }

        public bool CheckISBNnumber(int m)
        {
            bool y = true;
            List<int> ISBNs = new List<int>();
            string x = "";
            try
            {

                string query = $@"SELECT ISBN FROM BOOK";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    ISBNs.Add(Convert.ToInt32(rdr[0]));
                }
                rdr.Close();

                foreach (var c in ISBNs)
                {
                    if (c == m)
                    {
                        y = false;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }





            return y;


        }

        public void AddBookINTODatabase(int n, string m, string o, string p, string s)
        {
            string query = $@"INSERT INTO BOOK VALUES ( {n}, '{m}', '{o}', '{p}','{s}', '', '' )";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public void AddActiveUser(string n, string m)
        {
            string query = $@"INSERT INTO ActiveClients VALUES ( '{n}', '{m}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        public void DeleteStaff(int staffID)
        {
            string query = $@"DELETE FROM Staff WHERE StaffID = {staffID}";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        public void DeleteMember(string username)
        {
            string query = $@"DELETE FROM Member WHERE Username = '{username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        public ObservableCollection<Book> GetBooksFromDatabase()
        {

            ObservableCollection<Book> books = new ObservableCollection<Book>();

            {

                string query = $@"SELECT ISBN, Title, Author, Description, Reviews FROM BOOK ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int ISBN = dr.GetInt32(0);
                        string Title = dr.GetString(1);
                        string Author = dr.GetString(2);
                        string Description = dr.GetString(3);
                        string Reviews = dr.GetString(4);

                        books.Add(new Book() { ISBN = ISBN, Title = Title, Author = Author, BookDescription = Description, Reviews = Reviews});






                    }
                }
                else
                {
                    // Console.WriteLine("No data found.");
                }



                return books;

            }

        }







    }

}
