using System;
using System.Collections.Generic;
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

namespace StatusJobWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowListUsers.xaml
    /// </summary>
    public partial class WindowListUsers : Window
    {
        private StatusJobDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private StatusJobDBDataSet.UsersDataTable usersTable;
        public WindowListUsers()
        {
            InitializeComponent();
            usersTableAdapter = new StatusJobDBDataSetTableAdapters.UsersTableAdapter();
            usersTable = new StatusJobDBDataSet.UsersDataTable();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            usersTableAdapter.Fill(usersTable);
            ListUsersGrid.ItemsSource = usersTable.DefaultView;

        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            usersTableAdapter.Update(usersTable);
            usersTable.AcceptChanges();
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            System.Data.DataRowView row = (System.Data.DataRowView)this.ListUsersGrid.SelectedItem;
            
            if (row!=null)
            {
                int currentId = (int)row.Row["Id"];
                StatusJobDBDataSet.UsersRow usersRow = (StatusJobDBDataSet.UsersRow)row.Row;

                WindowUserCard userCard = new WindowUserCard();
                userCard.usersRow = usersRow;
                userCard.Show();
            }
            
        }

        private void ListUsersGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int c = 0;
        }
    }
}
