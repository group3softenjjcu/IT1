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
    public partial class ViewAppointment : System.Web.UI.Page
    {
        APPOINTMENT_TABLE ap = new APPOINTMENT_TABLE();
        SUBJECTS_TABLE sub = new SUBJECTS_TABLE();
        private PagedDataSource paging = new PagedDataSource();
        private int itemperpage = 4;        

        public int CurrentPageAppointment
        {
            get
            {
                if (ViewState["CurrentPage"] == null)
                    return 0;
                else
                    return Convert.ToInt32(ViewState["CurrentPage"].ToString());
            }
            set
            {
                ViewState["CurrentPage"] = value;
            }
        }

        public int CurrentPageSubject
        {
            get
            {
                if (ViewState["CurrentPage"] == null)
                    return 0;
                else
                    return Convert.ToInt32(ViewState["CurrentPage"].ToString());
            }
            set
            {
                ViewState["CurrentPage"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                AppointmentDB();
                SubjectDB();
                string e_username = Session["e_username"].ToString();
                DataSet subject = sub.employeeSUBJECTS_TABLE(e_username);

                this.DropDownListSubject.DataSource = subject;
                this.DropDownListSubject.DataTextField = "sub_name";
                this.DropDownListSubject.DataValueField = "sub_id";
                this.DropDownListSubject.DataBind();
            }
        }

        public void AppointmentDB()
        {
            string e_username = Session["e_username"].ToString();
            DataSet ds = new DataSet();
            ds = ap.optionalAPPOINTMENT_TABLE(e_username, 2);

            paging.AllowPaging = true;
            paging.DataSource = ds.Tables[0].DefaultView;

            paging.PageSize = itemperpage;
            paging.CurrentPageIndex = CurrentPageAppointment;

            this.ImageButtonNextAp.Enabled = !paging.IsLastPage;
            this.ImageButtonPreAp.Enabled = !paging.IsFirstPage;
            this.ImageButtonFirstAp.Enabled = !paging.IsFirstPage;
            this.ImageButtonLastAp.Enabled = !paging.IsLastPage;

            this.LabelStatusAppointment.Text = (CurrentPageAppointment + 1).ToString() + " / " + paging.PageCount.ToString();

            this.RepeaterAppointment.DataSource = paging;
            this.RepeaterAppointment.DataBind();

            this.LabelAppointment.Text = this.RepeaterAppointment.Items.Count.ToString();
            
        }

        public void SubjectDB() {
            string e_username = Session["e_username"].ToString();
            DataSet ds = new DataSet();
            ds = sub.employeeSUBJECTS_TABLE(e_username);

            paging.AllowPaging = true;
            paging.DataSource = ds.Tables[0].DefaultView;

            paging.PageSize = itemperpage;
            paging.CurrentPageIndex = CurrentPageAppointment;

            this.ImageButtonNextSubject.Enabled = !paging.IsLastPage;
            this.ImageButtonPreSubject.Enabled = !paging.IsFirstPage;
            this.ImageButtonFirstSubject.Enabled = !paging.IsFirstPage;
            this.ImageButtonLastSubject.Enabled = !paging.IsLastPage;

            this.LabelStatusSubject.Text = (CurrentPageSubject + 1).ToString() + " / " + paging.PageCount.ToString();

            this.RepeaterSubject.DataSource = paging;
            this.RepeaterSubject.DataBind();            
        }

        #region Appointment Paging
        protected void ImageButtonFirstAp_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageAppointment = 0;
            AppointmentDB();
        }

        protected void ImageButtonPreAp_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageAppointment--;
            AppointmentDB();
        }

        protected void ImageButtonNextAp_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageAppointment++;
            AppointmentDB();
        }

        protected void ImageButtonLastAp_Click(object sender, ImageClickEventArgs e)
        {
            int Appointmentcount = CurrentPageAppointment = ap.optionalAPPOINTMENT_TABLE(Session["e_username"].ToString(), 2).Tables[0].Rows.Count;
            if (Appointmentcount % 4 == 0)
                CurrentPageAppointment = Appointmentcount / itemperpage - 1;
            else
                CurrentPageAppointment = Appointmentcount / itemperpage;
            AppointmentDB();
        }
        #endregion

        #region Subject by Employee Paging
        protected void ImageButtonFirstSubject_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageSubject = 0;
            SubjectDB();
        }

        protected void ImageButtonPreSubject_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageSubject--;
            SubjectDB();
        }

        protected void ImageButtonNextSubject_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageSubject++;
            SubjectDB();
        }

        protected void ImageButtonLastSubject_Click(object sender, ImageClickEventArgs e)
        {
            int Subjectcount = CurrentPageAppointment = sub.listSUBJECTS_TABLE().Tables[0].Rows.Count;
            if (Subjectcount % 4 == 0)
                CurrentPageAppointment = Subjectcount / itemperpage - 1;
            else
                CurrentPageAppointment = Subjectcount / itemperpage;
            AppointmentDB();
        }
        #endregion



        protected void DropDownListSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sub_id = this.DropDownListSubject.SelectedItem.Value;

            DataSet ds = ap.optionalAPPOINTMENT_TABLE(sub_id, 1);

            this.RepeaterAppointment.DataSource = ds;
            this.RepeaterAppointment.DataBind();

            this.LabelAppointment.Text = this.RepeaterAppointment.Items.Count.ToString();
            if (this.RepeaterAppointment.Items.Count == 0)
                AppointmentDB();
        }

    }
}