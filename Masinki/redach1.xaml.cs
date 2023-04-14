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
    /// Логика взаимодействия для redach1.xaml
    /// </summary>
    public partial class redach1 : Window
    {

        private OleDbConnection myConnection;
        public static string connectString = @"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb";  // Подключаем БД

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DataSet ds;

        public redach1()
        {
            InitializeComponent();

            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb"); // Создаем подключение к БД для этой функции
            cmd = new OleDbCommand(); // Создаем команду
            con.Open(); // Открываем соединение с базой

            da = new OleDbDataAdapter("select * from Гаражи", con); // Представляет набор команд данных и подключение к базе данных, которые используются для заполнения DataSet и обновления источника данных.
            ds = new DataSet();
            da.Fill(ds, "Гаражи");

            dataGarage.ItemsSource = ds.Tables["Гаражи"].DefaultView; // Заполнение грида нужной базой
            con.Close();


            myConnection = new OleDbConnection(connectString);


            myConnection.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin admin=new admin();
            admin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();

            try
            {
                int kod = Convert.ToInt32(txtN.Text);
                int price = Convert.ToInt32(txtPrice.Text);


                string query = "UPDATE Гаражи SET [Стоимость] = '" + price + "' WHERE [Код] = " + kod;
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Изменено");

                da = new OleDbDataAdapter("select * from Гаражи", con);
                ds = new DataSet();
                da.Fill(ds, "Гаражи");
                dataGarage.ItemsSource = ds.Tables["Гаражи"].DefaultView;

                con.Close();

                txtN.Text = "";
                txtPrice.Text = "";

            }
            catch (FormatException)
            {
                MessageBox.Show("Введите числом код/стоимость");
                txtN.Text = "";
                txtPrice.Text = "";
            }
        }
    }
}
