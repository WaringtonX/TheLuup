using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace theluupwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string signin(string email, string password);

        [OperationContract]     
        string AddUser(string email, string password, string firstname, string lastname, string image, string type);

        [OperationContract]      
        Users getUser(int id);

        [OperationContract]      
        List<Users> getUsers();

        [OperationContract]
        string getUserID(string email);

        [OperationContract]
        string DeleteUser(int uid);

        [OperationContract]
        string EditUser(int uid,string email,string firstname, string lastname, string image, string type);


        // Resturant  
        //********************************************//
        //******************Resturant MANAGEMENT**************************//

        [OperationContract]
        string AddResturant(string firstname, string location, string image,string coverimage,string rating);

        [OperationContract]    
        Restuarent getResturant(int r_id);

        [OperationContract]       
        List<Restuarent> getResturants();

        [OperationContract]
        string EditResturant(int rid,string firstname, string location, string image, string coverimage, string rating);

        [OperationContract]
        string DeleteResturant(int rid);

        // Management  
        //********************************************//
        //******************Management MANAGEMENT**************************//

        [OperationContract]       
        string AddManagement(string u_id, string r_id);

        [OperationContract]     
        int  getRID(string u_id);

        [OperationContract]
        string EditManagement(int mid,string u_id, string r_id);

        [OperationContract]
        string DeleteManagement(int mmid);


        // Menues  
        //********************************************//
        //******************Menues MANAGEMENT**************************//

        [OperationContract]        
        string AddMenues(int r_id, string fname, string fdescrip, string fimage,decimal fprice);

        [OperationContract]   
        Menues getMenue(int mu_id);

        [OperationContract]     
        List<Menues> getMenues(int r_id);

        [OperationContract]
        string EditMenue(int mid,string fname, string fdescrip, string fimage, decimal fprice);

        [OperationContract]
        string DeleteMenu(int mid);

        [OperationContract]
        string DeleteMenus(int rid);


        // Luup  Request  
        //********************************************//
        //******************Menues MANAGEMENT**************************//

        [OperationContract]        
        string AddRequest(int u_id, int ur_id, string status);

        [OperationContract]
        string DeleteRequest(int u_id, int ur_id);

        [OperationContract]        
        LRequest getRequest(int u_id, int ur_id);

        [OperationContract]       
        List<LRequest> getRequests(int ur_id);

        [OperationContract]      
        string UpdateRequestStatus(int u_id,int ur_id,string status);


        // Luup  Freinds  
        //********************************************//
        //******************Menues MANAGEMENT**************************//

        [OperationContract]      
        string AddFreind(string chatcode,int u_id, int uf_id);

        [OperationContract]
        List<LFreinds> getFreinds(int u_id);

        [OperationContract]
        LFreinds getFreind(int u_id, int uf_id);

        // Luup  Chat  
        //********************************************//
        //******************Menues MANAGEMENT**************************//

        [OperationContract]
        string AddChat(string chatcode, int u_id, int uf_id,string message,string type);

        [OperationContract]
        List<LChats> getChat(string chatcode);



        // Group  Chat  
        //********************************************//
        //******************Menues MANAGEMENT**************************//

        [OperationContract]
        string AddGroup(string groupdchat, string name, int u_id);

        [OperationContract]
        List<GroupChat> getGroup(int uid);

        [OperationContract]
        List<GroupChat> getSingleGroup(string groupdchat);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);





        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
