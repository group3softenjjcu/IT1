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
    public partial class ChangePassword : System.Web.UI.Page
    {
        STUDENTS_TABLE student = new STUDENTS_TABLE();
        Encript encript = new Encript();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                string s_username = Session["s_username"].ToString();
                student = student.dataSTUDENTS_TABLE(s_username);

                this.HiddenFieldUsername.Value = student.S_username;
                this.HiddenFieldPassword.Value = student.S_password;
                this.HiddenFieldFullname.Value = student.S_fullname;
                this.HiddenFieldGender.Value = student.S_gender.ToString();
                this.HiddenFieldPhone.Value = student.S_phone;
                this.HiddenFieldImage.Value = student.S_picture;
                this.HiddenFieldActive.Value = student.S_active.ToString();
            }
        }

        protected void ButtonChange_Click(object sender, EventArgs e)
        {
            string username = this.HiddenFieldUsername.Value;
            string password = this.TextBoxOldPass.Text;
            string newPass = this.TextBoxNewPass.Text;
            string conNewPass = this.TextBoxConfirmNewPass.Text;
            password = encript.GetMD5Hash(password);

            if (password.Equals(this.HiddenFieldPassword.Value) && newPass.Equals(conNewPass))
            {
                if (student.changePassword(username, newPass))
                {
                    MessageBox.Show("Change Successful");
                    Response.Redirect("Profile.aspx");
                }
                else
                {
                    MessageBox.Show("Change Unsuccessful");
                    return;
                }
            }
            else {
                MessageBox.Show("Old password is incorrect, please check it again...");   
            }            
        }
    }
}