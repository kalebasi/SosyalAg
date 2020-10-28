<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kitaplik.aspx.cs" Inherits="Kitaplik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <script src="js2/kitaplik.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">

        <div class="row row-offcanvas row-offcanvas-right">
            <div class="col-xs-12 col-sm-9">
                <div style="margin-top: 10px;">
                    <p class="pull-right visible-xs">
                        <button type="button" class="btn btn-primary btn-xs" data-toggle="offcanvas">Toggle nav</button>
                    </p>
                    <div class="card">
                        <div class="card-header">KİTAPLIK</div>
                        <div class="card-body">
                            <div class="row" id="Kitaplik_Liste">
                             
                                <%-- <a href="kitap.aspx">
                                <div class="card kitaplik-div">
                                  <img src="images/golgelerin-efendisi-ilk-yillar-.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-İlk Yıllar-2</h4>
                                    </div>
                                </div>
                                    </a>
                                <!--/.col-xs-6.col-lg-4-->
                                <div class="card kitaplik-div">
                                    <img src="images/john-flanagan.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-Gorlan Harabeleri</h4>
                                    </div>
                                </div>
                                <!--/.col-xs-6.col-lg-4-->
                                <div class="card kitaplik-div">
                                    <img src="images/golgelerin-efendisi-ilk-yillar-.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-İlk Yıllar-2</h4>
                                    </div>
                                </div>
                                <!--/.col-xs-6.col-lg-4-->
                                <div class="card kitaplik-div">
                                    <img src="images/john-flanagan.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-Gorlan Harabeleri</h4>
                                    </div>
                                </div>
                                <!--/.col-xs-6.col-lg-4-->
                                <div class="card kitaplik-div">
                                    <img src="images/golgelerin-efendisi-ilk-yillar-.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-İlk Yıllar-2</h4>
                                    </div>
                                </div>
                                <!--/.col-xs-6.col-lg-4-->
                                <div class="card kitaplik-div">
                                    <img src="images/john-flanagan.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-Gorlan Harabeleri</h4>
                                    </div>
                                </div>
                                <!-- -->
                                <div class="card kitaplik-div">
                                    <img src="images/golgelerin-efendisi-ilk-yillar-.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-İlk Yıllar-2</h4>
                                    </div>
                                </div>
                                <div class="card kitaplik-div">
                                    <img src="images/john-flanagan.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-Gorlan Harabeleri</h4>
                                    </div>
                                </div>
                                <div class="card kitaplik-div">
                                    <img src="images/golgelerin-efendisi-ilk-yillar-.jpg" class="kitaplik-resim-div" />
                                    <div class="card-body">
                                        <h4 class="card-title kitaplik-ad-div">Gölgelerin Efendisi-İlk Yıllar-2</h4>
                                    </div>
                                </div>--%>
                            </div>
                            <!--/row-->
                        </div>
                    </div>

                </div>
            </div>
            <!--/.col-xs-12.col-sm-9-->

            <div class="col-xs-6 col-sm-3 sidebar-offcanvas" id="sidebar" style="margin-top: 10px;">
                <div class="card">
                    <div class="card-header">KİTAP TÜRLERİ</div>
                    <div class="card-body">
                        <div class="list-group" id="KitapTürleri_Liste">
                        </div>
                        <%--<div id="lblkitaptürid" runat="server"></div>
                           <button id="btnlistele">TIKLA</button>--%>
                    </div>
                </div>
            </div>
            <!--/.sidebar-offcanvas-->
        </div>
        <!--/row-->
      
    </div>
    <!--/.container-->
      
      <div class="section last">
                        <div style="float: left; width: 50%;" id="tür">
                          <%--  <div id="lblKitapTürID" runat="server">1</div>--%>
                        </div>
                        <div style="float: right; width: 50%;" align="right">
                        </div>
                    </div>
                    <div class="clear" style="display: none">
                    </div>
</asp:Content>

