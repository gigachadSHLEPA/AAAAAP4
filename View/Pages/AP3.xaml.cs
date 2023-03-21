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
    /// Логика взаимодействия для AP3.xaml
    /// </summary>
    public partial class AP3 : Page
    {
        public AP3()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Coree.MyCore?.Navigate(new MainPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(TbA.Text);
            int N = Convert.ToInt32(TbB.Text);

            MessageBox.Show($"A^N = {Math.Pow(A,N)}");
            }
            catch
            {
                MessageBox.Show($"ВЫХОДИ ОТСЮДА, А ТО ЗАРЕЖУ!! ААААААААААААААААА!!! *агрессивно достает нож*");
            }
        }
    }
}
