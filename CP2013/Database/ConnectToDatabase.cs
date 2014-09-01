using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Database
{
    class ConnectToDatabase
    {
        private static SqlConnection con;
        private static string strcon;

        public static SqlConnection Getconnect()
        {
            try
            {
                strcon = ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
                con = new SqlConnection(strcon);
                con.Open();
            }
            catch
            {
                con = null;
            }
            return con;
        }        
    }
}
