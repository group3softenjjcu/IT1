using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class SUBJECTS_TABLE
    {
        #region properties
        private string sub_id;
        private string sub_name;
        private string sub_description;
        private string e_username;

        public string Sub_id
        {
            get { return sub_id; }
            set { sub_id = value; }
        }
        
        public string Sub_name
        {
            get { return sub_name; }
            set { sub_name = value; }
        }
        
        public string Sub_description
        {
            get { return sub_description; }
            set { sub_description = value; }
        }
        
        public string E_username
        {
            get { return e_username; }
            set { e_username = value; }
        }

        public SUBJECTS_TABLE() { }

        public SUBJECTS_TABLE(string sub_id, string sub_name, string sub_description, string e_username) {
            this.sub_id = sub_id;
            this.sub_name = sub_name;
            this.sub_description = sub_description;
            this.e_username = e_username;
        }
#endregion

        public bool insertSUBJECTS_TABLE(string sub_id, string sub_name, string sub_description, string e_username) {
            bool kq = true;
            try
            {
                string query = "insert into SUBJECTS_TABLE values('{0}', '{1}', '{2}', '{3}')";
                query = string.Format(query, sub_id, sub_name, sub_description, e_username);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool updateSUBJECTS_TABLE(string sub_id, string sub_name, string sub_description, string e_username) {
            bool kq = true;
            try
            {
                string query = "update SUBJECTS_TABLE set sub_name = '{0}', sub_description = '{1}', e_username = '{2}' where sub_id = '{3}'";
                query = string.Format(query, sub_name, sub_description, e_username, sub_id);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool deleteSUBJECTS_TABLE(string sub_id) {
            bool kq = true;
            try
            {
                string query = "delete SUBJECTS_TABLE where sub_id = '" + sub_id + "'";
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public DataSet listSUBJECTS_TABLE() {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from SUBJECTS_TABLE";
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public DataSet employeeSUBJECTS_TABLE(string e_username) {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from SUBJECTS_TABLE where e_username = '" + e_username + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public SUBJECTS_TABLE dataSUBJECTS_TABLE(string sub_id) {
            SUBJECTS_TABLE sub = new SUBJECTS_TABLE();
            try
            {
                string query = "select * from SUBJECTS_TABLE where sub_id = '" + sub_id + "'";
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    sub.sub_id = dr["sub_id"].ToString();
                    sub.sub_name = dr["sub_name"].ToString();
                    sub.sub_description = dr["sub_description"].ToString();
                    sub.e_username = dr["e_username"].ToString();
                }
            }
            catch {
                sub = null;
            }
            return sub;
        }        

    }
}
