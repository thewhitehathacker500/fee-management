using System;
using System.Windows;
using System.Data.SqlClient;
using System.Windows.Media;
using Microsoft.Win32;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace Exam_Pro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            Welcome_screen welcome_Screen = new Welcome_screen();
            welcome_Screen.Show();
            Close();
        }
        private void conn_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Exam_database;Integrated Security=True");
                con.Open();
                conn_button.Background = new SolidColorBrush(Colors.Green);
                conn_button.Content = "ONLINE";
            }
            catch (Exception ex)
            {
                conn_button.Background = new SolidColorBrush(Colors.Red);
                conn_button.Content = "OFFLINE";

               // Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\thewh\source\repos\Exam_Pro\Student_db.mdf; Integrated Security = True
            }
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Exam_database;Integrated Security=True");
            string usrname = user_id.Text;
            string password = password_box.Password;
            string code = "select username,password from login_table where username=@username and password=@password";
            con.Open();
            SqlCommand com = new SqlCommand(code, con);
            com.Parameters.AddWithValue("@username", usrname);
            com.Parameters.AddWithValue("@password", password);
            SqlDataReader sdr = com.ExecuteReader();
            string usrname1=null, password2=null;
            if (sdr.Read())
            {
                usrname1 = sdr["username"].ToString();
                password2 = sdr["password"].ToString();
                Welcome_screen wc = new Welcome_screen();
                wc.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
   
        }

        private void forgot_pass_Click(object sender, RoutedEventArgs e)
        {
            Forgot_Password forgpass = new Forgot_Password();
            forgpass.Show();
        }

        private void signup_button_Click(object sender, RoutedEventArgs e)
        {
            signup_window signup = new signup_window();
            signup.Show();
        }
    }
}
