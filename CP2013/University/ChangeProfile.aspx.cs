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
    public partial class ChangeProfile : System.Web.UI.Page
    {
        STUDENTS_TABLE student = new STUDENTS_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                string username = Session["s_username"].ToString();
                student = student.dataSTUDENTS_TABLE(username);

                this.TextBoxPhone.Text = student.S_phone;
                this.TextBoxFullname.Text = student.S_fullname;
                this.ImagePicture.ImageUrl = "Admin/upload/student/" + student.S_picture.ToString();
                this.HiddenFieldImage.Value = student.S_picture;
                this.HiddenFieldUsername.Value = username;
                this.HiddenFieldPassword.Value = student.S_password.ToString();
                this.HiddenFieldGender.Value = student.S_gender.ToString();
                this.HiddenFieldActive.Value = student.S_active.ToString();
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string username = this.HiddenFieldUsername.Value;
            string password = this.HiddenFieldPassword.Value;
            string phone = this.TextBoxPhone.Text;
            string fullname = this.TextBoxFullname.Text;
            string image = this.HiddenFieldImage.Value;
            if (this.FileUploadImage.FileName != "")
            {
                image = this.FileUploadImage.FileName;
                FileUploadImage.SaveAs(Server.MapPath("Admin/upload/student/" + image));
            }
            bool gender = Convert.ToBoolean(this.HiddenFieldGender.Value);
            bool active = Convert.ToBoolean(this.HiddenFieldActive.Value);

            if (student.updateSTUDENT_TABLE(username, password, fullname, phone, gender, image, active)) {
                MessageBox.Show("Update successful");
                Response.Redirect("Profile.aspx");
            }
            else{
                MessageBox.Show("Update unsuccessful, please check again!!");
                return;
            }
        }
    }
}