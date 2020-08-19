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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StatusJobWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListUsers_Click(object sender, RoutedEventArgs e)
        {
            WindowListUsers windowListUsers = new WindowListUsers();
            windowListUsers.Show();
        }

        private void ButtonListStatus_Click(object sender, RoutedEventArgs e)
        {
            WindowListStatus windowListStatus = new WindowListStatus();
            windowListStatus.Show();

        }

        private void ButtonListJob_Click(object sender, RoutedEventArgs e)
        {
            WindowListJob windowListJob = new WindowListJob();
            windowListJob.Show();
        }
    }
}
