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
    public partial class Profile : System.Web.UI.Page
    {
        STUDENTS_TABLE student = new STUDENTS_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                if (Session["s_username"] == null)
                {
                    MessageBox.Show("You must sign up if you want to view your profile");
                    Response.Redirect("StudentLogin.aspx");
                }                                 
            }
        }
    }
}