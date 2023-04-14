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
using System.Windows.Shapes;

namespace masinki
{
    /// <summary>
    /// Логика взаимодействия для masinki2.xaml
    /// </summary>
    public partial class masinki2 : Window
    {
        public masinki2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            masinki4 Masinki4 = new masinki4();
            Masinki4.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }
        garages f2;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            f2 = new garages();
            f2.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Pechat pechat = new Pechat();
            pechat.Show();
            this.Close();
            
        }
    }
}
