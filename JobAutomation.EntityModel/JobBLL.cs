

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

    public static class JobBLL
    {


        public static List<Job> GetAllJob(System.Int64? JobID)
        {
            List<Job> JobList = new List<Job>();
			SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@JobID", JobID);
            DataTable dt = (new SQLHelper()).ExecuteDataSet(CommandType.StoredProcedure, "JobSearch", p).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                Job objJob = new Job();
				
				objJob.JobId = Int64.Parse(dr["JobId"].ToString());
				objJob.JobName = (dr["JobName"].ToString());
				objJob.JobDescription = (dr["JobDescription"].ToString());
				objJob.JobCreatedUser = (dr["JobCreatedUser"].ToString());
				objJob.JobCreatedDateTime = DateTime.Parse(dr["JobCreatedDateTime"].ToString());
				objJob.JobUpdatedUser = (dr["JobUpdatedUser"].ToString());
				objJob.JobUpdatedDateTime = Object.Parse(dr["JobUpdatedDateTime"].ToString());
				

                JobList.Add(objJob);
            }
            return JobList;
        }


        public static void InsertUpdateJob(Job objJob)
        {
            SQLiteParameter[] p = new SQLiteParameter[7];

				 p[0] = new SQLiteParameter("@JobId", objJob.JobId);
				 p[1] = new SQLiteParameter("@JobName", objJob.JobName);
				 p[2] = new SQLiteParameter("@JobDescription", objJob.JobDescription);
				 p[3] = new SQLiteParameter("@JobCreatedUser", objJob.JobCreatedUser);
				 p[4] = new SQLiteParameter("@JobCreatedDateTime", objJob.JobCreatedDateTime);
				 p[5] = new SQLiteParameter("@JobUpdatedUser", objJob.JobUpdatedUser);
				 p[6] = new SQLiteParameter("@JobUpdatedDateTime", objJob.JobUpdatedDateTime);
				

            objJob.JobID = int.Parse((new SQLHelper()).ExecuteScalar(CommandType.StoredProcedure, "JobInsertUpdate", p).ToString());

        }


        public static int DeleteJob(System.Int64? JobID)
        {
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@JobID", JobID);
            return (new SQLHelper()).ExecuteNonQuery(CommandType.StoredProcedure, "JobDelete", p);
        }


    }