<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link href="css2/login.css" rel="stylesheet" />
    <link href="css2/style2.css" rel="stylesheet" />
    <script src="js2/login.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <form>
        <img src="images/login2.jpg" class="login-background-image"/>
        <div class="wrapper fadeInDown">
            <div id="formContent">
                <!-- Tabs Titles -->

                <!-- Icon -->
                <div class="fadeIn first">
                    <%-- <img src="http://danielzawadzki.com/codepen/01/icon.svg" id="icon" alt="User Icon" />--%>
                </div>

                <!-- Login Form -->
                 
                    <input type="text" id="email" class="fadeIn second"   placeholder="E-Mail"/>
                    <input type="password" id="password" class="fadeIn third"  placeholder="Password"/>
                    <input type="submit" id="btnGirisYap" class="fadeIn fourth" onclick="OturumAc()" value="GİRİS"/>
                   
                 
           

                <!-- Remind Passowrd -->
                <div id="formFooter">
                    <%--<a class="underlineHover" href="#">Forgot Password?</a>--%>
                </div>

            </div>
        </div>
    </form>
</asp:Content>

