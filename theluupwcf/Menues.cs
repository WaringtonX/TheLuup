using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace theluupwcf
{
    public class Menues
    {

        private int mu_id;
        private int r_id;
        private string foodname;
        private string fooddescription;
        private string foodimage;
        private decimal price;

        public Menues()
        {

        }

        public Menues(int mu_id, int r_id, string foodname, string fooddescription, string foodimage, decimal price)
        {
            this.Mu_id = mu_id;
            this.R_id = r_id;
            this.Foodname = foodname;
            this.Fooddescription = fooddescription;
            this.Foodimage = foodimage;
            this.Price = price;
        }

        public int Mu_id { get => mu_id; set => mu_id = value; }
        public int R_id { get => r_id; set => r_id = value; }
        public string Foodname { get => foodname; set => foodname = value; }
        public string Fooddescription { get => fooddescription; set => fooddescription = value; }
        public string Foodimage { get => foodimage; set => foodimage = value; }
        public decimal Price { get => price; set => price = value; }
    }
}