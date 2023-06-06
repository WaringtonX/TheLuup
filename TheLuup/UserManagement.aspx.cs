using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheLuup.theluupservicereference;

namespace TheLuup
{
    public partial class UserManagement : System.Web.UI.Page
    {
        private Service1Client rest = new Service1Client();
        private string alert = "";
        private string Reslist = "";
        private List<Users> u = new List<Users>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUsers();
            }
        }

        protected void btnAdduser_Click(object sender, EventArgs e)
        {
            string firstname = txtname.Text;
            string lastname = txtlname.Text;
            string email = txtemail.Text;
            string password = txtpassword.Text;
            string logo = "";
            string type = "Partner";

            if (customFileLang.HasFile)
            {
                try
                {
                    logo = Path.GetFileName(customFileLang.FileName);
                    customFileLang.SaveAs(Server.MapPath("~/images/userimage/") + logo);
                    //statuslebal.Text = "Upload Status : File uploaded.";                 
                }
                catch (Exception ex)
                {
                    // statuslebal.Text = "Upload Status : The File Could not be uploaded. The Following error occured " + ex.Message;
                }
            }

            if (rest.AddUser(email,password,firstname,lastname,logo,type) == "User Added")
            {
                setStatus();

            }

        }

        public void LoadUsers()
        {
            u.AddRange(rest.getUsers());

          
            foreach(Users us in u)
            {
                string image = "";
                if(us.Image.Equals("default.png"))
                {
                    image = "<img class='rounded-circle' src='images/avatar/1.png' width='35' height='35' alt='' />";
                }else
                {
                    image = "<img class='rounded-circle' src='images/userimage/" + us.Image+ "' width='35' height='35' alt='' />";
                }

                Reslist += "                              <tr>" +
            "                                                <td>"+image+"</td>" +
            "                                                <td>"+us.Name+"</td>" +
            "                                                <td>"+us.Surname+"</td>" +
            "                                                <td>"+us.Email+"</td>" +
            "                                            </tr>";
            }

            userlist.InnerHtml = Reslist;
        }

        public void setStatus()
        {
            alert = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                            "<span class='alert-text'>User Registered.</span>" +
                          "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                            "<span aria-hidden='true'>&times;</span>" +
                          "</button>" +
                        "</div>";

            lblstatus.InnerHtml = alert;
        }
    }
}