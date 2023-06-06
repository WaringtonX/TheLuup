using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheLuup.theluupservicereference;

namespace TheLuup
{
    public partial class mManagement : System.Web.UI.Page
    {
        private Service1Client rest = new Service1Client();
        private string alert = "";
        private int uid = 0;
        private int r_id = 0;
        private Users u;

        protected void Page_Load(object sender, EventArgs e)
        {
            uid = Int32.Parse(Session["User_ID"].ToString());
            u = rest.getUser(uid);

            r_id = rest.getRID("" + u.U_id);
            theluupservicereference.Restuarent restuarent = rest.getResturant(r_id);
        }

        protected void btnAddmenu_Click(object sender, EventArgs e)
        {
            string fname = txtfName.Text;
            string fdescription = txtfdescript.Text;
            string fprice = txtprice.Text;
            string logo = "";

            CultureInfo culture = new CultureInfo("en-US");
            decimal pprice = Convert.ToDecimal(fprice, culture);

            if (customFileLang.HasFile)
            {
                try
                {
                    logo = Path.GetFileName(customFileLang.FileName);
                    customFileLang.SaveAs(Server.MapPath("~/images/foodimages/") + logo);
                    //statuslebal.Text = "Upload Status : File uploaded.";                 
                }
                catch (Exception ex)
                {
                    // statuslebal.Text = "Upload Status : The File Could not be uploaded. The Following error occured " + ex.Message;
                }
            }

            if (rest.AddMenues(r_id,fname,fdescription,logo,pprice) == "Menues Added")
            {
                setStatus();

            }
        }

        public void setStatus()
        {
            alert = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                            "<span class='alert-text'>Menu Added!.</span>" +
                          "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                            "<span aria-hidden='true'>&times;</span>" +
                          "</button>" +
                        "</div>";

            lblstatus.InnerHtml = alert;
        }
    }
}