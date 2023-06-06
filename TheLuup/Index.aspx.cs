using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheLuup.theluupservicereference;

namespace TheLuup
{
    public partial class Index : System.Web.UI.Page
    {
        private Service1Client signinref = new Service1Client();
        public string useType = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            int uid = Int32.Parse(Session["User_ID"].ToString());
            Users u = signinref.getUser(uid);

            useType = u.Type;
        }
    }
}