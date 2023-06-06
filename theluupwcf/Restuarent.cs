using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace theluupwcf
{
    public class Restuarent
    {
        private int r_id;
        private string name;
        private string location;
        private string image;
        private string coverimage;
        private string rating;

        public Restuarent()
        {

        }

        public Restuarent(int r_id, string name, string location, string image, string coverimage, string rating)
        {
            this.R_id = r_id;
            this.Name = name;
            this.Location = location;
            this.Image = image;
            this.Coverimage = coverimage;
            this.Rating = rating;
        }

        public int R_id { get => r_id; set => r_id = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string Image { get => image; set => image = value; }
        public string Coverimage { get => coverimage; set => coverimage = value; }
        public string Rating { get => rating; set => rating = value; }
    }
}