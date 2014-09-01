using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database;
using System.Windows.Forms;
using System.Data;

namespace University
{
    public partial class Appointment : System.Web.UI.Page
    {
        APPOINTMENT_TABLE app = new APPOINTMENT_TABLE();

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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                this.HiddenFieldSubject.Value = Request.QueryString["sub_id"].ToString();
                AppointmentDB();
            }
        }

        public void AppointmentDB(){
            DataSet ds = new DataSet();
            ds = app.optionalAPPOINTMENT_TABLE(this.HiddenFieldSubject.Value, 1);

            paging.AllowPaging = true;
            paging.DataSource = ds.Tables[0].DefaultView;

            paging.PageSize = itemperpage;
            paging.CurrentPageIndex = CurrentPageAppointment;

            this.ImageButtonNextDe.Enabled = !paging.IsLastPage;
            this.ImageButtonPreDe.Enabled = !paging.IsFirstPage;
            this.ImageButtonFirstDe.Enabled = !paging.IsFirstPage;
            this.ImageButtonLastDe.Enabled = !paging.IsLastPage;

            this.LabelStatusAppointment.Text = (CurrentPageAppointment + 1).ToString() + " / " + paging.PageCount.ToString();

            this.RepeaterAppointment.DataSource = paging;
            this.RepeaterAppointment.DataBind();    
        }

        #region Appointment Paging
        protected void ImageButtonFirstDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageAppointment = 0;
            AppointmentDB();
        }

        protected void ImageButtonPreDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageAppointment--;
            AppointmentDB();
        }

        protected void ImageButtonNextDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageAppointment++;
            AppointmentDB();
        }

        protected void ImageButtonLastDe_Click(object sender, ImageClickEventArgs e)
        {
            int Departmentcount = CurrentPageAppointment = app.optionalAPPOINTMENT_TABLE(this.HiddenFieldSubject.Value,1).Tables[0].Rows.Count;
            if (Departmentcount % 4 == 0)
                CurrentPageAppointment = Departmentcount / itemperpage - 1;
            else
                CurrentPageAppointment = Departmentcount / itemperpage;
            AppointmentDB();
        }
        #endregion
    }
}