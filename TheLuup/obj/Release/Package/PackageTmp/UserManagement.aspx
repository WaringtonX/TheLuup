<%@ Page Title="" Language="C#" MasterPageFile="~/TheLuupMaster.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="TheLuup.UserManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-body">
            <div class="container-fluid">
                <div class="row page-titles mx-0">
                    <div class="col-sm-6 p-md-0">
                        <div class="welcome-text">
                            <h4>User Management</h4>
                            <span>Register</span>
                        </div>
                    </div>
                    
                </div>
                <!-- row -->

                     <div class="col-xl-12 col-xxl-12">
                        <div class="card">
                           
                            <div class="card-body">
                                <div class="basic-form">
                                    <div>

                                        <div class="form-row">
                                            <div class="form-group col-md-6">
                                                <label>Firt Name</label>
                                                 <asp:TextBox ID="txtname"  class="form-control" MaxLength="50" required="required"  runat="server" placeholder="FirstName"></asp:TextBox>
                                            </div>
                                            
                                            <div class="form-group col-md-6">
                                                <label>Last name</label>
                                                 <asp:TextBox ID="txtlname"  class="form-control" MaxLength="50" required="required"  runat="server" placeholder="Last Name"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-row">
                                            <div class="form-group col-md-6">
                                                <label>Email</label>
                                                   <asp:TextBox ID="txtemail"  class="form-control" MaxLength="50" required="required" TextMode="Email"  runat="server" placeholder="info@yourname.com"></asp:TextBox>
                                            </div>
                                            
                                            <div class="form-group col-md-6">
                                                <label>Password</label>
                                                  <asp:TextBox ID="txtpassword"  class="form-control" MaxLength="50" required="required" TextMode="Password"  runat="server" placeholder="password123&#*"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-row">
                                            <div class="form-group col-md-6">
                                                <label>State</label>               
                                                 <asp:FileUpload class="form-control"   id="customFileLang" required="required"  runat="server" />
                                            </div>
                                            
                                        </div>
                                        <div class="form-group">
                                                <div id="lblstatus" runat="server"></div>    
                                        </div>
                                        
                                         <asp:Button ID="btnAdduser" CssClass="btn btn-primary"  runat="server" Text="Add" OnClick="btnAdduser_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
					</div>


                <div class="col-12">
                        <div class="card">
                            <div class="card-header">
                                <h4 class="card-title">User Profiles</h4>
                            </div>
                            <div class="card-body">
                                <div class="table-responsive">
                                    <table id="example3" class="display" style="min-width: 845px">
                                        <thead>
                                            <tr>
                                                <th></th>
                                                <th>Name</th>
                                                <th>Surame</th>
                                                <th>Email</th>
                                                
                                            </tr>
                                        </thead>
                                        <tbody id="userlist" runat="server">
                                          
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

                   </div>
                </div>
</asp:Content>
