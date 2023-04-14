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
    /// Логика взаимодействия для redach2.xaml
    /// </summary>
    public partial class redach2 : Window
    {
        private OleDbConnection myConnection;
        public static string connectString = @"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb";  // Подключаем БД

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DataSet ds;

        public redach2()
        {
            InitializeComponent();

            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb"); // Создаем подключение к БД для этой функции
            cmd = new OleDbCommand(); // Создаем команду
            con.Open(); // Открываем соединение с базой

            da = new OleDbDataAdapter("select * from Сотрудники", con); // Представляет набор команд данных и подключение к базе данных, которые используются для заполнения DataSet и обновления источника данных.
            ds = new DataSet();
            da.Fill(ds, "Сотрудники");

            dataClient.ItemsSource = ds.Tables["Сотрудники"].DefaultView; // Заполнение грида нужной базой
            con.Close();


            myConnection = new OleDbConnection(connectString);


            myConnection.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();

            try
            {
                string fio = txtFio.Text;
                int phone = Convert.ToInt32(txtTel.Text);
                string dol = txtDol.Text;

                string query = $"INSERT INTO  Сотрудники ( [ФИО], [Должность], [Номер Тел]) VALUES ( ' {fio} ' , '{phone}', ' {dol} ')";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Добавлено");

                da = new OleDbDataAdapter("select * from  Сотрудники", con);
                ds = new DataSet();
                da.Fill(ds, " Сотрудники");
                dataClient.ItemsSource = ds.Tables[" Сотрудники"].DefaultView;

                txtFio.Text = "";
                txtTel.Text = "";
                txtDol.Text = "";

                con.Close();


            }
            catch (FormatException)
            {
                MessageBox.Show("Цену ввести числами");
                txtTel.Text = "";
            }

            txtFio.Text = "";
            txtTel.Text = "";
            txtDol.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();

            try
            {
                int kod = Convert.ToInt32(txtKod.Text);
                string fio = txtFio.Text;
                int phone = Convert.ToInt32(txtTel.Text);
                string dol = txtDol.Text;

                string query = "UPDATE Сотрудники SET [ФИО] = '" + fio + "', [Должность] = '" + dol + "', [Номер Тел] = '" + phone + "'  WHERE [Код] = " + kod;
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Изменено");

                da = new OleDbDataAdapter("select * from Сотрудники", con);
                ds = new DataSet();
                da.Fill(ds, "Сотрудники");
                dataClient.ItemsSource = ds.Tables["Сотрудники"].DefaultView;

                con.Close();

                txtFio.Text = "";
                txtDol.Text = "";
                txtTel.Text = "";

            }
            catch (FormatException)
            {
                MessageBox.Show("Введите числом код/телефон");
               txtTel.Text = "";
            }

            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();

            try
            {

                int kod = Convert.ToInt32(txtKod.Text);
                string query = "DELETE FROM Сотрудники WHERE [Код] = " + kod;
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Получилось");


                da = new OleDbDataAdapter("select * from Сотрудники ", con);
                ds = new DataSet();
                da.Fill(ds, "Сотрудники");
                dataClient.ItemsSource = ds.Tables["Сотрудники"].DefaultView;


                con.Close();

            }

            catch (FormatException)
            {
                MessageBox.Show("Введите только цифру");
            }
        }
    }
    
}
