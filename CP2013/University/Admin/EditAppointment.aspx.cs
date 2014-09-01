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
    public partial class UpdateAppointment : System.Web.UI.Page
    {
        APPOINTMENT_TABLE ap = new APPOINTMENT_TABLE();
        SUBJECTS_TABLE sub = new SUBJECTS_TABLE();
        EMPLOYEES_TABLE em = new EMPLOYEES_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                int ap_id = Convert.ToInt32(Request.QueryString["ap_id"].ToString());
                this.HiddenFieldID.Value = ap_id.ToString();
                ap = ap.dataAPPOINTMENT_TABLE(ap_id);

                this.LabelSubject.Text = ap.Sub_id.ToString();
                this.TextBoxDate.Text = ap.Ap_date.ToString("MM-dd-yyyy");
                this.TextTime.Value = ap.Ap_time.ToString();
                this.TextRoom.Value = ap.Ap_room.ToString();
                this.TextDescription.Value = ap.Ap_description.ToString();
            }
        }

        protected void ImageButtonCreate_Click(object sender, ImageClickEventArgs e)
        {
            int ap_id = Convert.ToInt32(this.HiddenFieldID.Value.ToString());
            DateTime date = Convert.ToDateTime(this.TextBoxDate.Text);
            string time = this.TextTime.Value;
            string room = this.TextRoom.Value;
            string description = this.TextDescription.Value;
            string sub_id = this.LabelSubject.Text;
            string e_username = Session["e_username"].ToString();

            if (ap.updateAPPOINTMENT_TABLE(ap_id, date, time, room, description, sub_id, e_username))
                Response.Redirect("ViewAppointment.aspx");
            else
                MessageBox.Show(ap_id + "\n" + date + "\n" + time + "\n" + room + "\n" + description + "\n");
        }

        protected void CalendarDate_SelectionChanged(object sender, EventArgs e)
        {
            this.TextBoxDate.Text = CalendarDate.SelectedDate.ToString("MM-dd-yyyy");
        }
    }
}