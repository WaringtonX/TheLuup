<%@ Page Title="" Language="C#" MasterPageFile="~/TheLuupMaster.Master" AutoEventWireup="true" CodeBehind="Managements.aspx.cs" Inherits="TheLuup.Managements" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-body">
            <div class="container-fluid">
                <div class="row page-titles mx-0">
                    <div class="col-sm-6 p-md-0">
                        <div class="welcome-text">
                            <h4>Mangement</h4>
                            <span>User</span>
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
                                                <label>User Name</label>
                                                  <asp:DropDownList ID="selectname" class="form-control"  runat="server" OnSelectedIndexChanged="selectusers_SelectedIndexChangedDevice">  
                                                  <asp:ListItem Enabled="true" Text="Select Name" Value="-1"></asp:ListItem>
                                                 </asp:DropDownList>
                                            </div>
                                            
                                            <div class="form-group col-md-6">
                                                <label>Restuarent  Name</label>
                                                   <asp:DropDownList ID="selectres" class="form-control"  runat="server" OnSelectedIndexChanged="selectrestuarent_SelectedIndexChangedDevice">  
                                                  <asp:ListItem Enabled="true" Text="Select Restuarent" Value="-1"></asp:ListItem>
                                          </asp:DropDownList>
                                            </div>
                                        </div>
                                       
                                        <div class="form-group">
                                                <div id="lblstatus" runat="server"></div>    
                                        </div>
                                        
                                         <asp:Button ID="btnAddm" CssClass="btn btn-primary"  runat="server" Text="Add" OnClick="btnAddm_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
					</div>

                
                   </div>
                </div>
</asp:Content>
