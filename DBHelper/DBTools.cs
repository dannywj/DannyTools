using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DBHelper
{
    public class DBTools
    {
        public static DataTable getAllEssUser() {
            DataTable dt = null;
            string sql = "SELECT * FROM [dbo].[alluser]";
            try
            {
                dt = SqlHelper.ExecuteDataset(ConnString.GetConString, CommandType.Text, sql.ToString()).Tables[0];
            }
            catch
            {

            }
            return dt;
        }

    }
}
