using Microsoft.Win32;
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

namespace WpfApp1.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для addPage.xaml
    /// </summary>
    public partial class addPage : Page
    {
        public addPage()
        {
            InitializeComponent();
        }

      

        private void btnLoadImg_Click(object sender, RoutedEventArgs e)
        {
            // Загрузить изображение
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Kamilla image (*.png; *.jpg; *.gif) | *.png; *.jpg; *.gif;";
            if(file.ShowDialog() == true)
            {
                BitmapImage bitmap = new BitmapImage(new Uri(file.FileName));
                Picture.Source = bitmap;
            }
        }

       
    }
}