using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace theluupwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        SqlCommand command;
        SqlDataReader reader;
        SqlConnection Connection = new SqlConnection(@"Data Source=SQL5085.site4now.net;Initial Catalog=DB_A6C85C_theluupdata;User Id=DB_A6C85C_theluupdata_admin;Password=Hlawulo@082;");
        //SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Warington\source\repos\TheLuup\theluupwcf\App_Data\theluppdatabase.mdf;Integrated Security=True;");
        string isLogedin = "false";

        public string AddChat(string chatcode,int u_id, int uf_id, string message, string type)
        {
            // creating a sql command line
            string qryStr = "INSERT INTO [LuupChat] VALUES (@chatcode,@u_id,@uf_id,@cmessage,@type)";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@chatcode", chatcode);
            this.command.Parameters.AddWithValue("@u_id", u_id);
            this.command.Parameters.AddWithValue("@uf_id", uf_id);
            this.command.Parameters.AddWithValue("@cmessage", message);
            this.command.Parameters.AddWithValue("@type", type);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();


            return "Chat Added";
        }

        public string AddFreind(string chatcode,int u_id, int uf_id)
        {
            // creating a sql command line
            string qryStr = "INSERT INTO [LuupFreinds] VALUES (@u_id,@uf_id,@chatcode)";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@u_id", u_id);
            this.command.Parameters.AddWithValue("@uf_id", uf_id);
            this.command.Parameters.AddWithValue("@chatcode", chatcode);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();


            return "Freind Added";
        }

        public string AddGroup(string groupdchat, string name, int u_id)
        {
            // creating a sql command line
            string qryStr = "INSERT INTO [GroupCHat] VALUES (@groupdchat,@name,@u_id)";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@groupdchat", groupdchat);;
            this.command.Parameters.AddWithValue("@name", name);
            this.command.Parameters.AddWithValue("@u_id", u_id);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();


            return "Group Added";
        }

        public string AddManagement(string u_id, string r_id)
        {
           // creating a sql command line
            string qryStr = "INSERT INTO [Management] VALUES (@u_id,@r_id)";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@u_id", u_id);
            this.command.Parameters.AddWithValue("@r_id", r_id);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();


            return "Management Added";
        }

        public string AddMenues(int r_id, string fname, string fdescrip, string fimage, decimal fprice)
        {
            //creating a sql command line
            string qryStr = "INSERT INTO [Menues] VALUES (@r_id,@fname,@fdescrip,@fimage,@fprice)";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@r_id", r_id);
            this.command.Parameters.AddWithValue("@fname", fname);
            this.command.Parameters.AddWithValue("@fdescrip", fdescrip);
            this.command.Parameters.AddWithValue("@fimage", fimage);
            this.command.Parameters.AddWithValue("@fprice", fprice);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();


            return "Menues Added";
        }

        public string AddRequest(int u_id, int ur_id, string status)
        {
            // creating a sql command line
            string qryStr = "INSERT INTO [LuupRequest] VALUES (@u_id,@ur_id,@status)";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@u_id", u_id);
            this.command.Parameters.AddWithValue("@ur_id", ur_id);
            this.command.Parameters.AddWithValue("@status", status);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();


            return "Request Added";
        }

        public string AddResturant(string firstname, string location, string image, string coverimage, string rating)
        {
            //creating a sql command line
            string qryStr = "INSERT INTO [Restuarent] VALUES (@firstname,@location,@image,@coverimage,@rating)";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@firstname", firstname);
            this.command.Parameters.AddWithValue("@location", location);
            this.command.Parameters.AddWithValue("@image", image);
            this.command.Parameters.AddWithValue("@coverimage", coverimage);
            this.command.Parameters.AddWithValue("@rating", rating);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();


            return "Restuarent Added";
        }

        public string AddUser(string email, string password, string firstname, string lastname, string image, string type)
        {
            //creating a sql command line
            string qryStr = "INSERT INTO [Users] VALUES (@firstname,@lastname,@email,@password,@image,@type)";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@firstname", firstname);
            this.command.Parameters.AddWithValue("@lastname", lastname);
            this.command.Parameters.AddWithValue("@email", email);
            this.command.Parameters.AddWithValue("@password", Secrecy.HashPassword(password));
            this.command.Parameters.AddWithValue("@image", image);
            this.command.Parameters.AddWithValue("@type", type);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();


            return "User Added";
        }

        public string DeleteManagement(int mmid)
        {
            //creating a sql command line
            string qryStr = "DELETE FROM Management WHERE M_ID=@mmid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@mmid", mmid);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string DeleteMenu(int mid)
        {
            //creating a sql command line
            string qryStr = "DELETE FROM Menues WHERE MU_ID=@mid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@mid", mid);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string DeleteMenus(int rid)
        {
            //creating a sql command line
            string qryStr = "DELETE * FROM Menues WHERE R_ID=@rid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@rid", rid);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string DeleteRequest(int u_id, int ur_id)
        {
            //creating a sql command line
            string qryStr = "DELETE FROM LuupRequest WHERE U_ID=@uid AND UR_ID=@urid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@uid", u_id);
            this.command.Parameters.AddWithValue("@urid", ur_id);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string DeleteResturant(int rid)
        {
            //creating a sql command line
            string qryStr = "DELETE FROM Restuarent WHERE R_ID=@rid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@rid", rid);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string DeleteUser(int uid)
        {
            //creating a sql command line
            string qryStr = "DELETE FROM Users WHERE U_ID=@uid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@uid", uid);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string EditManagement(int mid, string u_id, string r_id)
        {
            //creating a sql command line
            string qryStr = "UPDATE Management SET U_ID=@u_id,R_ID=@r_id WHERE M_ID=@mid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();


            this.command.Parameters.AddWithValue("@mid", mid);
            this.command.Parameters.AddWithValue("@u_id", u_id);
            this.command.Parameters.AddWithValue("@r_id", r_id);


            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string EditMenue(int mid, string fname, string fdescrip, string fimage, decimal fprice)
        {
            //creating a sql command line
            string qryStr = "UPDATE Menues SET MU_FOODNAME=@fname,MU_FOODDES=@fdescrip,MU_FOODIMAGE=@fimage,MU_FOODPRICE=@fprice WHERE MU_ID=@mid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();


            this.command.Parameters.AddWithValue("@mid", mid);
            this.command.Parameters.AddWithValue("@fname", fname);
            this.command.Parameters.AddWithValue("@fdescrip", fdescrip);
            this.command.Parameters.AddWithValue("@fimage", fimage);
            this.command.Parameters.AddWithValue("@fprice", fprice);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string EditResturant(int rid, string firstname, string location, string image, string coverimage, string rating)
        {
            //creating a sql command line
            string qryStr = "UPDATE Restuarent SET R_NAME=@firstname,R_LOCATION=@location,R_IMAGE=@image,R_COVERIMAGE=@coverimage,R_RATING=@rating WHERE R_ID=@rid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();


            this.command.Parameters.AddWithValue("@rid", rid);
            this.command.Parameters.AddWithValue("@firstname", firstname);
            this.command.Parameters.AddWithValue("@location", location);
            this.command.Parameters.AddWithValue("@image", image);
            this.command.Parameters.AddWithValue("@coverimage", coverimage);
            this.command.Parameters.AddWithValue("@rating", rating);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public string EditUser(int uid, string email, string firstname, string lastname, string image, string type)
        {
            //creating a sql command line
            string qryStr = "UPDATE Users SET U_EMAIL=@email,U_NAME=@firstname,U_SURNAME=@lastname,U_IMAGE=@image,U_TYPE=@type WHERE U_ID=@uid";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();


            this.command.Parameters.AddWithValue("@uid", uid);
            this.command.Parameters.AddWithValue("@email", email);
            this.command.Parameters.AddWithValue("@firstname", firstname);
            this.command.Parameters.AddWithValue("@lastname", lastname);
            this.command.Parameters.AddWithValue("@image", image);
            this.command.Parameters.AddWithValue("@type", type);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }

        public List<LChats> getChat(string chatcode)
        {
            string qryStr = "SELECT * FROM [LuupChat] WHERE C_CHARTCODE=@chatcode";

            List<LChats> lChats = new List<LChats>();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@chatcode", chatcode);

            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LChats chats = new LChats();
                    chats.Chatcode = reader["C_CHARTCODE"].ToString();
                    chats.C_id = Int32.Parse(reader["C_ID"].ToString());
                    chats.U_id = Int32.Parse(reader["U_ID"].ToString());
                    chats.Uf_id = Int32.Parse(reader["UF_ID"].ToString());
                    chats.C_messagee  = reader["C_Mesage"].ToString();
                    chats.C_type = reader["C_Type"].ToString();

                    lChats.Add(chats);
                }

            }

            Connection.Close();

            return lChats;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public LFreinds getFreind(int u_id, int uf_id)
        {
            string qryStr = "SELECT * FROM [LuupFreinds] WHERE U_ID=" + u_id + " AND UF_ID=" + uf_id;

            LFreinds freinds = new LFreinds();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    freinds.U_id = Int32.Parse(reader["U_ID"].ToString());
                    freinds.Uf_id = Int32.Parse(reader["UF_ID"].ToString());
                    freinds.Chatcode = reader["LP_CHARTCODE"].ToString();

                 
                }

            }

            Connection.Close();

            return freinds;
        }

        public List<LFreinds> getFreinds(int u_id)
        {
            string qryStr = "SELECT * FROM [LuupFreinds] WHERE U_ID=" + u_id;

            List<LFreinds> lFreinds = new List<LFreinds>();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LFreinds freinds = new LFreinds();
                    freinds.U_id = Int32.Parse(reader["U_ID"].ToString());
                    freinds.Uf_id = Int32.Parse(reader["UF_ID"].ToString());
                    freinds.Chatcode = reader["LP_CHARTCODE"].ToString();

                    lFreinds.Add(freinds);
                }

            }

            Connection.Close();

            return lFreinds;
        }

        public List<GroupChat> getGroup(int uid)
        {
            string qryStr = "SELECT * FROM [GroupCHat] WHERE U_ID=" + uid;

            List<GroupChat> groupChats = new List<GroupChat>();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GroupChat groups = new GroupChat();
                    groups.Gid = Int32.Parse(reader["G_ID"].ToString());
                    groups.Gcode = reader["G_CODE"].ToString();
                    groups.Gname = reader["G_NAME"].ToString();
                    groups.Uid = Int32.Parse(reader["U_ID"].ToString());

                    groupChats.Add(groups);
                }

            }

            Connection.Close();

            return groupChats;
        }

        public Menues getMenue(int mu_id)
        {
            string qryStr = "SELECT * FROM [Menues] WHERE MU_ID=" + mu_id;

            Menues mu = new Menues();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    mu.Mu_id = Int32.Parse(reader["MU_ID"].ToString());
                    mu.R_id = Int32.Parse(reader["R_ID"].ToString());
                    mu.Foodname = reader["MU_FOODNAME"].ToString();
                    mu.Fooddescription = reader["MU_FOODDES"].ToString();
                    mu.Foodimage = reader["MU_FOODIMAGE"].ToString();
                    mu.Price = decimal.Parse(reader["MU_FOODPRICE"].ToString());
                }

            }

            Connection.Close();

            return mu;
        }

        public List<Menues> getMenues(int r_id)
        {
            string qryStr = "SELECT * FROM [Menues] WHERE R_ID=" + r_id;

            List<Menues> menus = new List<Menues>();

           this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Menues mu = new Menues();
                    mu.Mu_id = Int32.Parse(reader["MU_ID"].ToString());
                    mu.R_id = Int32.Parse(reader["R_ID"].ToString());
                    mu.Foodname = reader["MU_FOODNAME"].ToString();
                    mu.Fooddescription = reader["MU_FOODDES"].ToString();
                    mu.Foodimage = reader["MU_FOODIMAGE"].ToString();
                    mu.Price = decimal.Parse(reader["MU_FOODPRICE"].ToString());
                    menus.Add(mu);
                }

            }

            Connection.Close();

            return menus;
        }

        public LRequest getRequest(int u_id, int ur_id)
        {
            string qryStr = "SELECT * FROM [LuupRequest] WHERE U_ID=" + u_id + " AND UR_ID=" + ur_id;

            LRequest request = new LRequest();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    request.Lr_id = Int32.Parse(reader["LR_ID"].ToString());
                    request.U_id = Int32.Parse(reader["U_ID"].ToString());
                    request.Ur_id = Int32.Parse(reader["UR_ID"].ToString());
                    request.Lr_status = reader["LR_STATUS"].ToString();
                }

            }

            Connection.Close();

            return request;
        }

        public List<LRequest> getRequests(int ur_id)
        {
            string qryStr = "SELECT * FROM [LuupRequest] WHERE U_ID=" + ur_id;

            List<LRequest> lRequests = new List<LRequest>();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    LRequest request = new LRequest();

                    request.Lr_id = Int32.Parse(reader["LR_ID"].ToString());
                    request.U_id = Int32.Parse(reader["U_ID"].ToString());
                    request.Ur_id = Int32.Parse(reader["UR_ID"].ToString());
                    request.Lr_status = reader["LR_STATUS"].ToString();
                    lRequests.Add(request);
                }

            }

            Connection.Close();

            return lRequests;
        }

        public Restuarent getResturant(int r_id)
        {
            string qryStr = "SELECT * FROM [Restuarent] WHERE R_ID=" + r_id;

            Restuarent u = new Restuarent();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    u.R_id = Int32.Parse(reader["R_ID"].ToString());
                    u.Name = reader["R_NAME"].ToString();
                    u.Location = reader["R_LOCATION"].ToString();
                    u.Image = reader["R_IMAGE"].ToString();
                    u.Coverimage = reader["R_COVERIMAGE"].ToString();
                    u.Rating = reader["R_RATING"].ToString();
                }

            }

            Connection.Close();

            return u;
        }

        public List<Restuarent> getResturants()
        {
            string qryStr = "SELECT * FROM [Restuarent]";

            List<Restuarent> restuarent = new List<Restuarent>();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Restuarent u = new Restuarent();
                    u.R_id = Int32.Parse(reader["R_ID"].ToString());
                    u.Name = reader["R_NAME"].ToString();
                    u.Location = reader["R_LOCATION"].ToString();
                    u.Image = reader["R_IMAGE"].ToString();
                    u.Coverimage = reader["R_COVERIMAGE"].ToString();
                    u.Rating = reader["R_RATING"].ToString();
                    restuarent.Add(u);
                }

            }

            Connection.Close();

            return restuarent;
        }

        public int getRID(string u_id)
        {
            string qryStr = "SELECT * FROM [Management]";
            int id = 0;

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader["U_ID"].ToString() == u_id)
                    {
                        id = Int32.Parse(reader["R_ID"].ToString());
                    }
                }

            }

            Connection.Close();
            return id;
        }

        public List<GroupChat> getSingleGroup(string groupdchat)
        {
            string qryStr = "SELECT * FROM [GroupCHat] WHERE G_CODE=@chatcode";

            List<GroupChat> groupChats = new List<GroupChat>();


            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();

            this.command.Parameters.AddWithValue("@chatcode", groupdchat);

            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GroupChat groups = new GroupChat();
                    groups.Gid = Int32.Parse(reader["G_ID"].ToString());
                    groups.Gcode = reader["G_CODE"].ToString();
                    groups.Gname = reader["G_NAME"].ToString();
                    groups.Uid = Int32.Parse(reader["U_ID"].ToString());

                    groupChats.Add(groups);
                }

            }

            Connection.Close();

            return groupChats;

        }

        public Users getUser(int id)
        {
            string qryStr = "SELECT * FROM [Users] WHERE U_ID=" + id;

            Users u = new Users();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    u.U_id = Int32.Parse(reader["U_ID"].ToString());
                    u.Email = reader["U_EMAIL"].ToString();
                    u.Password = "";
                    u.Name = reader["U_NAME"].ToString();
                    u.Surname = reader["U_SURNAME"].ToString();
                    u.Image = reader["U_IMAGE"].ToString();
                    u.Type = reader["U_TYPE"].ToString();
                }

            }

            Connection.Close();

            return u;
        }

        public string getUserID(string email)
        {
            string qryStr = "SELECT * FROM [Users]";
            string id = "";

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ((reader["U_EMAIL"].ToString() == email))
                    {
                        id = reader["U_ID"].ToString();
                    }
                }

            }

            Connection.Close();
            return id;
        }

        public List<Users> getUsers()
        {
            string qryStr = "SELECT * FROM [Users]";

             List<Users> us = new List<Users>();

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Users u = new Users();
                    u.U_id = Int32.Parse(reader["U_ID"].ToString());
                    u.Email = reader["U_EMAIL"].ToString();
                    u.Password = "";
                    u.Name = reader["U_NAME"].ToString();
                    u.Surname = reader["U_SURNAME"].ToString();
                    u.Image = reader["U_IMAGE"].ToString();
                    u.Type = reader["U_TYPE"].ToString();
                    us.Add(u);
                }

            }

            Connection.Close();

            return us;
        }

        public string signin(string email, string password)
        {
            string qryStr = "SELECT * FROM [Users]";

            this.command = new SqlCommand(qryStr);
            this.command.CommandType = CommandType.Text;
            this.command.Connection = Connection;
            this.command.Connection.Open();
            this.command.ExecuteNonQuery();
            this.reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if ((reader["U_EMAIL"].ToString() == email) && (reader["U_PASSWORD"].ToString() == Secrecy.HashPassword(password)))
                    {
                        isLogedin = "true";
                    }
                }

            }

            // close connection
            Connection.Close();

            return isLogedin;
        }

        public string UpdateRequestStatus(int u_id, int ur_id,string status)
        {
            //creating a sql command line
            string qryStr = "UPDATE LuupRequest SET LR_STATUS=@status WHERE U_ID=@u_id AND UR_ID=@ur_id";

            // implement a connection
            this.command = new SqlCommand(qryStr);
            this.command.Connection = Connection;
            this.command.CommandType = CommandType.Text;
            this.command.Connection.Open();


            this.command.Parameters.AddWithValue("@u_id", u_id);
            this.command.Parameters.AddWithValue("@ur_id", ur_id);
            this.command.Parameters.AddWithValue("@status", status);

            // execute query 
            this.command.ExecuteNonQuery();

            // close connection
            Connection.Close();

            return "Success";
        }
    }
}
