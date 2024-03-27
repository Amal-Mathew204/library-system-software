using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Login_Interface
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string BookDescription { get; set; }
        public string Reviews { get; set; }
        public int ISBN { get; set; }



        public void AddBook()
        {
            DataBase query = new DataBase("Book Database");
            query.AddBookINTODatabase(ISBN, Title, Author, BookDescription, Reviews);
        }
        public bool checkuniqueISBN()
        {
            bool x = false;

            DataBase query = new DataBase();
            x = query.CheckISBNnumber(ISBN);


            return x;

        }

       

    }
}
