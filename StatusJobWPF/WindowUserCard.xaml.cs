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
    /// Логика взаимодействия для WindowUserCard.xaml
    /// </summary>
    public partial class WindowUserCard : Window
    {
        public StatusJobDBDataSet.UsersRow usersRow;
        public bool isNew = false;
        public WindowUserCard()
        {
            InitializeComponent();
            
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (usersRow != null)
            {
                usersRow.Id = int.Parse(Id.Text);
                usersRow.Name = Name.Text;
                if ((bool)isDelete.IsChecked)
                {
                    usersRow.isDelete = 1;
                }
                else
                {
                    usersRow.isDelete = 0;
                }
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (usersRow != null)
            {
                Id.Text = usersRow.Id.ToString();
                Name.Text = usersRow.Name;
                if (usersRow.IsisDeleteNull())
                    isDelete.IsChecked = false;
                else
                    isDelete.IsChecked = usersRow.isDelete > 0;
            }
            else
                isNew = true;
        }
    }
}
