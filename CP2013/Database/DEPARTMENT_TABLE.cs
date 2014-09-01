using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DEPARTMENT_TABLE
    {
        #region properties
        private string de_id;
        private string de_name;
        private string de_description;

        public string De_description
        {
            get { return de_description; }
            set { de_description = value; }
        }

        public string De_id
        {
            get { return de_id; }
            set { de_id = value; }
        }        

        public string De_name
        {
            get { return de_name; }
            set { de_name = value; }
        }

        public DEPARTMENT_TABLE() { }

        public DEPARTMENT_TABLE(string de_id, string de_name, string de_description) {
            this.de_id = de_id;
            this.de_name = de_name;
            this.de_description = de_description;
        }
        #endregion

        public bool insertDepartment(string de_id, string de_name, string de_description) {
            bool kq = true;
            try
            {
                string query = "insert into DEPARTMENT_TABLE values('{0}', '{1}', '{2}')";
                query = string.Format(query, de_id, de_name, de_description);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool updateDepartment(string de_id, string de_name, string de_description) {
            bool kq = true;
            try
            {
                string query = "update DEPARTMENT_TABLE set de_name = '{0}', de_description = '{1}' where de_id = '{2}'";
                query = string.Format(query, de_name, de_description, de_id);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool deleteDepartment(string de_id) {
            bool kq = true;
            try
            {
                string query = "delete from DEPARTMENT_TABLE where de_id = '" + de_id + "'";                
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }


        public DataSet listDEPARTMENT_TABLE() {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from DEPARTMENT_TABLE";
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
