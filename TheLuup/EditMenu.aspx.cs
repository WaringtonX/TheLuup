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
    public partial class EditMenu : System.Web.UI.Page
    {
        private Service1Client rest = new Service1Client();
        Menues m = new Menues();
        private int MU_ID = 0;
        private string logo = "";
        CultureInfo culture = new CultureInfo("en-US");
        decimal pprice;
        protected void Page_Load(object sender, EventArgs e)
        {
            MU_ID = Convert.ToInt32(Request.QueryString["MU_ID"]);

            if (!IsPostBack)
            {
                LoadMenu(MU_ID);
            }
        }

        private void LoadMenu(int mU_ID)
        {
            m = rest.getMenue(mU_ID);
           
            mtxtfName.Text = m.Foodname;
            mtxtfdescript.Text = m.Fooddescription;
            mtxtprice.Text = "" + m.Price;
            logo = m.Foodimage;
        }

        protected void btnAddmenu_Click(object sender, EventArgs e)
        {
            string fname = mtxtfName.Text;
            string fdescription = mtxtfdescript.Text;
            string fprice = mtxtprice.Text;

            pprice = Convert.ToDecimal(fprice, culture);

            if (mcustomFileLang.HasFiles)
            {
                try
                {
                    logo = Path.GetFileName(mcustomFileLang.FileName);
                    mcustomFileLang.SaveAs(Server.MapPath("~/images/foodimages/") + logo);

                    if (rest.EditMenue(MU_ID, fname, fdescription, logo, pprice) == "Success")
                    {
                        Response.Redirect("FoodMenue.aspx");
                    }
                }
                catch (Exception ex)
                {
                }

            }
            else
            {
                m = rest.getMenue(MU_ID);
                logo = m.Foodimage;
                if (rest.EditMenue(MU_ID, fname, fdescription, logo, pprice) == "Success")
                {
                    Response.Redirect("FoodMenue.aspx");
                }
            }
        }
    }
}