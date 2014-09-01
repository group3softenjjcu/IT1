using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class APPOINTMENT_TABLE
    {
        #region properties
        private int ap_id;
        private DateTime ap_date;
        private string ap_time;
        private string ap_room;
        private string ap_description;
        private string sub_id;
        private string e_username;

        public int Ap_id
        {
            get { return ap_id; }
            set { ap_id = value; }
        }
        

        public DateTime Ap_date
        {
            get { return ap_date; }
            set { ap_date = value; }
        }
        

        public string Ap_time
        {
            get { return ap_time; }
            set { ap_time = value; }
        }
        

        public string Ap_room
        {
            get { return ap_room; }
            set { ap_room = value; }
        }
        

        public string Ap_description
        {
            get { return ap_description; }
            set { ap_description = value; }
        }
        

        public string Sub_id
        {
            get { return sub_id; }
            set { sub_id = value; }
        }
        

        public string E_username
        {
            get { return e_username; }
            set { e_username = value; }
        }

        public APPOINTMENT_TABLE() { }

        public APPOINTMENT_TABLE(int ap_id, DateTime ap_date, string ap_time, string ap_room, string ap_description, string sub_id, string e_username) {
            this.ap_id = ap_id;
            this.ap_date = ap_date;
            this.ap_time = ap_time;
            this.ap_room = ap_room;
            this.ap_description = ap_description;
            this.sub_id = sub_id;
            this.e_username = e_username;
        }
#endregion

        public bool insertAPPOINTMENT_TABLE(DateTime ap_date, string ap_time, string ap_room, string ap_description, string sub_id, string e_username) {
            bool kq = true;
            try
            {
                string query = "insert into APPOINTMENT_TABLE values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')";
                query = string.Format(query, ap_date.ToString("MM-dd-yyyy"), ap_time, ap_room, ap_description, sub_id, e_username);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool updateAPPOINTMENT_TABLE(int ap_id, DateTime ap_date, string ap_time, string ap_room, string ap_description, string sub_id, string e_username)
        {
            bool kq = true;
            try
            {
                string query = "update APPOINTMENT_TABLE set ap_date = '{0}', ap_time = '{1}', ap_room = '{2}', ap_description = '{3}', sub_id = '{4}', e_username = '{5}' where ap_id = {6}";
                query = string.Format(query, ap_date.ToString("MM-dd-yyyy"), ap_time, ap_room, ap_description, sub_id, e_username, ap_id);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool deleteAPPOINTMENT_TABLE(int ap_id) {
            bool kq = true;
            try
            {
                string query = "delete APPOINTMENT_TABLE where ap_id = " + ap_id;
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public DataSet listAPPOINTMENT_TABLE() {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from APPOINTMENT_TABLE order by ap_date";
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public DataSet optionalAPPOINTMENT_TABLE(string value, int col) {
            DataSet ds = new DataSet();
            try
            {
                string query = "";
                if (col == 1) {
                    query = "select * from APPOINTMENT_TABLE where sub_id = '" + value + "' and ap_date > getdate() order by ap_date";
                }
                else if (col == 2) {
                    query = "select * from APPOINTMENT_TABLE where e_username = '" + value + "' order by ap_date";
                }
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public APPOINTMENT_TABLE dataAPPOINTMENT_TABLE(int ap_id) {
            APPOINTMENT_TABLE ap = new APPOINTMENT_TABLE();
            try
            {
                string query = "select * from APPOINTMENT_TABLE where ap_id = " + ap_id;
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    ap.ap_id = Convert.ToInt32(dr["ap_id"].ToString());
                    ap.ap_date = Convert.ToDateTime(dr["ap_date"].ToString());
                    ap.ap_time = dr["ap_time"].ToString();
                    ap.ap_room = dr["ap_room"].ToString();
                    ap.ap_description = dr["ap_description"].ToString();
                    ap.sub_id = dr["sub_id"].ToString();
                    ap.e_username = dr["e_username"].ToString();
                }
            }
            catch {
                ap = null;
            }
            return ap;
        }
    }
}
