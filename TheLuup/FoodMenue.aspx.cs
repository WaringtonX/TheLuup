using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TheLuup.theluupservicereference;

namespace TheLuup
{
    public partial class FoodMenue : System.Web.UI.Page
    {
        private string menueList = "";
        private Service1Client rest = new Service1Client();
        private string alert = "";
        private int uid = 0;
        private int r_id = 0;
        private Users u;
       List<Menues> menus = new List<Menues>();
        protected void Page_Load(object sender, EventArgs e)
        {

            uid = Int32.Parse(Session["User_ID"].ToString());
            u = rest.getUser(uid);

            r_id = rest.getRID("" + u.U_id);

            menus.AddRange(rest.getMenues(r_id));

            if (!IsPostBack)
            {
                LoadMenu();
            }
        }

        private void LoadMenu()
        {
            foreach(Menues mu in menus)
            {

                menueList += "<div class='col-lg-12 col-xl-6'>" +
      "                        <div class='card'>" +
      "                            <div class='card-body'>" +
        "                                <div class='row m-b-30'>" +
          "                                    <div class='col-md-5 col-xxl-12'>" +
                  "                                        <div class='new-arrival-product mb-4 mb-xxl-4 mb-md-0'>" +
                               "                                            <div class='new-arrivals-img-contnent'>" +
                                    "                                                <img class='img-fluid' src='images/foodimages/"+mu.Foodimage+"' alt=''>" +
                                          "                                            </div>" +
                                          "                                        </div>" +
                                          "                                    </div>" +
                                          "                                    <div class='col-md-7 col-xxl-12'>" +
                                                  "                                        <div class='new-arrival-content position-relative'>" +
                                                       "                                            <h4><a href='#' class='text-black'>"+mu.Foodname+"</a></h4>" +
                                                             "                                            <p class='price'>R"+mu.Price+"</p>" +
                                                             "                                            <p>Availability: <span class='item'> In stock <i class='fa fa-check-circle text-success'></i></span></p>" +
                                                                 "                                            <p>Product code: <span class='item'>0</span> </p>" +
                                                                 "                                             <p class='text-content'>"+mu.Fooddescription+"</p>" +
                                                                 "                                        </div>" +
                                                                 "                                    </div>" +
                                                                 "                                </div>" +
                                                                 "                            </div>" +
                                                                               "<div class='dropdown'><button class='btn btn-primary tp-btn-light sharp' type='button' data-toggle='dropdown'><span class='fs--1'><svg xmlns='http://www.w3.org/2000/svg' xmlns:xlink='http://www.w3.org/1999/xlink' width='18px' height='18px' viewBox='0 0 24 24' version='1.1'><g stroke='none' stroke-width='1' fill='none' fill-rule='evenodd'><rect x='0' y='0' width='24' height='24'></rect><circle fill='#000000' cx='5' cy='12' r='2'></circle><circle fill='#000000' cx='12' cy='12' r='2'></circle><circle fill='#000000' cx='19' cy='12' r='2'></circle></g></svg></span></button>" +
"                                                        <div class='dropdown-menu dropdown-menu-right border py-0'>" +
"                                                            <div class='py-2'><a class='dropdown-item'  href='EditMenu.aspx?MU_ID=" + mu.Mu_id + "'>Edit</a><a class='dropdown-item text-danger' href='DeleteMenu.aspx?MU_ID=" + mu.Mu_id + "'>Delete</a></div>" +
"                                                        </div>" +
"                                                    </div>" +
                                                                 "                        </div>" +                                                 
                                                                 "					</div>";

            }

            foodmenulist.InnerHtml = menueList;
        }
    }
}