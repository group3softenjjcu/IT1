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
    public partial class ViewSubject : System.Web.UI.Page
    {
        SUB_STU_TABLE sub_stu = new SUB_STU_TABLE();        
        private PagedDataSource paging = new PagedDataSource();
        private int itemperpage = 4;

        public int CurrentPageDepartment
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
                string username = Session["s_username"].ToString();
                this.HiddenFieldUsername.Value = username;
                Sub_StuDB();
            }
        }

        public void Sub_StuDB()
        {
            DataSet ds = new DataSet();
            string username = this.HiddenFieldUsername.Value;
            ds = sub_stu.listSUB_STU_TABLE(username, 2);

            paging.AllowPaging = true;
            paging.DataSource = ds.Tables[0].DefaultView;

            paging.PageSize = itemperpage;
            paging.CurrentPageIndex = CurrentPageDepartment;

            this.ImageButtonNextDe.Enabled = !paging.IsLastPage;
            this.ImageButtonPreDe.Enabled = !paging.IsFirstPage;
            this.ImageButtonFirstDe.Enabled = !paging.IsFirstPage;
            this.ImageButtonLastDe.Enabled = !paging.IsLastPage;

            this.LabelStatusSubject.Text = (CurrentPageDepartment + 1).ToString() + " / " + paging.PageCount.ToString();

            this.RepeaterSubject.DataSource = paging;
            this.RepeaterSubject.DataBind();
           
        }

        #region Subject Paging
        protected void ImageButtonFirstDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageDepartment = 0;
            Sub_StuDB();
        }

        protected void ImageButtonPreDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageDepartment--;
            Sub_StuDB();
        }

        protected void ImageButtonNextDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageDepartment++;
            Sub_StuDB();
        }

        protected void ImageButtonLastDe_Click(object sender, ImageClickEventArgs e)
        {
            int Subjectcount = CurrentPageDepartment = sub_stu.listSUB_STU_TABLE(this.HiddenFieldUsername.Value,2).Tables[0].Rows.Count;
            if (Subjectcount % 4 == 0)
                CurrentPageDepartment = Subjectcount / itemperpage - 1;
            else
                CurrentPageDepartment = Subjectcount / itemperpage;
            Sub_StuDB();
        }
        #endregion
    }
}