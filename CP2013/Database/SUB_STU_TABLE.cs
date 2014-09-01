using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class SUB_STU_TABLE
    {
        #region properties
        private int id;
        private string sub_id;
        private string s_username;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
       
        public string Sub_id
        {
            get { return sub_id; }
            set { sub_id = value; }
        }
        
        public string S_username
        {
            get { return s_username; }
            set { s_username = value; }
        }

        public SUB_STU_TABLE() { }

        public SUB_STU_TABLE(int id, string sub_id, string s_username) {
            this.id = id;
            this.sub_id = sub_id;
            this.s_username = s_username;
        }
#endregion

        public bool insertSUB_STU_TABLE(string sub_id, string s_username){
            bool kq = true;
            try {
                string query = "insert into SUB_STU_TABLE values('{0}', '{1}')";
                query = string.Format(query, sub_id, s_username);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }

        public bool updateSUB_STU_TABLE(int id, string sub_id, string s_username) {
            bool kq = true;
            try
            {
                string query = "update SUB_STU_TABLE set sub_id = '{0}', s_username = '{1}' where id = {2}";
                query = string.Format(query, sub_id, s_username, id);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool deleteSUB_STU_TABLE(int id) {
            bool kq = true;
            try
            {
                string query = "delete SUB_STU_TABLE where id = " + id;
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public DataSet listSUB_STU_TABLE(string value, int col) {
            DataSet ds = new DataSet();
            try
            {
                string query = "";
                if (col == 1) {
                    query = "select * from SUB_STU_TABLE where sub_id = '" + value + "'";
                }
                else if (col == 2) {
                    query = "select * from SUB_STU_TABLE where s_username = '" + value + "'";
                }
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }
    }
}
