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
    public partial class ViewAccommodation : System.Web.UI.Page
    {
        private PagedDataSource paging = new PagedDataSource();
        private int itemperpage = 6;
        ACCOMMODATION_TABLE accom = new ACCOMMODATION_TABLE();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                Data();
            }
        }

        public int CurrentPage
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

        public void Data()
        {
            DataSet ds = new DataSet();
            ds = accom.listACCOMMODATION_TABLE();

            paging.AllowPaging = true;
            paging.DataSource = ds.Tables[0].DefaultView;

            paging.PageSize = itemperpage;
            paging.CurrentPageIndex = CurrentPage;

            this.ImageButtonNext.Enabled = !paging.IsLastPage;
            this.ImageButtonPre.Enabled = !paging.IsFirstPage;
            this.ImageButtonFirst.Enabled = !paging.IsFirstPage;
            this.ImageButtonLast.Enabled = !paging.IsLastPage;

            this.LabelStatus.Text = (CurrentPage + 1).ToString() + " / " + paging.PageCount.ToString();

            this.DataListAccommodation.DataSource = paging;
            this.DataListAccommodation.DataBind();
        }

        #region paging
        protected void ImageButtonFirst_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage = 0;
            Data();
        }

        protected void ImageButtonPre_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage--;
            Data();
        }

        protected void ImageButtonNext_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPage++;
            Data();
        }

        protected void ImageButtonLast_Click(object sender, ImageClickEventArgs e)
        {
            int Accomcount = CurrentPage = accom.listACCOMMODATION_TABLE().Tables[0].Rows.Count;
            if (Accomcount % 6 == 0)
                CurrentPage = Accomcount / itemperpage - 1;
            else
                CurrentPage = Accomcount / itemperpage;
            Data();
        }
        #endregion
    }
}