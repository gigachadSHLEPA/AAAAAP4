using AP4____.Core;
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

namespace AP4____.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP3());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP4());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP5());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP6());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP7());
        }

        private void Button_Click_77(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP8());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP9());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP10());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP11());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP12());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP13());
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new AP14());
        }
    }
}

