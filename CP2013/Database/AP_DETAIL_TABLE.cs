using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class AP_DETAIL_TABLE
    {
        #region properties
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string s_username;

        public string S_username
        {
            get { return s_username; }
            set { s_username = value; }
        }
        private int ap_id;

        public int Ap_id
        {
            get { return ap_id; }
            set { ap_id = value; }
        }
        private bool ap_booked;

        public bool Ap_booked
        {
            get { return ap_booked; }
            set { ap_booked = value; }
        }

        public AP_DETAIL_TABLE() { }

        public AP_DETAIL_TABLE(int id, string s_username, int ap_id, bool ap_booked) {
            this.id = id;
            this.s_username = s_username;
            this.ap_id = ap_id;
            this.ap_booked = ap_booked;
        }
#endregion

        public bool insertAP_DETAIL_TABLE(string s_username, int ap_id, bool ap_booked) {
            bool kq = true;
            try
            {
                string query = "insert into APPOINTMENT_DETAIL_TABLE(s_username, ap_id, ap_booked) values('{0}', {1}, '{2}')";
                query = string.Format(query, s_username, ap_id, ap_booked.ToString());
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool updateAP_DETAIL_TABLE(int id, string s_username, int ap_id, bool ap_booked) {
            bool kq = true;
            try
            {
                string query = "update APPOINTMENT_DETAIL_TABLE set s_username = '{0}', ap_id = {1}, ap_booked = '{2}' where id = {3}";
                query = string.Format(query, s_username, ap_id, ap_booked, id);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool deleteAP_DETAIL_TABLE(int id) {
            bool kq = true;
            try
            {
                string query = "delete APPOINTMENT_DETAIL_TABLE where id = " + id;
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public DataSet listAP_DETAIL_TABLE() {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from APPOINTMENT_DETAIL_TABLE";
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public DataSet optionalAPP_DETAIL_TABLE(string value, int col) {
            DataSet ds = new DataSet();
            try
            {
                string query = "";
                if (col == 1) {
                    query = "select * from APPOINTMENT_DETAIL_TABLE where s_username = '" + value +"'";
                }
                else if (col == 2) {
                    query = "select * from APPOINTMENT_DETAIL_TABLE where ap_id = " + ap_id;
                }
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public AP_DETAIL_TABLE dataAPP_DETAIL_TABLE(int id) {
            AP_DETAIL_TABLE ap = new AP_DETAIL_TABLE();
            try
            {
                string query = "select * from APPOINTMENT_DETAIL_TABLE where id = " + id;
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    ap.id = Convert.ToInt32(dr["id"].ToString());
                    ap.s_username = dr["s_username"].ToString();
                    ap.ap_id = Convert.ToInt32(dr["ap_id"].ToString());
                    ap.ap_booked = Convert.ToBoolean(dr["ap_booked"].ToString());
                }
            }
            catch {
                ap = null;
            }
            return ap;
        }


    }
}
