using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Exam_Pro
{
    /// <summary>
    /// Interaction logic for signup_window.xaml
    /// </summary>
    public partial class signup_window : MahApps.Metro.Controls.MetroWindow
    {
        public signup_window()
        {
            InitializeComponent();

        }

        private void signup_button_Click(object sender, RoutedEventArgs e)
        {
            /* string date = date_picker_signup.SelectedDate.Value.Date.ToShortDateString();
             MessageBox.Show(date);*/
            if (user_id_signup.Text == "")
            {
                user_id_null.Visibility = Visibility.Visible;
            }
            else
            {
                user_id_null.Visibility = Visibility.Hidden;
            }
            if (date_picker_signup.SelectedDate == null)
            {
              //  date_picker_null.Text = 
                date_picker_null.Visibility = Visibility.Visible;
            }
            else
            {
                date_picker_null.Visibility = Visibility.Hidden;
            }
            if(product_key.Text == "")
            {
                product_key_null.Visibility = Visibility.Visible;
            }
            else
            {
                product_key_null.Visibility = Visibility.Hidden;

            }
            if (password_box_signup.Password == password_box_confirm.Password && password_box_signup.Password!="" && password_box_confirm.Password!="" && user_id_signup.Text!="" && date_picker_signup.SelectedDate!=null && product_key.Text!="" )
            {
                string date = date_picker_signup.SelectedDate.Value.Date.ToShortDateString();
                string pw = password_box_signup.Password;
                string pk =product_key.Text ;
                string usr = user_id_signup.Text;
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Exam_database;Integrated Security=True");
                con.Open();
                try
                {
                    using (SqlCommand command1 = new SqlCommand("CREATE TABLE login_table(username varchar(50),password varchar(50),dob varchar(50), product_key varchar(50));", con)) command1.ExecuteNonQuery();

                }catch(SqlException se)
                {

                }
                //   MessageBox.Show(date,pw,pk,usr);
                try
                {
                    SqlCommand command2 = new SqlCommand("insert into login_table(username,password,dob,product_key) values(@usr, @pw, @date,@pk); ");
                    command2.Connection = con;
                    command2.Parameters.AddWithValue("@usr", usr);
                    command2.Parameters.AddWithValue("@pw", pw);
                    command2.Parameters.AddWithValue("@date", date);
                    command2.Parameters.AddWithValue("@pk", pk);
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Sign up Successful", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                catch
                {
                    MessageBox.Show("User Name already taken", "Fail", MessageBoxButton.OK, MessageBoxImage.Stop);
                }

            }
            else
            {
                if (password_box_signup.Password == "" || password_box_confirm.Password == "")
                {
                    password_wrong.Text = "Enter the password";
                    password_wrong.Visibility = Visibility.Visible;
                }
                else if(password_box_signup.Password!=password_box_confirm.Password)
                {
                    password_wrong.Text = "Passwords don't match!!";
                    password_wrong.Visibility = Visibility.Visible;
                }
                else
                {
                    password_wrong.Visibility = Visibility.Hidden;
                    password_wrong.Visibility = Visibility.Hidden;
                }
            }
            
        }
    }
}
