<%@ Page Title="" Language="C#" MasterPageFile="~/TheLuupMaster.Master" AutoEventWireup="true" CodeBehind="mManagement.aspx.cs" Inherits="TheLuup.mManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-body">
            <div class="container-fluid">
                <div class="row page-titles mx-0">
                    <div class="col-sm-6 p-md-0">
                        <div class="welcome-text">
                            <h4>Menu Management</h4>
                            <span>add menu</span>
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
                                            <div class="form-group col-md-12">
                                                <label>Food Name</label>
                                                 <asp:TextBox ID="txtfName"  class="form-control" MaxLength="50" required="required"  runat="server" placeholder="Food Name"></asp:TextBox>
                                            </div>
                                            
                                          
                                        </div>
                                        <div class="form-row">
                                             <div class="form-group col-md-12">
                                                <label>Fodod Description</label>
                                                 <asp:TextBox ID="txtfdescript"  class="form-control" TextMode="MultiLine"  required="required"  runat="server" placeholder="Food Description"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-row">
                                            <div class="form-group col-md-6">
                                                <label>Food Image</label>               
                                                 <asp:FileUpload class="form-control"   id="customFileLang" required="required"  runat="server" />
                                            </div>
                                            
                                            <div class="form-group col-md-6">
                                                <label>Food Price</label>
                                                  <asp:TextBox ID="txtprice"  class="form-control" MaxLength="50" required="required"  runat="server" placeholder="eg 20.35"></asp:TextBox>
                                            </div>
                                            
                                        </div>
                                        
                                        <div class="form-group">
                                                <div id="lblstatus" runat="server"></div>    
                                        </div>
                                        
                                         <asp:Button ID="btnAddmenu" CssClass="btn btn-primary"  runat="server" Text="Add" OnClick="btnAddmenu_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
					</div>


                

                   </div>
                </div>
</asp:Content>
