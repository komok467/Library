using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using WpfApp1.Context;
using WpfApp1.Models;

namespace WpfApp1.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для Views.xaml
    /// </summary>
    public partial class Views : Page
    {
       
        public Views()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dbViewData.ItemsSource = dbContext.db.Books.Where(item => item.Name.Contains(txbSearch.Text) ||
            item.Author.FirstName.Contains(txbSearch.Text) ||
            item.Publisher.Name.Contains(txbSearch.Text) ||
            item.Genre.Name.Contains(txbSearch.Text)).ToList();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SavePage());
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            Books selectedItem = (Books)dbViewData.SelectedItem;
            if (selectedItem == null)
                MessageBox.Show("Выбери что-нибудь!");
            else
               NavigationService.Navigate(new EditPage(selectedItem));
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {

            Books book = (Books)dbViewData.SelectedItem;
            if (book != null)
            {
                if (MessageBox.Show("Вы хотите удалить эти данные ?", "Удалить?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    var selectedRemove = dbContext.db.Books.FirstOrDefault(item => item.ID == book.ID);
                    dbContext.db.Books.Remove(book);
                    dbContext.db.SaveChanges();
                    Page_Loaded(null, null);
                }
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)

        {
            dbViewData.ItemsSource = dbContext.db.Books.ToList();
        }
    }
}
