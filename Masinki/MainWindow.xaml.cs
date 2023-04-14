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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace masinki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataAdapter ad;

        public MainWindow()
        {
            InitializeComponent();
            Polsovatel.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = Login.Text;
            string password = Password.Password;

            con = new OleDbConnection(@"Provider = Microsoft.ACE.Oledb.12.0; Data Source = Database1.accdb");
            con.Open();
            string query = "SELECT * FROM users1 where login ='" + Login.Text + "' AND pass ='" + password + "' AND Должность = '" + Polsovatel.Text + "'";
            OleDbDataAdapter ad = new OleDbDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            ad.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                if (Polsovatel.SelectedIndex == 0)
                {
                    this.Hide();
                    new masinki2().ShowDialog();
                    this.Close();
                }

                else if (Polsovatel.SelectedIndex == 1)
                {

                    this.Hide();
                    new admin().ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Неверный Логин, Парорль или Выбор пользователя");
            }
            con.Close();
        }
    }
}
