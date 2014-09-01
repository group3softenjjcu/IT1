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
    public partial class Admin : System.Web.UI.MasterPage
    {
        EMPLOYEES_TABLE em = new EMPLOYEES_TABLE();
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (Session["e_username"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
            else
            {
                this.LabelUsername.Text = "  " + Session["e_username"].ToString();
                string e_username = Session["e_username"].ToString();
                em = em.dataEMPLOYEES_TABLE(e_username);
                if (em.De_id.Equals("A001"))
                {                    
                    this.PanelEmployee.Visible = false;
                    this.PanelSubject.Visible = false;
                    this.PanelAppointment.Visible = false;
                    this.PanelAlumnus.Visible = false;
                }
                else if (em.De_id.Equals("F001")) {
                    this.PanelEmployee.Visible = false;
                    this.PanelSubject.Visible = false;
                    this.PanelAlumnus.Visible = false;
                    this.PanelService.Visible = false;
                }
                else if (em.De_id.Equals("Admin")) {
                    this.PanelAppointment.Visible = false;
                    this.PanelService.Visible = false;
                }
                else if (em.De_id.Equals("S001")) {
                    this.PanelEmployee.Visible = false;
                    this.PanelSubject.Visible = false;
                    this.PanelAppointment.Visible = false;
                    this.PanelService.Visible = false;
                }

            }
        }
    }
}