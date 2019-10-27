

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

    public static class sqlite_sequenceBLL
    {


        public static List<sqlite_sequence> GetAllsqlite_sequence(System.Int64? sqlite_sequenceID)
        {
            List<sqlite_sequence> sqlite_sequenceList = new List<sqlite_sequence>();
			SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@sqlite_sequenceID", sqlite_sequenceID);
            DataTable dt = (new SQLHelper()).ExecuteDataSet(CommandType.StoredProcedure, "sqlite_sequenceSearch", p).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                sqlite_sequence objsqlite_sequence = new sqlite_sequence();
				
				objsqlite_sequence.name = (dr["name"].ToString());
				objsqlite_sequence.seq = Int64.Parse(dr["seq"].ToString());
				

                sqlite_sequenceList.Add(objsqlite_sequence);
            }
            return sqlite_sequenceList;
        }


        public static void InsertUpdatesqlite_sequence(sqlite_sequence objsqlite_sequence)
        {
            SQLiteParameter[] p = new SQLiteParameter[2];

				 p[0] = new SQLiteParameter("@name", objsqlite_sequence.name);
				 p[1] = new SQLiteParameter("@seq", objsqlite_sequence.seq);
				

            objsqlite_sequence.sqlite_sequenceID = int.Parse((new SQLHelper()).ExecuteScalar(CommandType.StoredProcedure, "sqlite_sequenceInsertUpdate", p).ToString());

        }


        public static int Deletesqlite_sequence(System.Int64? sqlite_sequenceID)
        {
            SQLiteParameter[] p = new SQLiteParameter[1];
            p[0] = new SQLiteParameter("@sqlite_sequenceID", sqlite_sequenceID);
            return (new SQLHelper()).ExecuteNonQuery(CommandType.StoredProcedure, "sqlite_sequenceDelete", p);
        }


    }