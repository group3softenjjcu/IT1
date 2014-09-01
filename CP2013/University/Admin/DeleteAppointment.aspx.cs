using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;
using System.Windows.Forms;

namespace University.Admin
{
    public partial class DeleteAppointment : System.Web.UI.Page
    {
        APPOINTMENT_TABLE ap = new APPOINTMENT_TABLE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                int ap_id = Convert.ToInt32(Request.QueryString["ap_id"].ToString());
                if (ap_id != null) {
                    if (ap.deleteAPPOINTMENT_TABLE(ap_id))
                        Response.Redirect("ViewAppointment.aspx");
                }
            }
        }
    }
}