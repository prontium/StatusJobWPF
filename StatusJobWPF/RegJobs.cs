using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatusJobWPF
{
    public class RegJobs
    {
        public int Id;
        public int idJob;
        public int idUser;
        public int idStatus;
        public DateTime modifedDate;
        public int idInitUser;
        public int idJobUser;
        public bool isDelete;

        public void Fill(StatusJobDBDataSet.regJobsRow row)
        {
            throw new System.NotImplementedException();
        }

        public StatusJobDBDataSet.regJobsRow GetData()
        {
            throw new System.NotImplementedException();
        }
    }
}