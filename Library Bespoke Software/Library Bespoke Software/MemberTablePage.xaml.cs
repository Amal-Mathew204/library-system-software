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
using System.Data.SqlClient;

namespace Login_Interface
{
    /// <summary>
    /// Interaction logic for MemberTablePage.xaml
    /// </summary>
    public partial class MemberTablePage : Page
    {
        public MemberTablePage()
        {
            InitializeComponent();


            DataBase query = new DataBase();

            List<List<string>> DataRows = new List<List<string>>();
            DataRows = query.DisplayMemberTable();


            //var datasource = @"DELL_G7\SQLEXPRESS;";//your server

            //var database = "Login Database"; //your database name
            //var username = "sa"; //username of server to connect
            //var password = "arman"; //password

            ////your connection string 
            //string connString = @"Data Source=" + datasource + ";Initial Catalog="
            //            + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;



            ////create instanace of database connection
            //SqlConnection conn = new SqlConnection(connString);

            //List<List<string>> MemberTable = new List<List<string>>();
            //try
            //{


            //    //open connection
            //    conn.Open();

            //    string query = "SELECT Username, Password, Firstname, Lastname, DateOFBirth FROM Member";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    SqlDataReader dr = cmd.ExecuteReader();




            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            string Username = dr.GetString(0);
            //            string Password = dr.GetString(1);
            //            string Firstname = dr.GetString(2);
            //            string Surname = dr.GetString(3);
            //            DateTime DOB = dr.GetDateTime(4);

            //            //display retrieved record
            //            //Console.WriteLine("{0},{1},{2},{3},{4}", Username, Password, Firstname, Surname, DOB.ToString());



            //            List<string> DataCells = new List<string>();
            //            DataCells.Add(Username);
            //            DataCells.Add(Password);
            //            DataCells.Add(Firstname);
            //            DataCells.Add(Surname);
            //            DataCells.Add(DOB.ToString("MM/dd/yyyy"));

            //            MemberTable.Add(DataCells);



            //        }
            //    }
            //    else
            //    {
            //        // Console.WriteLine("No data found.");
            //    }


            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}


            //DataRows = MemberTable;






            foreach (var c in DataRows)
            {
                TableRow row = new TableRow();


                foreach (var d in c)
                {

                    TableCell cell = new TableCell();
                    cell.Blocks.Add(new Paragraph(new Run(d)));
                    row.Cells.Add(cell);
                }

                MemberDataRowGroup.Rows.Add(row);


            }
        }

        
    }
}
