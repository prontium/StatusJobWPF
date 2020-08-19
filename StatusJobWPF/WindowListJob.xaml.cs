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
    /// Логика взаимодействия для WindowListJob.xaml
    /// </summary>
    public partial class WindowListJob : Window
    {
        private StatusJobDBDataSetTableAdapters.JobsTableAdapter jobTableAdapter;
        private StatusJobDBDataSet.JobsDataTable jobTable;
        public WindowListJob()
        {
            InitializeComponent();
            jobTableAdapter = new StatusJobDBDataSetTableAdapters.JobsTableAdapter();
            jobTable = new StatusJobDBDataSet.JobsDataTable();
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            jobTableAdapter.Fill(jobTable);
            ListJobGrid.ItemsSource = jobTable.DefaultView;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
