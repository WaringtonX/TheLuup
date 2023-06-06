<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TheLuup.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width,initial-scale=1">
    <title>The Luup</title>
    <!-- Favicon icon -->
   <link rel="icon" type="image/png" sizes="16x16" href="images/favicon.png">
   <link href="css/style.css" rel="stylesheet">
   
</head>
<body>

    <form id="form1" runat="server">
        <div class="authincation h-100" style="padding-top:100px;">
        <div class="container h-100">
            <div class="row justify-content-center h-100 align-items-center">
                <div class="col-md-6">
                    <div class="authincation-content">
                        <div class="row no-gutters">
                            <div class="col-xl-12">
                                <div class="auth-form">
                                    <h4 class="text-center mb-4">Sign in your account</h4>
                                    <div>
                                        <div class="form-group">
                                            <label class="mb-1"><strong>Email</strong></label>
                                            <asp:TextBox ID="txtemail"  class="form-control" MaxLength="50" required="required" TextMode="Email"  runat="server" placeholder="info@yourname.com"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <label class="mb-1"><strong>Password</strong></label>
                                            <asp:TextBox ID="txtpassword"  class="form-control" MaxLength="50" required="required" TextMode="Password"  runat="server" placeholder="password123&#*"></asp:TextBox>
                                        </div>
                                        <div class="form-row d-flex justify-content-between mt-4 mb-2">
                                            <div class="form-group">
                                               <div class="custom-control custom-checkbox ml-1">
													<input type="checkbox" class="custom-control-input" id="basic_checkbox_1"/>
													<label class="custom-control-label" for="basic_checkbox_1">Remember my preference</label>
												</div>
                                            </div>
                                            <div class="form-group">
                                                <div id="errordis" runat="server"></div>       
                                            </div>
                                        </div>
                                        <div class="text-center">
                                            <asp:Button ID="btnlogin" CssClass="btn btn-primary btn-block"  runat="server" Text="Log In" OnClick="btnlogin_Click" />
                                        </div>
                                    </div>
                                   
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>

    <!--**********************************
        Scripts
    ***********************************-->
    <!-- Required vendors -->
    <script src="vendor/global/global.min.js"></script>
	<script src="vendor/bootstrap-select/dist/js/bootstrap-select.min.js"></script>
    <script src="js/custom.min.js"></script>
    <script src="js/deznav-init.js"></script>

    <!-- ************************************************************ 
                 FIREBASE WEB API
     ************************************************************** -->

    <!-- The core Firebase JS SDK is always required and must be listed first -->
<script src="https://www.gstatic.com/firebasejs/8.2.1/firebase-app.js"></script>

<!-- TODO: Add SDKs for Firebase products that you want to use
     https://firebase.google.com/docs/web/setup#available-libraries -->
<script src="https://www.gstatic.com/firebasejs/8.2.1/firebase-analytics.js"></script>

<script>
  // Your web app's Firebase configuration
  // For Firebase JS SDK v7.20.0 and later, measurementId is optional
  var firebaseConfig = {
    apiKey: "AIzaSyBhVrfAsop-JH8NX3i5AUgThi4-7om7Els",
    authDomain: "theluup-55c24.firebaseapp.com",
    projectId: "theluup-55c24",
    storageBucket: "theluup-55c24.appspot.com",
    messagingSenderId: "370110889683",
    appId: "1:370110889683:web:a11fef0f3cf6f01c8ede26",
    measurementId: "G-NM6SQHFKKL"
  };
  // Initialize Firebase
  firebase.initializeApp(firebaseConfig);
  firebase.analytics();
</script>

    <script src="js/FirebaseIndex.js"></script>

</body>
</html>
