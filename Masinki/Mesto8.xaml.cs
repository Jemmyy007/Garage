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
    /// Логика взаимодействия для Mesto8.xaml
    /// </summary>
    public partial class Mesto8 : Window
    {
        public Mesto8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            garage8 garage8= new garage8(); 
            garage8.Show();
            this.Close();
        }
    }
}
