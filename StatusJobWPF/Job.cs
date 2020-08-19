using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatusJobWPF
{
    public static class Job
    {
        public static int Id;
        public static string Name;
        public static string TextJob;
        public static string Comments;
        public static bool isDelete;

        public static void Fill(StatusJobDBDataSet.JobsRow row)
        {
            Id = row.Id;
            Name = row.Name;
            isDelete = row.isDelete > 0;
            TextJob = row.TextJobs;
            Comments = row.Comments;
        }

        public static void Fill(int Id)
        {
            StatusJobDBDataSetTableAdapters.JobsTableAdapter jobsTableAdapter = new StatusJobDBDataSetTableAdapters.JobsTableAdapter();
            StatusJobDBDataSet.JobsDataTable jobsRows = jobsTableAdapter.GetDataById(Id);

            if (jobsRows.Count > 0)
            {
                Id = jobsRows[0].Id;
                Name = jobsRows[0].Name;
                isDelete = jobsRows[0].isDelete > 0;
                TextJob = jobsRows[0].TextJobs;
                Comments = jobsRows[0].Comments;
            }
        }

        public static StatusJobDBDataSet.JobsRow GetRow()
        {
            StatusJobDBDataSetTableAdapters.JobsTableAdapter jobsTableAdapter = new StatusJobDBDataSetTableAdapters.JobsTableAdapter();
            StatusJobDBDataSet.JobsDataTable jobsRows = jobsTableAdapter.GetDataById(Id);

            return jobsRows.Count > 0 ? jobsRows[0] : null;
        }
    }
}