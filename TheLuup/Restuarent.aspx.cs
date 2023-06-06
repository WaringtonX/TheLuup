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
    public partial class Restuarent : System.Web.UI.Page
    {
        private Service1Client rest = new Service1Client();
        private string alert = "";
        private string Reslist = "";
        private List<theluupservicereference.Restuarent> res = new List<theluupservicereference.Restuarent>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRes();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string loacation = txtadress.Text;
            string logo = "";
            string recover = "";

            if (customFileLang.HasFile)
            {
                try
                {
                    logo = Path.GetFileName(customFileLang.FileName);
                    customFileLang.SaveAs(Server.MapPath("~/images/resimages/") + logo);
                    //statuslebal.Text = "Upload Status : File uploaded.";                 
                }
                catch (Exception ex)
                {
                    // statuslebal.Text = "Upload Status : The File Could not be uploaded. The Following error occured " + ex.Message;
                }
            }

            if (rescoverUpload.HasFile)
            {
                try
                {
                    recover = Path.GetFileName(customFileLang.FileName);
                    rescoverUpload.SaveAs(Server.MapPath("~/images/rescover/") + recover);
                    //statuslebal.Text = "Upload Status : File uploaded.";                 
                }
                catch (Exception ex)
                {
                    // statuslebal.Text = "Upload Status : The File Could not be uploaded. The Following error occured " + ex.Message;
                }
            }

            if (rest.AddResturant(name, loacation, logo, recover, "0") == "Restuarent Added") {
                setStatus();
            }

            
        }

        public void LoadRes()
        {          
            res.AddRange(rest.getResturants());

            foreach(theluupservicereference.Restuarent r in res)
            {
                Reslist += "<li>" +
                                "											<div class='timeline-panel'>" +
                                "												<div class='media mr-3'>" +
                                "													<img alt='image' width='90' src='/images/resimages/"+r.Image+"'>" +
                                "												</div>" +
                                "												<div class='media-body'>" +
                                "													<h5 class='mb-3'><a href='#' class='text-black font-w600'>"+r.Name+"</a></h5>" +
                                "									<div class='d-flex justify- content-between align-items-center'>" +
                                "														<p class=mb-0 fs-14'>"+r.Location+"</p>" +
                                "													</div>" +
                                "												</div>" +
                                "											</div>" +
                                "										</li>";
            }

            relist.InnerHtml = Reslist;
        }

        public void setStatus()
        {
            alert = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                            "<span class='alert-text'> Restuarent was successfully.</span>" +
                          "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                            "<span aria-hidden='true'>&times;</span>" +
                          "</button>" +
                        "</div>";

            lblstatus.InnerHtml = alert;
        }
    }
}