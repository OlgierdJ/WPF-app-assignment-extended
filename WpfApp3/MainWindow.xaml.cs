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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            BackgroundImg.ImageSource = new BitmapImage(new Uri("https://www.esportsguide.com/wp-content/uploads/2019/05/3-35093_user-generated-contentinsertion-point-counter-strike-global-offensive-1024x576.jpg"));
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            BackgroundImg.ImageSource = new BitmapImage(new Uri("https://images2.alphacoders.com/509/thumb-1920-509945.jpg"));
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            BackgroundImg.ImageSource = new BitmapImage(new Uri("https://bnetcmsus-a.akamaihd.net/cms/gallery/OEAK0Z2RVENZ1573497841736.jpg"));
        }

        private void DisplayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Alert_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
