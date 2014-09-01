using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public class EMPLOYEES_TABLE
    {
        Encript encript = new Encript();

        #region properties
        private string e_username;
        private string e_password;
        private string e_fullname;
        private string e_phone;
        private bool e_gender;
        private string e_picture;
        private string de_id;
        private bool de_head;
        private bool e_active;

        public bool E_active
        {
          get { return e_active; }
          set { e_active = value; }
        }
       
        public string E_username
        {
            get { return e_username; }
            set { e_username = value; }
        }

        public string E_password
        {
            get { return e_password; }
            set { e_password = value; }
        }

        public string E_fullname
        {
            get { return e_fullname; }
            set { e_fullname = value; }
        }

        public string E_phone
        {
            get { return e_phone; }
            set { e_phone = value; }
        }

        public bool E_gender
        {
            get { return e_gender; }
            set { e_gender = value; }
        }
        public string E_picture
        {
            get { return e_picture; }
            set { e_picture = value; }
        }

        public string De_id
        {
            get { return de_id; }
            set { de_id = value; }
        }

        public bool De_head
        {
            get { return de_head; }
            set { de_head = value; }
        }

        public EMPLOYEES_TABLE() { }

        public EMPLOYEES_TABLE(string e_username, string e_password, string e_fullname, string e_phone, bool e_gender, string e_picture, string de_id, bool de_head, bool e_active) {
            this.e_username = e_username;
            this.e_password = e_password;
            this.e_fullname = e_fullname;
            this.e_phone = e_phone;
            this.e_gender = e_gender;
            this.e_picture = e_picture;
            this.de_id = de_id;
            this.de_head = de_head;
            this.e_active = e_active;
        }
        #endregion

        public bool checkAccount(string e_username, string e_password) {            
            bool kq = true;
            try
            {
                string query = "select e_username, e_password from EMPLOYEES_TABLE where e_username = '{0}' and e_password = '{1}'";
                query = string.Format(query, e_username, e_password);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
                return ds.Tables[0].Rows.Count > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool insertEMPLOYEES_TABLE(string e_username, string e_password, string e_fullname, string e_phone, bool e_gender, string e_picture, string de_id, bool de_head, bool e_active)
        {
            e_password = encript.GetMD5Hash(e_password);            
            bool kq = true;
            try
            {
                string query = "insert into EMPLOYEES_TABLE values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')";
                query = string.Format(query, e_username, e_password, e_fullname, e_phone, e_gender.ToString(), e_picture, de_id, de_head.ToString(), e_active.ToString());
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool updateEMPLOYEES_TABLE(string e_username, string e_password, string e_fullname, string e_phone, bool e_gender, string e_picture, string de_id, bool de_head, bool e_active)
        {
            bool kq = true;
            try
            {
                string query = "update EMPLOYEES_TABLE set e_password = '{0}', e_fullname = '{1}', e_phone = '{2}', e_gender = '{3}', e_picture = '{4}', de_id = '{5}', de_head = '{6}', e_active= '{7}' where e_username = '{8}'";
                query = string.Format(query, e_password, e_fullname, e_phone, e_gender.ToString(), e_picture, de_id, de_head.ToString(), e_username);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool DeleteEMPLOYEES_TABLE(string e_username)
        {
            bool kq = true;

            try
            {
                string query = "delete from EMPLOYEES_TABLE where e_username ='" + e_username + "'";
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }

        public DataSet listEMPLOYEES_TABLE() {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from EMPLOYEES_TABLE order by de_id";
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public DataSet listEMPByDepartment(string de_id) {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from EMPLOYEES_TABLE where de_id = '" + de_id +"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public EMPLOYEES_TABLE dataEMPLOYEES_TABLE(string e_username) {
            EMPLOYEES_TABLE em = new EMPLOYEES_TABLE();
            try
            {
                string query = "select * from EMPLOYEES_TABLE where e_username='" + e_username + "'";
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    em.e_username = dr["e_username"].ToString();
                    em.e_password = dr["e_password"].ToString();
                    em.e_fullname = dr["e_fullname"].ToString();                    
                    em.e_phone = dr["e_phone"].ToString();
                    em.e_gender = Convert.ToBoolean(dr["e_gender"].ToString());                    
                    em.e_picture = dr["e_picture"].ToString();
                    em.de_id = dr["de_id"].ToString();
                    em.de_head = Convert.ToBoolean(dr["de_head"].ToString());
                    em.e_active = Convert.ToBoolean(dr["e_active"].ToString());
                }
            }
            catch
            {
                em = null;
            }
            return em;
        }


    }
}
