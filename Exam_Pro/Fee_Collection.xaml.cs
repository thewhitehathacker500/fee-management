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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using Microsoft.Office.Interop.Excel;
using System.IO;
using Excel;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;
using System.Globalization;

namespace Exam_Pro
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class Fee_Collection : MahApps.Metro.Controls.MetroWindow
    {
        int arrear_amount;
        public Fee_Collection()
        { 

            InitializeComponent();

        }
                
        public void student_list_method()
        {

            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Exam_database;Integrated Security=True");
            con.Open();
            string command = null;
            ArrayList array = new ArrayList();

            command = "select s_usn from student_table where s_sem = @ssem and s_branch = @sbranch;";

            SqlCommand com = new SqlCommand(command, con);
            // string cs="cs", ec="ec", cv="cv", me="me";
            switch_method(com);
            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {   
                array.Add(sdr.GetString(0));
            }
            student_cb.Items.Clear();
            foreach (string line in array)
            {
                student_cb.Items.Add(line);
            }
            con.Close();
            

        }
        public void switch_method(SqlCommand com)
        {
            switch (branch_cb.SelectedIndex)
            {
                case 0:
                    com.Parameters.AddWithValue("@sbranch", "me");
                    break;
                case 1:
                    com.Parameters.AddWithValue("@sbranch", "ec");
                    break;
                case 2:
                    com.Parameters.AddWithValue("@sbranch", "cv");
                    break;
                case 3:
                    com.Parameters.AddWithValue("@sbranch", "cs");
                    break;

            }
            switch (sem_cb.SelectedIndex)
            {
                case 0:
                    com.Parameters.AddWithValue("@ssem", 1);
                    break;
                case 1:
                    com.Parameters.AddWithValue("@ssem", 2);
                    break;
                case 2:
                    com.Parameters.AddWithValue("@ssem", 3);
                    break;
                case 3:
                    com.Parameters.AddWithValue("@ssem", 4);
                    break;
                case 4:
                    com.Parameters.AddWithValue("@ssem", 5);
                    break;
                case 5:
                    com.Parameters.AddWithValue("@ssem", 6);
                    break;
                case 6:
                    com.Parameters.AddWithValue("@ssem", 7);
                    break;
                case 7:
                    com.Parameters.AddWithValue("@ssem", 8);
                    break;
            }
        }

        private void student_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }
        public void dummy_method()
        {
            KillSpecificExcelFileProcess();
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] filePaths = Directory.GetFiles(ofd.SelectedPath, "*.xlsx",
                                         SearchOption.AllDirectories);
                //ofd.Multiselect = true;
   
                foreach (string fp in filePaths)
                {
                    row_delete_method(fp);
                };
                //ofd.DefaultExtension = ".xlsx";
                //  ofd.Filter = "Excel Spreadsheet |*.xlsx; *.xls; *.xlsm ";
                /* if(ofd.ShowDialog() ==true) {
                     row_delete_method(ofd);

                 }*/
                System.Windows.MessageBox.Show("Import Successful!");
            }
        }
        public void row_delete_method(string ofd)
        {
            _Application excelApp = new Microsoft.Office.Interop.Excel.Application { Visible = false };
            dynamic wb = excelApp.Workbooks.Open(ofd);
            var ws = (_Worksheet)wb.ActiveSheet;
            Range range = ws.get_Range("A1", "A4");
            Range entireRow = range.EntireRow;
            entireRow.Delete(XlDirection.xlUp);
            excelApp.DisplayAlerts = false;
            wb.save();
            wb.Close();
            excelApp.DisplayAlerts = true;
            excelApp.Quit();
            //System.Threading.Thread.Sleep(3000);
            excel_to_mssql(ofd);
        }
        public void excel_to_mssql(string ofd)
        {
            try
            {
                FileStream stream = new FileStream(ofd, FileMode.Open);
                IExcelDataReader excelreader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet result = excelreader.AsDataSet();
                student_tableDataContext con = new student_tableDataContext();
                foreach (System.Data.DataTable table in result.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        student_table addtable1 = new student_table()
                        {

                            s_no = Convert.ToString(dr[0]),
                            s_name = Convert.ToString(dr[1]),
                            s_usn = Convert.ToString(dr[2]),
                            s_sem = Convert.ToString(dr[3]),
                            s_branch = Convert.ToString(dr[4])
                        };

                        con.student_tables.InsertOnSubmit(addtable1);
                    }
                }
                con.SubmitChanges();
                excelreader.Close();
                stream.Close();
                KillSpecificExcelFileProcess();
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message + "\n" + ofd);
            }
        }

        private void dummy_Click(object sender, RoutedEventArgs e)
        {
            dummy_method();
        }
        private void KillSpecificExcelFileProcess()
        {
            foreach (Process clsProcess in Process.GetProcesses())
                if (clsProcess.ProcessName.Equals("EXCEL"))  //Process Excel
                    clsProcess.Kill();
        }

        private void sem_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sem_cb.Visibility = Visibility.Visible;
            student_list_method();
 
        }

        private void branch_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sem_cb.Visibility = Visibility.Visible;
        }
        public void arrear_fee_calculator()
        {
            
            arrear_amount = int.Parse(arrear_textbox.Text);

           
            if (one.Checked)
            {
                arrear_amount = arrear_amount * 1;
            }
            else if (two.IsChecked == true)
            {
                arrear_amount = arrear_amount * 2;
                System.Windows.MessageBox.Show("Hey");
            }
            else if (three.IsChecked == true)
            {
                arrear_amount = arrear_amount * 3;
            }
            else if (four.IsChecked == true)
            {
                arrear_amount = arrear_amount * 4;
            }
            else if (five.IsChecked == true)
            {
                arrear_amount = arrear_amount * 5;
            }
            else if (six.IsChecked == true)
            {
                arrear_amount = arrear_amount * 6;
            }
            else if (seven.IsChecked == true)
            {
                arrear_amount = arrear_amount * 7;
            }
            else if (eight.IsChecked == true)
            {
                arrear_amount = arrear_amount * 8;
            }
            else if (nine.IsChecked == true)
            {
                arrear_amount = arrear_amount * 9;
            }
            else if (ten.IsChecked == true)
            {
                arrear_amount = arrear_amount * 10;
            }
            else if (eleven.IsChecked == true)
            {
                arrear_amount = arrear_amount * 11;
            }
            else if (twelve.IsChecked == true)
            {
                arrear_amount = arrear_amount * 12;
            }
        }
        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Exam_database;Integrated Security=True");
            con.Open();
            string command = "select s_name from student_table where s_usn=@s_usn";

            //  ComboBoxItem item = (ComboBoxItem)student_cb.SelectedItem;
            string s_usn = student_cb.Text;
            SqlCommand com = new SqlCommand(command,con);
            com.Parameters.AddWithValue("@s_usn",s_usn);
            SqlDataReader sdr = com.ExecuteReader();
            if (sdr.Read())
            {
                string s_name = sdr["s_name"].ToString();
                info_box.Text = "Name : " + s_name + "\n" + "USN : " + student_cb.Text  +"\n" + "Semester : " + sem_cb.Text + "\n" + "Branch : "+ branch_cb.Text + "\n" +"Arrear Fee :" + "Rs." + arrear_amount;
            }
            con.Close();
            
        }

        private void arrear_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
