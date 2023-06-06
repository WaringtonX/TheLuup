using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace theluupwcf
{
    public class LChats
    {
        private int c_id;
        private string chatcode;
        private int u_id;
        private int uf_id;
        private string c_messagee;
        private string c_type;

        public LChats()
        {

        }

        public LChats(int c_id, string chatcode, int u_id, int uf_id, string c_messagee, string c_type)
        {
            this.C_id = c_id;
            this.Chatcode = chatcode;
            this.U_id = u_id;
            this.Uf_id = uf_id;
            this.C_messagee = c_messagee;
            this.C_type = c_type;
        }

        public int C_id { get => c_id; set => c_id = value; }
        public string Chatcode { get => chatcode; set => chatcode = value; }
        public int U_id { get => u_id; set => u_id = value; }
        public int Uf_id { get => uf_id; set => uf_id = value; }
        public string C_messagee { get => c_messagee; set => c_messagee = value; }
        public string C_type { get => c_type; set => c_type = value; }
    }
}