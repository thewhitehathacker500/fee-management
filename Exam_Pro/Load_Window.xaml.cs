using System;
using System.IO;
using System.Windows;
using Excel;
using Microsoft.Win32;
using System.Data;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace Exam_Pro
{
    /// <summary>
    /// Interaction logic for Load_Window.xaml
    /// </summary>
    public partial class Load_Window : MahApps.Metro.Controls.MetroWindow
    {   
        public Load_Window(OpenFileDialog ofd, SqlConnection con)
        {
            row_delete_method(ofd);
            MessageBox.Show("Import Successful!");
        }
        public void row_delete_method(OpenFileDialog ofd )
        {
            _Application excelApp = new Microsoft.Office.Interop.Excel.Application { Visible = false };
            dynamic wb = excelApp.Workbooks.Open(ofd.FileName);
            var ws = (_Worksheet)wb.ActiveSheet;
            Range range = ws.get_Range("A1", "A3");
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
        public void excel_to_mssql(OpenFileDialog ofd)
        {
            FileStream stream = new FileStream(ofd.FileName, FileMode.Open);
            IExcelDataReader excelreader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelreader.AsDataSet();
           // string myconnectionstring = "Data Source = DESKTOP - 250RMIQ\\SQLEXPRESS; Initial Catalog = Exam_database; Integrated Security = True";
           // DbmlDataContext db = new DbmlDataContext(myconnectionstring);
            DbmlDataContext conn1 = new DbmlDataContext();
            foreach (System.Data.DataTable table in result.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    exam_table addtable1 = new exam_table()
                    {

                        s_no = Convert.ToString(dr[0]),
                        usn = Convert.ToString(dr[1]),
                        s_name = Convert.ToString(dr[2]),
                        sub_code = Convert.ToString(dr[3]),
                        sub_name = Convert.ToString(dr[4]),
                        sem = Convert.ToString(dr[5])
                    };

                    conn1.exam_tables.InsertOnSubmit(addtable1);
                }
            }
            conn1.SubmitChanges();
            excelreader.Close();
            stream.Close();
        }
    }
}
