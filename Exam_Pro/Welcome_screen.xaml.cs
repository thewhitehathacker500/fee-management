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
    /// Interaction logic for Welcome_screen.xaml
    /// </summary>
    public partial class Welcome_screen : MahApps.Metro.Controls.MetroWindow
    {
        Model1 dataEntities = new Model1();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        public Welcome_screen()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".xlsx";
            ofd.Filter = "Excel Spreadsheet |*.xlsx; *.xls; *.xlsm ";
            if (ofd.ShowDialog() == true)
            {
                Load_Window lw = new Load_Window(ofd, con);
                lw.Show();

            }
        }
        static void main(String[] args)
        {

        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog();
            dlg.Title = "Folder Picker ";
            dlg.IsFolderPicker = true;
            string tempPath = Path.GetTempPath();
            dlg.InitialDirectory = tempPath;

            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var folder = dlg.FileName;
            }
        }

        private void fee_collection_Click(object sender, RoutedEventArgs e)
        {
            Fee_Collection fc = new Fee_Collection();
            fc.Show();
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            

        }
    }
}
