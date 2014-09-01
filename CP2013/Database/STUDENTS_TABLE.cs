using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class STUDENTS_TABLE
    {
        Encript encript = new Encript();
        #region properties
        private string s_username;
        private string s_password;
        private string s_fullname;
        private string s_phone;
        private bool s_gender;
        private string s_picture;
        private bool s_active;

        public string S_username
        {
            get { return s_username; }
            set { s_username = value; }
        }        

        public string S_password
        {
            get { return s_password; }
            set { s_password = value; }
        }
        
        public string S_fullname
        {
            get { return s_fullname; }
            set { s_fullname = value; }
        }        

        public string S_phone
        {
            get { return s_phone; }
            set { s_phone = value; }
        }        

        public bool S_gender
        {
            get { return s_gender; }
            set { s_gender = value; }
        }
        
        public string S_picture
        {
            get { return s_picture; }
            set { s_picture = value; }
        }
        
        public bool S_active
        {
            get { return s_active; }
            set { s_active = value; }
        }

        public STUDENTS_TABLE() { }

        public STUDENTS_TABLE(string s_username, string s_password, string s_fullname, string s_phone, bool s_gender, string s_picture, bool s_active) {
            this.s_username = s_username;
            this.s_password = s_password;
            this.s_fullname = s_fullname;
            this.s_phone = s_phone;
            this.s_gender = s_gender;
            this.s_picture = s_picture;
            this.s_active = s_active;
        }
        #endregion

        public bool changePassword(string s_username, string s_password) {
            s_password = encript.GetMD5Hash(s_password);
            bool kq = true;
            try
            {
                string query = "update STUDENTS_TABLE set s_password = '{0}' where s_username='{1}'";
                query = string.Format(query, s_password, s_username);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }

        public bool checkAccount(string s_username, string s_password)
        {
            bool kq = true;
            try
            {
                string query = "select s_username, s_password from STUDENTS_TABLE where s_username = '{0}' and s_password = '{1}'";
                query = string.Format(query, s_username, s_password);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
                return ds.Tables[0].Rows.Count > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }

        public bool insertSTUDENTS_TABLE(string s_username, string s_password, string s_fullname, string s_phone, bool s_gender, string s_picture, bool s_active) {
            s_password = encript.GetMD5Hash(s_password);
            bool kq = true;
            try
            {
                string query = "insert into STUDENTS_TABLE values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
                query = string.Format(query, s_username, s_password, s_fullname, s_phone, s_gender.ToString(), s_picture, s_active.ToString());
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool updateSTUDENT_TABLE(string s_username, string s_password, string s_fullname, string s_phone, bool s_gender, string s_picture, bool s_active) {
            bool kq = true;
            try
            {
                string query = "update STUDENTS_TABLE set s_password = '{0}', s_fullname = '{1}', s_phone = '{2}', s_gender = '{3}', s_picture = '{4}', s_active = '{5}' where s_username = '{6}'";
                query = string.Format(query, s_password, s_fullname, s_phone, s_gender.ToString(), s_picture, s_active.ToString(), s_username);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                kq = false;
            }
            return kq;
        }

        public DataSet listSTUDENTS_TABLE() {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from STUDENTS_TABLE";
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public STUDENTS_TABLE dataSTUDENTS_TABLE(string s_username) {
            STUDENTS_TABLE student = new STUDENTS_TABLE();
            try
            {
                string query = "select * from STUDENTS_TABLE where s_username = '" + s_username + "'";
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    student.s_username = dr["s_username"].ToString();
                    student.s_password = dr["s_password"].ToString();
                    student.s_fullname = dr["s_fullname"].ToString();
                    student.s_phone = dr["s_phone"].ToString();
                    student.s_gender = Convert.ToBoolean(dr["s_gender"].ToString());
                    student.s_picture = dr["s_picture"].ToString();
                    student.s_active = Convert.ToBoolean(dr["s_active"].ToString());
                }
            }
            catch {
                student = null;
            }
            return student;
        }
    }
}
