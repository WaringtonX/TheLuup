using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheLuup.theluupservicereference;

namespace TheLuup
{
    public partial class Managements : System.Web.UI.Page
    {
        private Service1Client rest = new Service1Client();
        private string alert = "";
        private List<Users> users = new List<Users>();
        private List<theluupservicereference.Restuarent> restuarents = new List<theluupservicereference.Restuarent>();
        private string U_ID = "";
        private string R_ID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            users.AddRange(rest.getUsers());
            restuarents.AddRange(rest.getResturants());

            foreach(Users us in users)
            {
                selectname.Items.Add(new ListItem(us.Name +" "+ us.Surname, "" + us.U_id));
            }

            foreach (theluupservicereference.Restuarent re in restuarents)
            {
                selectres.Items.Add(new ListItem(re.Name, "" + re.R_id));
            }
        }

        protected void btnAddm_Click(object sender, EventArgs e)
        {
            if (rest.AddManagement(U_ID,R_ID) == "Management Added")
            {
                setStatus();
            }
        }

        protected void selectusers_SelectedIndexChangedDevice(object sender, EventArgs e)
        {
            string pos = selectname.Items[selectname.SelectedIndex].Value;
            U_ID = pos;
        }

        protected void selectrestuarent_SelectedIndexChangedDevice(object sender, EventArgs e)
        {
            string pos = selectres.Items[selectres.SelectedIndex].Value;
            R_ID = pos;
        }

        public void setStatus()
        {
            alert = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                            "<span class='alert-text'>Partner has been succesfully assigned to restuarent.</span>" +
                          "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                            "<span aria-hidden='true'>&times;</span>" +
                          "</button>" +
                        "</div>";

            lblstatus.InnerHtml = alert;
        }
    }
}