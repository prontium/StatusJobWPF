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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StatusJobWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowListStatus.xaml
    /// </summary>
    /// 
    public partial class WindowListStatus : Window
    {
        private StatusJobDBDataSetTableAdapters.StatusTableAdapter statusTableAdapter;
        private StatusJobDBDataSet.StatusDataTable statusTable;
        public WindowListStatus()
        {
            InitializeComponent();

            statusTableAdapter = new StatusJobDBDataSetTableAdapters.StatusTableAdapter();
            statusTable = new StatusJobDBDataSet.StatusDataTable();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            statusTableAdapter.Update(statusTable);
            statusTable.AcceptChanges();

        }

        private void WindowListUser_Loaded(object sender, RoutedEventArgs e)
        {
            statusTableAdapter.Fill(statusTable);
            ListStatusGrid.ItemsSource = statusTable.DefaultView;
        }
    }
}
