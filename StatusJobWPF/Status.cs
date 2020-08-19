using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatusJobWPF
{
    public static class Status
    {
        public static int Id;
        public static string Name;
        public static bool isDelete;

        public static void Fill(StatusJobDBDataSet.StatusRow row)
        {
            Id = row.Id;
            Name = row.Name;
            isDelete = row.isDelete > 0;
        }

        public static void Fill(int Id)
        {
            StatusJobDBDataSetTableAdapters.StatusTableAdapter statusTableAdapter = new StatusJobDBDataSetTableAdapters.StatusTableAdapter();
            StatusJobDBDataSet.StatusDataTable statusRows = statusTableAdapter.GetDataById(Id);

            if (statusRows.Count > 0)
            {
                Id = statusRows[0].Id;
                Name = statusRows[0].Name;
                isDelete = statusRows[0].isDelete > 0;
            }
        }

        public static StatusJobDBDataSet.StatusRow GetRow()
        {
            StatusJobDBDataSetTableAdapters.StatusTableAdapter statusTableAdapter = new StatusJobDBDataSetTableAdapters.StatusTableAdapter();
            StatusJobDBDataSet.StatusDataTable statusRows = statusTableAdapter.GetDataById(Id);

            return statusRows.Count > 0 ? statusRows[0] : null;
        }
    }
}