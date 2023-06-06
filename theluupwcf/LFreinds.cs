using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace theluupwcf
{
    public class LFreinds
    {
        private int lp_id;
        private int u_id;
        private int uf_id;
        private string chatcode;
        public LFreinds()
        {

        }

        public LFreinds(int lp_id, int u_id, int uf_id, string chatcode)
        {
            this.Lp_id = lp_id;
            this.U_id = u_id;
            this.Uf_id = uf_id;
            this.Chatcode = chatcode;
        }

        public int Lp_id { get => lp_id; set => lp_id = value; }
        public int U_id { get => u_id; set => u_id = value; }
        public int Uf_id { get => uf_id; set => uf_id = value; }
        public string Chatcode { get => chatcode; set => chatcode = value; }
    }
}