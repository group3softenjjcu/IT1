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
    public partial class AddAccommodation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageCreate_Click(object sender, ImageClickEventArgs e)
        {
            ACCOMMODATION_TABLE accom = new ACCOMMODATION_TABLE();
            string e_username = Session["e_username"].ToString();
            string address = this.TextAddress.Value;
            string room = this.TextRoom.Value;
            int pax = Convert.ToInt32(this.TextPax.Value.ToString());
            double price = Convert.ToDouble(this.TextPrice.Value.ToString());
            string picture = FileUploadImage.FileName;

            FileUploadImage.SaveAs(Server.MapPath("upload/" + picture));  

            if(accom.insertAccommodation(address, room, pax, price, picture, e_username)){
                Response.Redirect("ViewAccommodation.aspx");
            }
            else{
                MessageBox.Show(e_username + "\n" + address + "\n" + room + "\n" + pax + "\n" + price);
            }
                
        }
    }
}