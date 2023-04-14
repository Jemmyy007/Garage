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
    /// Логика взаимодействия для Mesto2.xaml
    /// </summary>
    public partial class Mesto2 : Window
    {
        public Mesto2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            garage2 garage2 = new garage2();
            garage2.Show();
            this.Close();
        }
    }
}
