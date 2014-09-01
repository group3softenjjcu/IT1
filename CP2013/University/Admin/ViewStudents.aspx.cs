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
    public partial class ViewStudents : System.Web.UI.Page
    {
        STUDENTS_TABLE student = new STUDENTS_TABLE();

        private PagedDataSource paging = new PagedDataSource();
        private int itemperpage = 4;

        public int CurrentPageStudent
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
                StudentDB();
            }
        }

        public void StudentDB()
        {            
            DataSet ds = new DataSet();
            ds = student.listSTUDENTS_TABLE();

            paging.AllowPaging = true;
            paging.DataSource = ds.Tables[0].DefaultView;

            paging.PageSize = itemperpage;
            paging.CurrentPageIndex = CurrentPageStudent;

            this.ImageButtonNextStudent.Enabled = !paging.IsLastPage;
            this.ImageButtonPreStudent.Enabled = !paging.IsFirstPage;
            this.ImageButtonFirstStudent.Enabled = !paging.IsFirstPage;
            this.ImageButtonLastStudent.Enabled = !paging.IsLastPage;

            this.LabelStatusStudent.Text = (CurrentPageStudent + 1).ToString() + " / " + paging.PageCount.ToString();

            this.RepeaterStudent.DataSource = paging;
            this.RepeaterStudent.DataBind();            
        }

        #region Student Paging
        protected void ImageButtonFirstStudent_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageStudent = 0;
            StudentDB();
        }

        protected void ImageButtonPreStudent_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageStudent--;
            StudentDB();
        }

        protected void ImageButtonNextStudent_Click(object sender, ImageClickEventArgs e)
        {
            CurrentPageStudent++;
            StudentDB();
        }

        protected void ImageButtonLastStudent_Click(object sender, ImageClickEventArgs e)
        {
            int Studentcount = CurrentPageStudent = student.listSTUDENTS_TABLE().Tables[0].Rows.Count;
            if (Studentcount % 4 == 0)
                CurrentPageStudent = Studentcount / itemperpage - 1;
            else
                CurrentPageStudent = Studentcount / itemperpage;
            StudentDB();
        }
        #endregion
    }
}