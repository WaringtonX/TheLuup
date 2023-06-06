<%@ Page Title="" Language="C#" MasterPageFile="~/TheLuupMaster.Master" AutoEventWireup="true" CodeBehind="FoodMenue.aspx.cs" Inherits="TheLuup.FoodMenue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--**********************************
            Content body start
        ***********************************-->
        <div class="content-body">
            <div class="container-fluid">
                <div class="row page-titles mx-0">
                    <div class="col-sm-6 p-md-0">
                        <div class="welcome-text">
                            <h4>Our Menu</h4>
                            <p class="mb-0">Taste</p>
                        </div>
                    </div>
                   
                </div>
                <div class="row" id="foodmenulist" runat="server">
                    
                </div>
				
				
				
            </div>
        </div>
        <!--**********************************
            Content body end
        ***********************************-->
				
</asp:Content>
