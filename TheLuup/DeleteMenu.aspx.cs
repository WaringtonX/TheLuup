using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheLuup.theluupservicereference;

namespace TheLuup
{
    public partial class DeleteMenu : System.Web.UI.Page
    {
        private int MU_ID = 0;
        private Service1Client rest = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            MU_ID = Convert.ToInt32(Request.QueryString["MU_ID"]);
            if (rest.DeleteMenu(MU_ID) == "Success")
            {
                Response.Redirect("FoodMenue.aspx");
            }
        }
    }
}