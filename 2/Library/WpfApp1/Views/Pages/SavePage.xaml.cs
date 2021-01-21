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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Views());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)

        {
            try
            {
                Books book = new Books();

                book.Name = txbName.Text;
                book.CountPage = int.Parse(txbCountPage.Text);
                book.Price = int.Parse(txbPrice.Text);


                var currentauthor = dbContext.db.Author.FirstOrDefault(item => item.FirstName == cmbFirstName.Text);
                book.IDAuthor = currentauthor.ID;
                var currentPublisher = dbContext.db.Publisher.FirstOrDefault(item => item.Name == cmbPublisher.Text);
                book.IDPublisher = currentPublisher.ID;
                var currentGenre = dbContext.db.Genre.FirstOrDefault(item => item.Name == cmbGenre.Text);
                book.IDGenre = currentGenre.ID;

                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)Picture.Source));
                encoder.Save(stream);
                book.Picture = stream.ToArray();

                dbContext.db.Books.Add(book);
                dbContext.db.SaveChanges();

                MessageBox.Show("Данные сохранились!");
                NavigationService.GoBack();
            }
            catch (Exception newException)
            {
                MessageBox.Show(newException.Message);

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
            file.Filter = "Kamilla image (*.png; *.jpg; *.gif) | *.png; *.jpg; *.gif;";
            if (file.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage(new Uri(file.FileName));
                Picture.Source = bitmap;
            }
        }
    }
}







