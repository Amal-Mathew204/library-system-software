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
using Microsoft.Win32;

namespace Login_Interface
{
    /// <summary>
    /// Interaction logic for AddBookMenu.xaml
    /// </summary>
    public partial class AddBookMenu : Page
    {
       
        public string selelctedFilename;
        public AddBookMenu()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Staff_Main_Menu staff_Main_Menu = Application.Current.Windows.OfType<Staff_Main_Menu>().FirstOrDefault();
            if (staff_Main_Menu != null)
            {
                staff_Main_Menu.MenuFrame.Content = new Books_Menu();
            }

        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
              selelctedFilename = openFileDialog.FileName;

                BookCover.Source = new BitmapImage(new Uri(selelctedFilename));
            }
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Book book = new Book();
                book.ISBN = Convert.ToInt32(ISBN.Text);
                book.Title = Title.Text;
                book.Author = Author.Text;
                book.BookDescription = BookDescription.Text;
                book.Reviews = Reviews.Text;

                if (book.checkuniqueISBN())
                {
                    AddBookCoverClient bookCoverClient = new AddBookCoverClient();
                    bool server = bookCoverClient.AddBookCover(selelctedFilename, Title.Text);
                    if (server)
                    {
                        book.AddBook();
                        ErrorMessage.Foreground = Brushes.White;
                        ErrorMessage.Text = "Book Added Sucessfully";
                    }
                    else
                    {
                        ErrorMessage.Foreground = Brushes.Red;
                        ErrorMessage.Text = "Server failed to save book cover";
                    }
                    
                }
                else
                {
                    ErrorMessage.Foreground = Brushes.Red;
                    ErrorMessage.Text = "ISBN number already in the Database";
                }


            }
            catch (Exception ex)
            {
                ErrorMessage.Foreground = Brushes.Red;
                ErrorMessage.Text = "ISBN number requires and integer input";
            }
        }
    }
}
