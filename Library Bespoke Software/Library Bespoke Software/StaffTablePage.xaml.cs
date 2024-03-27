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
    /// Interaction logic for StaffTablePage.xaml
    /// </summary>
    public partial class StaffTablePage : Page
    {
        public StaffTablePage()
        {
            InitializeComponent();







            DataBase query = new DataBase();

            List<List<string>> DataRows = new List<List<string>>();
            DataRows = query.DisplayStaffTable();


            //var datasource = @"DELL_G7\SQLEXPRESS;";//your server

            //var database = "Login Database"; //your database name
            //var username = "sa"; //username of server to connect
            //var password = "arman"; //password

            ////your connection string 
            //string connString = @"Data Source=" + datasource + ";Initial Catalog="
            //            + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;



            ////create instanace of database connection
            //SqlConnection conn = new SqlConnection(connString);

            //List<List<string>> StaffTable = new List<List<string>>();
            //try
            //{


            //    //open connection
            //    conn.Open();

            //    string query = "SELECT StaffID, Password, Firstname, LastName, DateOFBirth, OccupationRole FROM Staff";
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    SqlDataReader dr = cmd.ExecuteReader();




            //    if (dr.HasRows)
            //    {
            //        while (dr.Read())
            //        {
            //            int StaffID = dr.GetInt32(0);
            //            string Password = dr.GetString(1);
            //            string Firstname = dr.GetString(2);
            //            string Surname = dr.GetString(3);
            //            DateTime DOB = dr.GetDateTime(4);
            //            string Occupation = dr.GetString(5);

                        



            //            List<string> DataCells = new List<string>();
            //            DataCells.Add(Convert.ToString(StaffID));
            //            DataCells.Add(Password);
            //            DataCells.Add(Firstname);
            //            DataCells.Add(Surname);
            //            DataCells.Add(DOB.ToString("MM/dd/yyyy"));
            //            DataCells.Add(Occupation);



            //            StaffTable.Add(DataCells);



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


           





            foreach (var c in DataRows)
            {
                TableRow row = new TableRow();


                foreach (var d in c)
                {

                    TableCell cell = new TableCell();
                    cell.Blocks.Add(new Paragraph(new Run(d)));
                    row.Cells.Add(cell);
                }

                StaffDataRowGroup.Rows.Add(row);

            }



        }





     


    }
}
