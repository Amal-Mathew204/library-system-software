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
using System.Collections.ObjectModel;

namespace Login_Interface
{
    /// <summary>
    /// Interaction logic for MemberBookMenu.xaml
    /// </summary>
    public partial class MemberBookMenu : Page

    {
        private ObservableCollection<Book> bookslist = new ObservableCollection<Book>();
        public MemberBookMenu()
        {
            InitializeComponent();
           

            DataBase query = new DataBase();
            bookslist = query.GetBooksFromDatabase();

            lstBooks.Visibility = Visibility.Visible;
            lstBooks.ItemsSource = bookslist;
        }

       

        private void txtBookToSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBookToSearch.Text == "")
            {
                txtBookToSearch.Text = "Search Book Title:";
                lstBooks.Visibility = Visibility.Hidden;
            }
            else
            {
                lstBooks.Visibility = Visibility.Visible;
                string search = txtBookToSearch.Text;
                string upper = search.ToUpper();
                string lower = search.ToLower();

                var bookFiltered = from Book in bookslist
                                   let title = Book.Title
                                   where
                                   title.StartsWith(lower)
                                   || title.StartsWith(upper)
                                   || title.Contains(search)
                                   select Book;
                lstBooks.ItemsSource = bookFiltered;

            }
        }








    }
}
