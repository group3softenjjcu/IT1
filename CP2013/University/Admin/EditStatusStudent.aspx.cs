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
    public partial class EditStatusStudent : System.Web.UI.Page
    {
        STUDENTS_TABLE student = new STUDENTS_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                string s_username = Request.QueryString["s_username"].ToString();
                student = student.dataSTUDENTS_TABLE(s_username);

                string password = student.S_password.ToString();
                string fullname = student.S_fullname.ToString();
                string phone = student.S_phone.ToString();
                bool gender = Convert.ToBoolean(student.S_gender.ToString());
                string picture = student.S_picture.ToString();
                bool active = false;

                if (student.updateSTUDENT_TABLE(s_username, password, fullname, phone, gender, picture, active))
                    Response.Redirect("ViewStudents.aspx");
            }
        }
    }
}