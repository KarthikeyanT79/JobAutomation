

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

    public static class JobGroupBLL
    {


        public static List<JobGroup> GetAllJobGroup(System.Int64? JobGroupID)
        {
            List<JobGroup> JobGroupList = new List<JobGroup>();
			SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@JobGroupID", JobGroupID);
            DataTable dt = (new SQLHelper()).ExecuteDataSet(CommandType.StoredProcedure, "JobGroupSearch", p).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                JobGroup objJobGroup = new JobGroup();
				
				objJobGroup.JobGroupId = Int64.Parse(dr["JobGroupId"].ToString());
				objJobGroup.JobGroupName = Object.Parse(dr["JobGroupName"].ToString());
				objJobGroup.JobGroupCreatedUser = (dr["JobGroupCreatedUser"].ToString());
				objJobGroup.JobGroupCreatedDateTime = DateTime.Parse(dr["JobGroupCreatedDateTime"].ToString());
				objJobGroup.JobGroupUpdatedUser = (dr["JobGroupUpdatedUser"].ToString());
				objJobGroup.JobGroupUpdateDateTime = DateTime.Parse(dr["JobGroupUpdateDateTime"].ToString());
				

                JobGroupList.Add(objJobGroup);
            }
            return JobGroupList;
        }


        public static void InsertUpdateJobGroup(JobGroup objJobGroup)
        {
            SQLiteParameter[] p = new SQLiteParameter[6];

				 p[0] = new SQLiteParameter("@JobGroupId", objJobGroup.JobGroupId);
				 p[1] = new SQLiteParameter("@JobGroupName", objJobGroup.JobGroupName);
				 p[2] = new SQLiteParameter("@JobGroupCreatedUser", objJobGroup.JobGroupCreatedUser);
				 p[3] = new SQLiteParameter("@JobGroupCreatedDateTime", objJobGroup.JobGroupCreatedDateTime);
				 p[4] = new SQLiteParameter("@JobGroupUpdatedUser", objJobGroup.JobGroupUpdatedUser);
				 p[5] = new SQLiteParameter("@JobGroupUpdateDateTime", objJobGroup.JobGroupUpdateDateTime);
				

            objJobGroup.JobGroupID = int.Parse((new SQLHelper()).ExecuteScalar(CommandType.StoredProcedure, "JobGroupInsertUpdate", p).ToString());

        }


        public static int DeleteJobGroup(System.Int64? JobGroupID)
        {
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@JobGroupID", JobGroupID);
            return (new SQLHelper()).ExecuteNonQuery(CommandType.StoredProcedure, "JobGroupDelete", p);
        }


    }