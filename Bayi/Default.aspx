<%@ Page Title="" Language="C#" MasterPageFile="~/Bayi/Bayi.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Bayi_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src='<%= "js/Default.js?ver="+DateTime.Now.ToShortDateString()  %>' type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <%-- <link href="<%= ResolveClientUrl("~/components/marquee/jquery.marquee.css") %>" rel="stylesheet" />--%>
 <%--   <%
      KullaniciModel.BayiYetkili bayiObject = new KullaniciModel.BayiYetkili();
      bayiObject = HttpContext.Current.Session["bayiObject"] as KullaniciModel.BayiYetkili;
    %>--%>
    <div style="display: none;">
        <div id="pop_up1">
            <div id="popup_icerik"></div>
        </div>
        <a href="#popup_icerik" class="fancybox">Popup aç</a>
    </div>
    <div style="display: none" id="lblPopupID" runat="server"></div>
    <div class="row">
        <div class="col-sm-3 col-md-3">
            <div class="panel-group acordion" id="accordion">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" class="accordion-toggle" href="#collapseOne"><span class="fas fa-globe blue"></span>Galeri Yönetimi</a>
                        </h4>
                    </div>
                    <div id="collapseOne" class="panel-collapse collapse in">
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <span class="fas fa-home blue "></span><a href="#">Anasayfa</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-car blue"></span><a href="Kullanicilar.aspx">Galeri</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-address-card blue"></span><a href="#">Hakkımızda </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-comments blue"></span><a href="#">İletişim</a>
                                    </td>
                                </tr>
                           
                             <%--  <tr>
                                    <td>
                                        <span class="fas fa-users blue"></span><a href="Kullanicilar.aspx?k=0">Kullanıcılar</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-phone blue"></span><a href="SirketTelefonIslemleri.aspx">Şirket Telefon İşlemleri</a>
                                    </td>
                                </tr>

                               <tr>
                                    <td>
                                        <span class="fas fa-rss blue"></span><a href="SirketInteraktifIslemleri.aspx">Şirket İnteraktif İşlemleri</a>
                                    </td>
                                </tr>
                               <tr>
                                    <td>
                                        <span class="fas fa-tasks blue"></span><a href="AnketListesi.aspx">Kullanıcı Anket Listesi</a>
                                    </td>
                                </tr>
                             <tr>
                                    <td>
                                        <span class="far fa-window-restore blue"></span><a href="SirketPopup.aspx">Şirket Pop-up Ekranı</a>
                                    </td>
                                </tr>
                              <tr>
                                    <td>
                                        <span class="glyphicon glyphicon-cog blue"></span><a href="SirketSistemAyarlari.aspx?s=0">Şirket Ayarları</a>
                                    </td>
                                </tr>
                                       <tr>
                                    <td>
                                        <span class="fas fa-barcode blue"></span><a href="LogRaporlari.aspx">Log Raporları</a>
                                    </td>
                                </tr>--%>
                            </table>
                        </div>
                    </div>
                </div>
                <%--<div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" class="accordion-toggle" href="#collapseModul"><span class="fas fa-cogs blue"></span>SİSTEM YÖNETİMİ </a>
                        </h4>
                    </div>
                    <div id="collapseModul" class="panel-collapse collapse">
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <span class="fas fa-th-large blue"></span><a href="MenuListesi.aspx">Menü Listesi</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-puzzle-piece blue"></span><a href="ModulListesi.aspx">Modül Listesi</a>
                                    </td>
                                </tr>

                            </table>
                        </div>
                    </div>
                </div>--%>
                <%--<div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" class="accordion-toggle" href="#collapseBorclu"><span class="fas fa-bookmark blue"></span>BORÇ /BOÇLU İŞLEMLERİ </a>
                        </h4>
                    </div>
                    <div id="collapseBorclu" class="panel-collapse collapse">
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <span class="fas fa-file-excel blue"></span><a href="SirketDosyaAtamalari.aspx">Şirket Dosya Atamaları</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-file-excel blue"></span><a href="ExcelDosyaAtama.aspx">Kullanıcı Dosya Atamaları</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-file blue"></span><a href="MusteriListesi.aspx">Dosya Arama</a>
                                    </td>
                                </tr>

                                <tr>
                                    <td>
                                        <span class="fas fa-balance-scale blue"></span><a href="SikayetRaporlari.aspx">Şikayet Raporları</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-credit-card blue"></span><a href="TahsilatRaporu.aspx">Tahsilat Raporu</a>
                                    </td>
                                </tr>

                            </table>
                        </div>
                    </div>
                </div>--%>
                <%--<%  }
                  else
                  {
                      if (bayiObject.KullaniciTurID == 7)
                      {%>--%>

                <%--<div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" class="accordion-toggle" href="#collapseThree"><span class="fas fa-user orange"></span>Yetki Yönetimi </a>
                        </h4>
                    </div>
                    <div id="collapseThree" class="panel-collapse collapse">
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <span class="fas fa-users orange"></span><a href="AdliKullanicilar.aspx">Kullanıcılar</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-user orange"></span><a href="KullaniciProfilim.aspx" class=" pop_box">Profilim</a>
                                    </td>
                                </tr>

                            </table>
                        </div>
                    </div>
                </div>--%>
        <%--        <%  } %>--%>
                <%--<div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" class="accordion-toggle" href="#collapseTwo"><span class="fas fa-folder-open yellow"></span>Dosya İşlemleri</a>
                        </h4>
                    </div>
                    <div id="collapseTwo" class="panel-collapse collapse">
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <span class="fas fa-search yellow"></span><a href="MusteriListesi.aspx">Dosya Arama</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-search-plus yellow"></span><a href="MusteriBorclari.aspx">Borç Arama</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-hourglass-half yellow"></span><a href="DosyaSurecleri.aspx">Dosya Süreçleri</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-pencil-alt yellow"></span><a href="MerciiGuncelle.aspx">Mercii Güncelle</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-upload yellow"></span><a class="pop_box" href="TopluAdliVeriGirisi.aspx">Toplu Veri Girişi</a>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>--%>
                <%--<div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" class="accordion-toggle" href="#collapseFive"><span class="far fa-money-bill-alt green"></span>Masraf İşlemleri</a>
                        </h4>
                    </div>
                    <div id="collapseFive" class="panel-collapse collapse">
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <span class="fas fa-money-bill-alt green"></span><a href="MasrafListesi.aspx">MasrafListesi</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-upload green"></span><a class="pop_box" href="TopluMasrafGirisi.aspx">Toplu Masraf Girişi</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-qrcode   green"></span><a href="SarfMakbuzIslemleri.aspx">Sarf Makbuzu</a>
                                    </td>
                                </tr>

                            </table>
                        </div>
                    </div>
                </div>--%>
                <%--<div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" class="accordion-toggle" href="#collapseFour"><span class="fas fa-clipboard darkblue"></span>Raporlar</a>
                        </h4>
                    </div>
                    <div id="collapseFour" class="panel-collapse collapse">
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <span class="fas fa-file-alt darkblue"></span><a href="YasalTakipExcelRaporlari.aspx">Excel Raporları</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-balance-scale darkblue"></span><a href="AdliBilgiler.aspx">Adli Bilgi Raporları</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-comments darkblue"></span><a href="GorusmeGecmisi.aspx">Görüşme Geçmişi Raporları</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-credit-card darkblue"></span><a href="TahsilatRaporu.aspx">Tahsilat Raporu</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-file-image  darkblue"></span><a href="EvrakRaporlari.aspx">Evrak Yükleme Raporları</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-map-marker-alt  darkblue"></span><a href="ZiyaretRaporlari.aspx">Ziyaret Raporları</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fab fa-wpforms   darkblue"></span><a href="FormGecmisiListesi.aspx">Form Gecmisi Listesi</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="far fa-clock   darkblue"></span><a href="HatirlatmaRaporlari.aspx">Hatırlatma Raporları</a>
                                    </td>
                                </tr>
                                <tr style="display: none;">
                                    <td>
                                        <span class="fas fa-chart-pie darkblue"></span><a href="http://www.jquery2dotnet.com">Grafik Raporları</a>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>--%>
           <%--     <%   if (bayiObject.KullaniciTurID == 7)
                  {%>--%>
<%--                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <a data-toggle="collapse" data-parent="#accordion" class="accordion-toggle" href="#collapseSix"><span class="fas fa-cog red"></span>Yönetici İşlemleri</a>
                        </h4>
                    </div>
                    <div id="collapseSix" class="panel-collapse collapse">
                        <div class="panel-body">
                            <table class="table">
                                <tr>
                                    <td>
                                        <span class="fas fa-building red"></span><a href="SirketBilgileri.aspx" class=" pop_box">Şirket Bilgileri</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-address-card red"></span><a href="AvukatListesi.aspx">Dosya-Avukat Listesi</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-folder-open red"></span><a href="PortfoyYonetimi.aspx">Portföy Yönetim</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-copy red"></span><a href="FormListesi.aspx">Form Listesi</a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span class="fas fa-plus-square red"></span><a href="ExcelleMusteriGuncelle.aspx">Dosya Güncelle</a>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>--%>
             <%--   <% } %>--%>
            </div>
        <%--    <% } %>--%>
        </div>
        <a href="#" style="display: none" class="toolbar pop_box" title="Yeni Kullanıcı Ekle"><span class="icon-32 icon-32-adduser"></span>popup</a>
        <div id="SonDakika">
            <div id="KayanDuyuru"></div>
        </div>
    </div>
</asp:Content>

