<%@ Page Language="C#" AutoEventWireup="true" CodeFile="uyeol.aspx.cs" Inherits="uyeol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title></title>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="components/marquee/jquery.marquee.css" rel="stylesheet" />
    <!--[if lt IE 9]><script src="bootstrap/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <link href="css2/newuser.css" rel="stylesheet" />

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.4.1.min.js"></script>
       <script src="https://code.jquery.com/jquery-3.4.1.js"></script>

    <script src="js/ajax-jquery.min.js"></script>
    <script src="js/jquery.min.js"></script>
    <script src="js2/login.js"></script>
 
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        <img src="images/uyekayit.jpg" class="uyeol-backstretch-image" />
        <div class="uyeol-div-logo">
            <div>
                <a href="#">LOGO İMAGE</a>
            </div>
            <div class="uyeol-div-logo-altyazi">Oku-Paylaş-Kazan </div>
        </div>
        <div class="clear"></div>
        <div class="uyeol-div-uyekayit">
            <div class="uyeol-div-logo-altyazi">Üye Ol</div>
            <form action method="post" autocomplete="off">
                <div class="uyeol-div-text">
                    <input id="isim" name="ad_soyad" type="text" class="uyeol-text" placeholder="İsim Soyisim*" />
                </div>

                <div class="uyeol-div-text">
                    <input id="e_mail" name="e_mail" type="text" class="uyeol-text" placeholder="E-Mail Adresi*" />
                </div>

                <div class="uyeol-div-text">
                    <input id="sifre" name="sifre" type="password" class="uyeol-text" placeholder="Şifre*" />
                </div>
                <div class="uyeol-btn">
                    <a id="btnUyeol" type="button" class="uyeol-btn-2">Üye Ol</a>
                   <%-- <a id="btn" onkeypress="$('#btn').click();">TIKLA</a>--%>
                </div>

            </form>
        </div>
    </form>
</body>
</html>
