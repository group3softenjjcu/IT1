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
    public partial class DepartmentManagement : System.Web.UI.Page
    {
        DEPARTMENT_TABLE de = new DEPARTMENT_TABLE();

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
                DepartmentDB();
            }
        }

        public void DepartmentDB()
        {
            DataSet ds = new DataSet();
            ds = de.listDEPARTMENT_TABLE();

            paging.AllowPaging = true;
            paging.DataSource = ds.Tables[0].DefaultView;

            paging.PageSize = itemperpage;
            paging.CurrentPageIndex = CurrentPageDepartment;

            this.ImageButtonNextDe.Enabled = !paging.IsLastPage;
            this.ImageButtonPreDe.Enabled = !paging.IsFirstPage;
            this.ImageButtonFirstDe.Enabled = !paging.IsFirstPage;
            this.ImageButtonLastDe.Enabled = !paging.IsLastPage;

            this.LabelStatusDepartment.Text = (CurrentPageDepartment + 1).ToString() + " / " + paging.PageCount.ToString();

            this.RepeaterDepartment.DataSource = paging;
            this.RepeaterDepartment.DataBind();

            //this.LabelStatusDepartment.Text = this.RepeaterDepartment.Items.Count.ToString();
        }

        #region Department Paging
        protected void ImageButtonFirstDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageDepartment = 0;
            DepartmentDB();
        }

        protected void ImageButtonPreDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageDepartment--;
            DepartmentDB();
        }

        protected void ImageButtonNextDe_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageDepartment++;
            DepartmentDB();
        }

        protected void ImageButtonLastDe_Click(object sender, ImageClickEventArgs e)
        {
            int Departmentcount = CurrentPageDepartment = de.listDEPARTMENT_TABLE().Tables[0].Rows.Count;
            if (Departmentcount % 4 == 0)
                CurrentPageDepartment = Departmentcount / itemperpage - 1;
            else
                CurrentPageDepartment = Departmentcount / itemperpage;
            DepartmentDB();
        }
        #endregion
    }
}