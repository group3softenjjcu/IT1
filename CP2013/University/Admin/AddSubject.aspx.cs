using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;
using System.Windows.Forms;
using System.Data;

namespace University.Admin
{
    public partial class AddSubject : System.Web.UI.Page
    {
        SUBJECTS_TABLE sub = new SUBJECTS_TABLE();        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                EMPLOYEES_TABLE em = new EMPLOYEES_TABLE();
                DataSet lecturer = em.listEMPByDepartment("F001");

                this.DropDownListLecturer.DataSource = lecturer;
                this.DropDownListLecturer.DataTextField = "e_fullname";
                this.DropDownListLecturer.DataValueField = "e_username";
                this.DropDownListLecturer.DataBind();
            }
        }

        protected void ImageCreate_Click(object sender, ImageClickEventArgs e)
        {
            string sub_id = this.TextID.Value;
            string sub_name = this.TextName.Value;
            string sub_description = this.TextDescription.Value;

            string e_username = this.DropDownListLecturer.SelectedItem.Value;

            if (sub.insertSUBJECTS_TABLE(sub_id, sub_name, sub_description, e_username))
                Response.Redirect("ViewSubject.aspx");
            else
                MessageBox.Show(sub_id + "\n" + sub_name + "\n" + sub_description + "\n" + e_username);
        }

        
    }
}