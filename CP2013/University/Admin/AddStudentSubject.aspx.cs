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
    public partial class AddStudentSubject : System.Web.UI.Page
    {
        STUDENTS_TABLE stu = new STUDENTS_TABLE();
        SUBJECTS_TABLE sub = new SUBJECTS_TABLE();
        SUB_STU_TABLE subjectStudent = new SUB_STU_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                DataSet listSubject = sub.listSUBJECTS_TABLE();

                this.DropDownListSubject.DataSource = listSubject;
                this.DropDownListSubject.DataTextField = "sub_name";
                this.DropDownListSubject.DataValueField = "sub_id";
                this.DropDownListSubject.DataBind();

                DataSet listStudent = stu.listSTUDENTS_TABLE();

                this.DropDownListStudent.DataSource = listStudent;
                this.DropDownListStudent.DataTextField = "s_fullname";
                this.DropDownListStudent.DataValueField = "s_username";
                this.DropDownListStudent.DataBind();
            }
        }

        protected void ImageCreate_Click(object sender, ImageClickEventArgs e)
        {
            string sub_id = this.DropDownListSubject.SelectedItem.Value;
            string s_username = this.DropDownListStudent.SelectedItem.Value;

            if (subjectStudent.insertSUB_STU_TABLE(sub_id, s_username))
                MessageBox.Show("successful");
        }
    }
}