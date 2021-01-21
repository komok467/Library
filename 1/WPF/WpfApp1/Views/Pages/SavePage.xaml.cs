using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using WpfApp1.Context;
using WpfApp1.Models;

namespace WpfApp1.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для SavePage.xaml
    /// </summary>
    public partial class SavePage : Page
    {
        public SavePage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views());
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Book newBook = new Book();
                newBook.Name = txbName.Text;
                newBook.CountPage = int.Parse(txbPage.Text);
                newBook.Price = Convert.ToDecimal(txbPrice.Text);

                var currentAuthor = dbContext.db.Author.FirstOrDefault(item => item.FirstName == cmbFirstName.Text);
                var currentPublisher = dbContext.db.Publisher.FirstOrDefault(item => item.Name == cmbPublisher.Text);
                var curretGenre = dbContext.db.Genre.FirstOrDefault(item => item.Name == cmbGenre.Text);

                newBook.IDAuthor = currentAuthor.ID;
                newBook.IDPublisher = currentPublisher.ID;
                newBook.IDGenre = currentPublisher.ID;

                dbContext.db.Book.Add(newBook);
                    
                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encorder = new JpegBitmapEncoder();
                encorder.Frames.Add(BitmapFrame.Create((BitmapImage)Picture.Source));
                encorder.Save(stream);
                newBook.Picture = stream.ToArray();
                
                dbContext.db.SaveChanges();

                MessageBox.Show("Данные сохранены");
                NavigationService.GoBack();
            }
            catch (Exception newException)
            {
                MessageBox.Show(newException.Message, newException.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }

           
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            cmbGenre.ItemsSource = dbContext.db.Genre.Select(item => item.Name).ToList();
            cmbPublisher.ItemsSource = dbContext.db.Publisher.Select(item => item.Name).ToList();
            cmbFirstName.ItemsSource = dbContext.db.Author.Select(item => item.FirstName).ToList();
        }

        private void btnLoadImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "image(*.jpg; *.png;)| *.jpg; *.png;";
            if (file.ShowDialog() == true)
            {
                BitmapImage image = new BitmapImage(new Uri(file.FileName));
                Picture.Source = image;
            }
        }
    }
}
