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
    /// Логика взаимодействия для masinki4.xaml
    /// </summary>
    public partial class masinki4 : Window
    {
        private OleDbConnection myConnection;
        public static string connectString = @"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb";  // Подключаем БД

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DataSet ds;

        public masinki4()
        {
            InitializeComponent();

            Date.DisplayDateStart= DateTime.Now;
            Date.Text = DateTime.Today.ToString();

            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb"); // Создаем подключение к БД для этой функции
            cmd = new OleDbCommand(); // Создаем команду
            con.Open(); // Открываем соединение с базой

            da = new OleDbDataAdapter("select * from Заказ", con); // Представляет набор команд данных и подключение к базе данных, которые используются для заполнения DataSet и обновления источника данных.
            ds = new DataSet();
            da.Fill(ds, "Заказ");

            DataZakaz.ItemsSource = ds.Tables["Заказ"].DefaultView; // Заполнение грида нужной базой
            con.Close();


            myConnection = new OleDbConnection(connectString);


            myConnection.Open();
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            masinki1 Masinki1 = new masinki1();
            Masinki1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            masinki2 Masinki2 = new masinki2();
            Masinki2.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                // printDialog.PrintVisual(п, "Распечатываем элемент Canvas");//
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();

            try
            {
                string fio = txtFio.Text;
                int phone = Convert.ToInt32(txtTel.Text);
                int garage = Convert.ToInt32(txtNum.Text);
                int dengi = Convert.ToInt32(txtPrice.Text);
                string date = Date.SelectedDate.Value.ToString("dd/MM/yyyy");

                string query = $"INSERT INTO  Заказ ( [ФИО клиента], [Номер Тел], [№Гража], [Цена], Дата) VALUES ( ' {fio} ' , '{phone}', ' {garage} ', '{dengi}','{date}')";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Добавлено");

                da = new OleDbDataAdapter("select * from  Заказ", con);
                ds = new DataSet();
                da.Fill(ds, " Заказ");
                DataZakaz.ItemsSource = ds.Tables[" Заказ"].DefaultView;

                txtFio.Text = "";
                txtTel.Text = "";
                txtNum.Text = ""; 
                txtPrice.Text = "";
                Date.Text = "";

                con.Close();


            }
            catch (FormatException)
            {
                MessageBox.Show("номер ввести числами");
                txtTel.Text = "";
            }

           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();

            try
            {

                int kod = Convert.ToInt32(txtKod.Text);
                string query = "DELETE FROM Заказ WHERE [Код] = " + kod;
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Получилось");


                da = new OleDbDataAdapter("select * from Заказ ", con);
                ds = new DataSet();
                da.Fill(ds, "Заказ");
                DataZakaz.ItemsSource = ds.Tables["Заказ"].DefaultView;


                con.Close();

            }

            catch (FormatException)
            {
                MessageBox.Show("Введите только цифру");
            }






        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();

            try
            {
                int kod = Convert.ToInt32(txtKod.Text);
                string fio = txtFio.Text;
                int phone = Convert.ToInt32(txtTel.Text);
                int garage = Convert.ToInt32(txtNum.Text);
                int dengi = Convert.ToInt32(txtPrice.Text);

                string query = "UPDATE Заказ SET [ФИО Клиента] = '" + fio + "', [Номер Тел] = '" + phone + "', [№Гража] = '" + garage + "', [Цена] = '" + dengi + "' WHERE [Код] = " + kod;
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Изменено");

                da = new OleDbDataAdapter("select * from Заказ", con);
                ds = new DataSet();
                da.Fill(ds, "Заказ");
                DataZakaz.ItemsSource = ds.Tables["Заказ"].DefaultView;

                con.Close();

                txtFio.Text = "";
                txtTel.Text = "";
                txtNum.Text = "";
                txtPrice.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите числом код/телефон");
                txtTel.Text = "";
            }
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
                con.Open();

                int num = Convert.ToInt32(txtNum.Text);

                string query2 = "SELECT * FROM Гаражи WHERE Код = " + num;
                OleDbDataAdapter ad = new OleDbDataAdapter(query2,con);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    string query = "SELECT Стоимость FROM Гаражи WHERE Код =" + num;
                    cmd = new OleDbCommand(query, con);
                    txtPrice.Text = cmd.ExecuteScalar().ToString();
                }
                else
                {
                    MessageBox.Show("Такого гаража не существует");
                    txtNum.Text = "";
                }

            }
            catch (FormatException)
            {
                txtNum.Text = "";
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            con.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
