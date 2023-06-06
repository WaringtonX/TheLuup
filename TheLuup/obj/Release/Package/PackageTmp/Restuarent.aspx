<%@ Page Title="" Language="C#" MasterPageFile="~/TheLuupMaster.Master" AutoEventWireup="true" CodeBehind="Restuarent.aspx.cs" Inherits="TheLuup.Restuarent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="content-body">
            <div class="container-fluid">
                <div class="row page-titles mx-0">
                    <div class="col-sm-6 p-md-0">
                        <div class="welcome-text">
                            <h4>Restuarent</h4>
                            <span>Add</span>
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
                                                <label>Name</label>
                                                 <asp:TextBox ID="txtname"  class="form-control" MaxLength="50" required="required"  runat="server" placeholder="res name"></asp:TextBox>
                                            </div>
                                            
                                            <div class="form-group col-md-6">
                                                <label>Address</label>
                                                 <asp:TextBox ID="txtadress"  class="form-control" MaxLength="50" required="required"  runat="server" placeholder="12 johannesburg, Bree"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="form-row">
                                            <div class="form-group col-md-6">
                                                <label>Restuarent Logo</label>               
                                                 <asp:FileUpload class="form-control"   id="customFileLang" required="required"  runat="server" />
                                            </div>
                                              
                                            <div class="form-group col-md-6">
                                                <label>Restuarent Cover Image</label>               
                                                 <asp:FileUpload class="form-control"   id="rescoverUpload" required="required"  runat="server" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                                <div id="lblstatus" runat="server"></div>    
                                        </div>
                                        
                                         <asp:Button ID="btnAdd" CssClass="btn btn-primary"  runat="server" Text="Add" OnClick="btnAdd_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
					</div>

                <div class="col-xl-12 col-xxl-12"">
						<div class="card">
							<div class="card-header border-0">
								<div>
									<h4 class="card-title mb-2">Restuarent List</h4>
									<p class="mb-0 fs-14">Partners</p>
								</div>
							</div>
							<div class="card-body px-0 pt-0 pb-2">
								<div class="widget-media trending-menus">
									<ul class="timeline">
										<div id="relist" runat="server"></div>
										
									</ul>
								</div>
							</div>
						</div>
					</div>


                   </div>
                </div>
</asp:Content>
