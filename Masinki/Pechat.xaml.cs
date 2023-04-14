using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
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
    /// Логика взаимодействия для Pechat.xaml
    /// </summary>
    public partial class Pechat : Window
    {

        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataAdapter da;
        

        public Pechat()
        {
            InitializeComponent();

            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb"); // Создаем подключение к БД для этой функции
            cmd = new OleDbCommand(); // Создаем команду
            con.Open(); // Открываем соединение с базой

            da = new OleDbDataAdapter("select * from Заказ", con); // Представляет набор команд данных и подключение к базе данных, которые используются для заполнения DataSet и обновления источника данных.
            DataSet ds = new DataSet();
            da.Fill(ds, "Заказ");

            DataZakaz.ItemsSource = ds.Tables["Заказ"].DefaultView; // Заполнение грида нужной базой
            con.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            masinki2 masinki2 = new masinki2();
            masinki2.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string date = DateTime.Today.ToString("G");
            PrintDialog pr = new PrintDialog();
            if (pr.ShowDialog() == true)
            {
                pr.PrintVisual(print, $"{date}");
            }
        }
    }
}
