using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheLuup.theluupservicereference;

namespace TheLuup
{
    public partial class TheLuupMaster : System.Web.UI.MasterPage
    {
        private Service1Client signinref = new Service1Client();
        string dispimage = "";
        public string useType = "";
        private int uid = 0;
        private Users u;
        protected void Page_Load(object sender, EventArgs e)
        {
            uid = Int32.Parse(Session["User_ID"].ToString());
            u = signinref.getUser(uid);

            useType = u.Type;
            utype.InnerHtml = useType;
            namesurname.InnerHtml = u.Name  + " " + u.Surname;

           

            if(useType.Equals("Partner"))
            {

                int r_id = signinref.getRID(""+u.U_id);
                theluupservicereference.Restuarent restuarent = signinref.getResturant(r_id);

                resnamebar.InnerHtml = restuarent.Name;
                rename.InnerHtml = restuarent.Name;

                if (u.Image.Equals("default.png"))
                {

                    dispimage = "<img src='images/avatar/1.png' width='2' alt='' />";
                }
                else
                {

                    dispimage = "<img src='images/resimages/" + restuarent.Image + "' width='2' alt='' />";
                }

                uimage.InnerHtml = dispimage;

            }
            else
            {
                if (u.Image.Equals("default.png"))
                {

                    dispimage = "<img src='images/avatar/1.png' width='2' alt='' />";
                }
                else
                {

                    dispimage = "<img src='images/userimage/" + u.Image + "' width='2' alt='' />";
                }

                uimage.InnerHtml = dispimage;
            }

        }
    }
}