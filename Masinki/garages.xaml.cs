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
    /// Логика взаимодействия для garages.xaml
    /// </summary>
    public partial class garages : Window
    {
        public garages()
        {
            InitializeComponent();
        }

        private void Посмотреть_гараж_1_Click(object sender, RoutedEventArgs e)
        {
          garage_1 garage_1= new garage_1();
          garage_1.Show();
            this.Close();   

        }
        masinki2 f1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            f1 = new masinki2();
            f1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            garage2 garage2= new garage2();
            garage2.Show();
            this.Close();   
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            garage3 garage3 = new garage3();
            garage3.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            garage5 garage5 = new garage5();
            garage5.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            garage6 garage6 = new garage6();
            garage6.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            garage9 garage9 = new garage9();
            garage9.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            garage11 garage11 = new garage11();
            garage11.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            garage13 garage13 = new garage13();
            garage13.Show();
            this.Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            garage15 garage15 = new garage15();
            garage15.Show();
            this.Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            garage14 garage14 = new garage14();
            garage14.Show();
            this.Close();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            garage12 garage12= new garage12();
            garage12.Show();
            this.Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            garage10 garage10 = new garage10();
            garage10.Show();
            this.Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            garage4 garage4 = new garage4();
            garage4.Show();
            this.Close();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            garage7 garage7= new garage7();
            garage7.Show();
            this.Close();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            garage8 garage8 = new garage8();
            garage8.Show();
            this.Close();
        }
    }
}
