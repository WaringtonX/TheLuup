using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace theluupwcf
{
    public class GroupChat
    {
        private int gid;
        private string gcode;
        private string gname;
        private int uid;

        public GroupChat()
        {

        }

        public GroupChat(int gid, string gcode, string gname, int uid)
        {
            this.Gid = gid;
            this.Gcode = gcode;
            this.Gname = gname;
            this.Uid = uid;
        }

        public int Gid { get => gid; set => gid = value; }
        public string Gcode { get => gcode; set => gcode = value; }
        public string Gname { get => gname; set => gname = value; }
        public int Uid { get => uid; set => uid = value; }
    }
}