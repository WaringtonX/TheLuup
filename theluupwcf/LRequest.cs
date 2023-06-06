using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace theluupwcf
{
    public class LRequest
    {
        private int lr_id;
        private int u_id;
        private int ur_id;
        private string lr_status;

        public LRequest()
        {

        }

        public LRequest(int lr_id, int u_id, int ur_id, string lr_status)
        {
            this.Lr_id = lr_id;
            this.U_id = u_id;
            this.Ur_id = ur_id;
            this.Lr_status = lr_status;
        }

        public int Lr_id { get => lr_id; set => lr_id = value; }
        public int U_id { get => u_id; set => u_id = value; }
        public int Ur_id { get => ur_id; set => ur_id = value; }
        public string Lr_status { get => lr_status; set => lr_status = value; }
    }
}