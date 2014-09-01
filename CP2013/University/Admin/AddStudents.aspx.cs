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
    public partial class AddStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageCreate_Click(object sender, ImageClickEventArgs e)
        {
            STUDENTS_TABLE stu = new STUDENTS_TABLE();

            string username = this.TextUsername.Value;
            string fullname = this.TextName.Value;
            string password = "123456";
            string phone = this.TextPhone.Value;
            bool gender = Convert.ToBoolean(this.RadioButtonListGender.SelectedItem.Value);
            string picture = FileUploadImage.FileName;

            FileUploadImage.SaveAs(Server.MapPath("upload/student/" + picture));
            bool active = this.CheckBoxActive.Checked;

            if (stu.insertSTUDENTS_TABLE(username, password, fullname, phone, gender, picture, active))
            {
                Response.Redirect("ViewStudents.aspx");
            }
            else
                MessageBox.Show(username + "\n" + password + "\n" + fullname + "\n" + phone + "\n" + gender + "\n" + active);
        }
    }
}