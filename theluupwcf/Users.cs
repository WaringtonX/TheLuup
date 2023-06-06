using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace theluupwcf
{
    public class Users
    {
        private int u_id;
        private string name;
        private string surname;
        private string email;
        private string password;
        private string image;
        private string type;

        public Users()
        {

        }

        public Users(int u_id, string name, string surname, string email, string password, string image, string type)
        {
            this.U_id = u_id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Image = image;
            this.Type = type;
        }

        public int U_id { get => u_id; set => u_id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Image { get => image; set => image = value; }
        public string Type { get => type; set => type = value; }
    }
}