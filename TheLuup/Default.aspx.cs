using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FireSharp.Config;
using FireSharp.Interfaces;
using TheLuup.theluupservicereference;

namespace TheLuup
{
    public partial class Login : System.Web.UI.Page
    {

        private Service1Client signinref = new Service1Client();
        private string dis = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void btnlogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpassword.Text;

            if (signinref.signin(email, password) == "true")
            {
                string id = signinref.getUserID(email);
                Session["User_ID"] = id;
                Response.Redirect("Index.aspx");
            }
            else
            {
                dis = "<div class='alert alert-danger' role='alert'>" +
                        "username or password is incorect!" +
                     "</div>";
            }
            errordis.InnerHtml = dis;
        }
    }
}