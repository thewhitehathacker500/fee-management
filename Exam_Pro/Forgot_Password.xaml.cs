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
    /// Interaction logic for Forgot_Password.xaml
    /// </summary>
    public partial class Forgot_Password : MahApps.Metro.Controls.MetroWindow
    {
        public Forgot_Password()
        {
            InitializeComponent();
  
        }

        private void forgot_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string date = forgot_pass_date_picker.SelectedDate.Value.Date.ToShortDateString();
                SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Exam_database;Integrated Security=True");
                string code = "select password from login_table where dob = @date;";
                con.Open();
                SqlCommand com = new SqlCommand(code,con);
                com.Parameters.AddWithValue("@date",date);
                //com.ExecuteNonQuery();
                SqlDataReader sdr = com.ExecuteReader();
                if (sdr.Read())
                {
                    string msg="Your Password is "+sdr["password"].ToString(); ;
                    MessageBox.Show(msg);
                }
                
                Close();
            }catch(SqlException se)
            {
                MessageBox.Show("Enter the date of birth");
            }
        }
    }
}
