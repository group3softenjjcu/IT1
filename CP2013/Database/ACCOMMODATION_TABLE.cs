using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class ACCOMMODATION_TABLE
    {
        #region properties
        private int accom_id;
        private string accom_address;
        private string accom_room;
        private int accom_pax;
        private double accom_price;
        private string accom_picture;
        private string e_username;

        
        public int Accom_id
        {
            get { return accom_id; }
            set { accom_id = value; }
        }        

        public string Accom_address
        {
            get { return accom_address; }
            set { accom_address = value; }
        }        

        public string Accom_room
        {
            get { return accom_room; }
            set { accom_room = value; }
        }
        
        public int Accom_pax
        {
            get { return accom_pax; }
            set { accom_pax = value; }
        }        

        public double Accom_price
        {
            get { return accom_price; }
            set { accom_price = value; }
        }
        
        public string Accom_picture
        {
            get { return accom_picture; }
            set { accom_picture = value; }
        }
        
        public string E_username
        {
            get { return e_username; }
            set { e_username = value; }
        }
        #endregion

        public ACCOMMODATION_TABLE() { }

        public ACCOMMODATION_TABLE(int accom_id, string accom_address, string accom_room, int accom_pax, double accom_price, string accom_picture, string e_username) {
            this.accom_id = accom_id;
            this.accom_address = accom_address;
            this.accom_room = accom_room;
            this.accom_pax = accom_pax;
            this.accom_price = accom_price;
            this.accom_picture = accom_picture;
            this.e_username = e_username;
        }

        public bool insertAccommodation(string accom_address, string accom_room, int accom_pax, double accom_price, string accom_picture, string e_username) {
            bool kq = true;
            try
            {
                string query = "insert into ACCOMMODATION_TABLE values('{0}', '{1}', {2}, {3}, '{4}', '{5}')";
                query = string.Format(query, accom_address, accom_room, accom_pax, accom_price, accom_picture, e_username);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool updateAccomodation(int accom_id, string accom_address, string accom_room, int accom_pax, double accom_price, string accom_picture, string e_username) {
            bool kq = true;
            try
            {
                string query = "update ACCOMMODATION_TALBE set accom_address = '{0}', accom_room = '{1}', accom_pax = {2}, accom_price = {3}, accom_picture = '{4}', e_username = '{5}' where accom_id = {6}";
                query = string.Format(query, accom_address, accom_room, accom_pax, accom_price, accom_picture, e_username, accom_id);
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public bool deleteAccommodation(int accom_id) {
            bool kq = true;
            try
            {
                string query = "delete ACCOMMODATION_TABLE where accom_id = " + accom_id;
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                kq = cmd.ExecuteNonQuery() > 0;
            }
            catch {
                kq = false;
            }
            return kq;
        }

        public DataSet listACCOMMODATION_TABLE() {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from ACCOMMODATION_TABLE order by accom_price";
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public DataSet employeeACCOMMODATION_TABLE(string e_username) {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from ACCOMMODATION_TABLE where e_username = '{0}' order by accom_price";
                query = string.Format(query, e_username);
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnectToDatabase.Getconnect());
                sda.Fill(ds);
            }
            catch {
                ds = null;
            }
            return ds;
        }

        public ACCOMMODATION_TABLE dataACCOMMODATION_TABLE(int accom_id) {
            ACCOMMODATION_TABLE accom = new ACCOMMODATION_TABLE();
            try
            {
                string query = "select * from ACCOMMODATION_TABLE where accom_id = " + accom_id;
                SqlCommand cmd = new SqlCommand(query, ConnectToDatabase.Getconnect());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    accom.accom_id = Convert.ToInt32(dr["accom_id"].ToString());
                    accom.accom_address = dr["accom_address"].ToString();
                    accom.accom_room = dr["accom_room"].ToString();
                    accom.accom_pax = Convert.ToInt32(dr["accom_pax"].ToString());
                    accom.accom_price = Convert.ToDouble(dr["accom_price"].ToString());
                    accom.accom_picture = dr["accom_picture"].ToString();
                    accom.e_username = dr["e_username"].ToString();
                }
            }
            catch {
                accom = null;
            }
            return accom;
        }        
    }
}
