using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusJobWPF
{
    public static class User
    {
        public static int Id = 0;
        public static string Name = "";
        public static bool isDelete = false;

        public static void Fill(StatusJobDBDataSet.UsersRow row)
        {
            Id = row.Id;
            Name = row.Name;
            isDelete = row.IsisDeleteNull() ? false : row.isDelete > 0;
        }

        public static void Fill(int Id)
        {
            StatusJobDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new StatusJobDBDataSetTableAdapters.UsersTableAdapter();
            StatusJobDBDataSet.UsersDataTable usersRows = usersTableAdapter.GetDataById(Id);

            if (usersRows.Count>0)
            {
                Id = usersRows[0].Id;
                Name = usersRows[0].Name;
                isDelete = usersRows[0].IsisDeleteNull() ? false : usersRows[0].isDelete > 0;
            }
        }

        public static StatusJobDBDataSet.UsersRow GetRow()
        {
            StatusJobDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter = new StatusJobDBDataSetTableAdapters.UsersTableAdapter();
            StatusJobDBDataSet.UsersDataTable usersRows = usersTableAdapter.GetDataById(Id);

            return usersRows.Count > 0 ? usersRows[0] : null;
        }
    }
}
