<%@ Page Title="" Language="C#" MasterPageFile="~/Bayi/Bayi.master" AutoEventWireup="true" CodeFile="Kullanicilar.aspx.cs" Inherits="Bayi_Kullanicilar" %>

<%--<%@ Register Src="~/Bayi/UserControl/KullaniciPortfoyYetkiDialog.ascx" TagPrefix="uc1" TagName="KullaniciPortfoyYetkiDialog" %>--%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src='<%= "js/KullaniciListesi.js?ver="+DateTime.Now.ToShortDateString()  %>' type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="widget" id="pgGaleriListesi">
        <div id="PanelToolbar" class="panel panel-default">
            <div class="toolbar-list" id="toolbar">
                <ul>
                    <li class="button" id="toolbar-new">
                        <a href="YeniAltKullaniciEkle.aspx" class="toolbar pop_box"><span class="icon-32 icon-32-groups-add"></span>Kitap Ekle</a>
                    </li>
                </ul>
            </div>
            <div class="panel-heading">
                <div class="pagetitle icon-48-groups">
                    <h2 class="page-header">Kitaplık Listesi</h2>
                </div>
                <div class="panel-body">
                    <div id="submenu-box">
                        <div class="m">
                            <fieldset id="filter-bar">
                                <div class="filter-search fltlft">
                                    <div class="col-md-2">
                                        <label>Kitap Türü Seçiniz</label>
                                        <div style="width: 95%;">
                                            <select id="ddlMarkalar" class="combox">
                                                <option value="">TÜMÜ</option>
                                            </select>
                                        </div>
                                    </div>
                                   <%-- <div class="col-md-2">
                                        <label>Model</label>
                                        <div style="width: 95%;">
                                            <select id="ddlModeller" class="combox">
                                                <option value="">TÜMÜ</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="col-md-2">
                                        <label>Seri</label>
                                        <div style="width: 95%;">
                                            <select id="ddlSeri" class="combox">
                                                <option value="">TÜMÜ</option>
                                            </select>
                                        </div>
                                    </div>--%>
                                    <%--          <div class="col-md-2">
                                        <label>TELEFON GRUBU</label>
                                        <div>
                                            <select id="ddlTelefonGrup" tabindex="1" multiple="multiple" class="multi">
                                            </select>
                                        </div>
                                    </div>--%>
                                    <div class="col-md-2 fa-hover">
                                        <label>ARANACAK KELİME</label>
                                        <div style="width: 95%;">
                                            <input id="txtSearchText" placeholder="AranacakKelime" tabindex="5" type="text" class="change validate[minSize[2],maxSize[100]] "
                                                onkeypress="if (event.keyCode == 13) { $('#recordSearch').click(); return false; }" title="" />
                                        </div>
                                    </div>
                                    <div class="col-md-2 " style="padding-top: 20px;">
                                      <a id="recordSearch" class="btn btn-success" href="#">Ara</a>
                                     <%-- <a id="btnClearSearch" class="btn btn-info" href="#">Temizle</a>
                                    </div>--%>
                               <%--     <div class="col-md-2 Ekstra_104" style="padding-top: 20px;">
                                        <a id="btnExceleAktar" href="#" class="btn btn-primary" title="Raporu Excel'e Aktar">Raporu Excel'e Aktar</a>
                                    </div>--%>
                                </div>
                            </fieldset>
                            <div class="clr"></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="table-responsive">
            <table id="tblAraclar" class="adminlist ">
                <thead>
                    <tr>
                        <th class="y5">No</th>
                        <th class="yauto">Kitap Türü</th>
                        <th class="yauto">Kitap Adı</th>
                        <th class="yauto">Kitap Yazarı</th>
                        <th class="yauto">ISBN NO</th>
                        <th class="yauto">Basım Tarihi</th>
                        <th class="yauto">Sayfa Sayısı</th>
                        <th class="yauto">Dil</th>
                        <th class="yauto">Ülke</th>
                        <th class="yauto">Yayın Evi</th>
                      <%--  <th class="yauto">Kitap Hakkında</th>--%>
                    </tr>
                </thead>
                <tbody>
                </tbody>
                <tfoot>
                    <tr>
 <%--DÜZELTİLECEK--%> <%--<span>
                          <a title="ARAC DÜZENLE" href="AltKullaniciDuzenle.aspx?" class="pop_box">
                             <span class="btn btn-primary fa fa-pencil-alt"></span>
                                </a>
                                     </span>--%>
                        <td colspan="15">
                            <div class="DivToplamKayit fleft pageContainer">
                                Toplam kayıt: <span class="toplamKayitSayisi">0</span>, Gösterilen <span class="gosterilenMin">0</span>-<span class="gosterilenMax">0</span> arası
                            </div>
                            <div id="Pagination" class="dataTables_paginate fright paging_full_numbers pageContainer">
                            </div>
                        </td>

                    </tr>
                </tfoot>
            </table>
            <div id="lblSirketID" runat="server" style="display: none"></div>
        </div>
        <iframe id="DivSantralFrame" runat="server" width="200" height="100" style="display: none" />
    <%--    <uc1:KullaniciPortfoyYetkiDialog runat="server" ID="KullaniciPortfoyYetkiDialog" />--%>
    </div>
</asp:Content>


