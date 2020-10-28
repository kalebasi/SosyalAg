<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Giriş Yap</title>
    <link href="../bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../bootstrap/css/signin.css" rel="stylesheet" />

    <!--[if lt IE 9]><script src="bootstrap/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="../bootstrap/js/ie-emulation-modes-warning.js"></script>
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <link href="../css/style.css" rel="stylesheet" />
     
</head>
<body class="LoginBg">
    <form id="form1" runat="server">
        <div id="alertMessage" class="error" style="display: none;">
        </div>
        <div style="display: none;">
            <div id="pop_up1">
                <div id="popup_icerik"></div>
            </div>
            <a href="#popup_icerik" class="fancybox">Popup aç</a>
        </div>
        <div style="display: none" id="lblPopupID" runat="server"></div>
        <div class="container">
            <div id="login" style="opacity: 1;">
                <div class="ribbon">
                </div>
                <div class="inner">
                    <div class="logo" style="opacity: 1; top: 1%; position: relative; display: block;">
                       <%-- <img src="../images/logo.png" alt="Online Call Center" />--%>
                    </div>
                    <div class="form-signin">
                        <div id="LoginModel">
                            <input type="text" id="username_id" class="form-control" placeholder="Kullanıcı Adı" onkeypress="if (event.keyCode == 13) { $('#btnGirisYap').click(); return false; }" />
                            <div style="position: relative;" class="sifregoster">
                                <input type="password" id="password" class="form-control masked glyphicon glyphicon-eye-open icon-bar " placeholder="Parola" onkeypress="if (event.keyCode == 13) { $('#btnGirisYap').click(); return false; }" />
                                <i class="glyphicon glyphicon-eye-open " id="eye"></i>
                            </div>
                            <%--<label class="col-sm-6 input-group-prepend" style="padding-top: 5px; padding-left: 32px; font-size: 12pt;">Beni Hatırla</label>--%>
                          <%--  <div class="row" style="margin-bottom: 20px; margin-left: 26px;" id="rememberMe">
                                <div class="col-sm-6 ">
                                    <input type="checkbox" class="on_off_checkbox largeXL" id="chckRemember" value="1" tabindex="10" runat="server" />
                                </di--%>
                            </div>
                        </div>
                        <a class="btn btn-lg btn-primary btn-block" href="#" id="btnGirisYap">Giriş Yap</a>
                    </div>
                </div>
            </div>
            <div class="clear">
            </div>
            <div class="shadow">
            </div>
        </div>
        <!-- /container -->
        <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
       <script src="../bootstrap/js/ie10-viewport-bug-workaround.js"></script>
        <script type="text/javascript" src="../js/jquery.min.js"></script>
        <script type="text/javascript" src="../js/jquery.cookie.js"></script>
        <script type="text/javascript" src="../components/effect/jquery-jrumble.js"></script>
        <script type="text/javascript" src="../components/ui/jquery.ui.min.js"></script>
        <script type="text/javascript" src="../components/tipsy/jquery.tipsy.js"></script>
        <script type="text/javascript" src="../components/checkboxes/iphone.check.js"></script>
        <script type="text/javascript" src="../components/validationEngine/jquery.validationEngine.js"></script>
        <script type="text/javascript" src="../components/validationEngine/jquery.validationEngine-en.js"></script>
        <script type="text/javascript" src="../components/placeholder/jquery.placeholder.js"></script>
        <script type="text/javascript" src="js/login.js"></script>
        <script src="../components/fancybox/jquery.fancybox.js"></script>
      
    </form>
</body>
</html>
