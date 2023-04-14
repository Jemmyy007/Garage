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
    /// Логика взаимодействия для garage3.xaml
    /// </summary>
    public partial class garage3 : Window
    {
        private OleDbConnection myConnection;
        public static string connectString = @"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb";  // Подключаем БД

        OleDbConnection con;
        OleDbCommand cmd, cmd2;
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DataSet ds;
        public garage3()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();



            string query = "SELECT Стоимость FROM Гаражи WHERE [Код] = 3";
            OleDbCommand cmd = new OleDbCommand(query, con);
            lblPrice3.Content = cmd.ExecuteScalar().ToString() + " руб.";

            string query2 = "SELECT Статус FROM Гаражи WHERE [Код] = 3";
            OleDbCommand cmd2 = new OleDbCommand(query2, con);
            lblStatus3.Content = cmd2.ExecuteScalar().ToString();


            con.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            garages garages = new garages();
            garages.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Mesto3 mesto3 = new Mesto3();
            mesto3.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            masinki4 masinki4 = new masinki4();
            masinki4.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Shema3 shema3= new Shema3();
            shema3.Show();
            this.Close();
        }
    }
}
