using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;
using System.Windows.Forms;

namespace University
{
    public partial class BookAppointment : System.Web.UI.Page
    {
        AP_DETAIL_TABLE detail = new AP_DETAIL_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                string username = Session["s_username"].ToString();
                int ap_id = Convert.ToInt32(Request.QueryString["appointment"].ToString());
                if (detail.insertAP_DETAIL_TABLE(username, ap_id, true))
                {
                    MessageBox.Show("Appointment is booked successfully");
                    Response.Redirect("Profile.aspx");
                }
                else {
                    MessageBox.Show("unsuccessful");
                    Response.Redirect("Profile.aspx");
                }
            }
        }
    }
}