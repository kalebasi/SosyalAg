<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltKullaniciDuzenle.aspx.cs" Inherits="Bayi_AltKullaniciDuzenle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src='<%= "js/AltKullaniciDuzenle.js?ver="+DateTime.Now.ToShortDateString()  %>' type="text/javascript"></script>
    <script src='<%= "js/Master.js?ver="+DateTime.Now.ToShortDateString()  %>' type="text/javascript"></script>
    <script type="text/javascript" src="<%= ResolveClientUrl("~/js/asistan.custom.js") %>"></script>

</head>
<body>
    <form id="pgAltAracGuncelle" runat="server">
        <div class="modal_dialog" style="width: 600px;">
            <div class="header">
                <span>KİTAP BİLGİLERİ</span><div class="close_me">
                    <a id="close_windows" class="butAcc">KAPAT</a>
                </div>
            </div>
            <div class="clear">
            </div>
            <div id="wizard" class="swMain">
                <ul class="anchor">

                    <li><a href="#step-1" class="selected" rel="1">
                        <label class="stepNumber">1</label>
                        <span class="stepDesc">KİTAP
                        </span>
                    </a></li>
                    <%--<li class="aw"><a href="#step-2">
                        <label class="stepNumber">2</label>
                        <span class="stepDesc">Kullanıcı
                        </span>
                    </a></li>--%>
                </ul>
                <div class="content" id="step-1">
                    <div class="section">
                        <label class="f_help">
                            KİTAP TÜRÜ 
                        </label>
                        <div>
                            <div style="max-width: 257px;">
                                <select id="ddlKitapTürü" class="combox" style="display: inline-block">
                                    <option value="">TÜMÜ</option>
                                </select>
                            </div>
                        </div>
                    </div>

                    <div class="section">
                        <label class="f_help">
                            KİTAP ADI 
                        </label>
                        <div>
                            <input type="text" name="Marka" id="lblKitapAdi" class="large" value="" runat="server" />
                        </div>
                    </div>
                    <div class="section">
                        <label class="f_help">
                            KİTAP YAZARI 
                        </label>
                        <div>
                            <input type="text" name="Model" id="lblKitapYazari" class="large" value="" runat="server" />
                        </div>
                    </div>
                    <div class="section ">
                        <label>
                            BASIM TARİHİ 
                        </label>
                        <div>
                            <input type="text" class="large" id="lblBasimTarihi" runat="server" />
                        </div>
                    </div>
                    <div class="section">
                        <label class="f_help">
                            Sayfa Sayısı 
                        </label>
                        <div>
                            <input class="large" type="text" id="lblSayfaSayisi" runat="server" />
                        </div>
                    </div>
                    <div class="section">
                        <label class="f_help">
                            ISBN 
                        </label>
                        <div>
                            <input class="large" type="text" id="lblISBN" runat="server" />
                        </div>
                        <label class="f_help">
                            DİL 
                        </label>
                        <div>
                            <input class="large" type="text" id="lblDil" runat="server" />
                        </div>
                        <label class="f_help">
                            ÜLKE 
                        </label>
                        <div>
                            <input class="large" type="text" id="lblUlke" runat="server" />
                        </div>
                        <label>YAYIN EVİ  </label>
                        <div>
                            <input type="text" class="large" name="Renk" id="lblYayinEvi" runat="server" />
                        </div>
                       <%-- <label>
                            KİTAP HAKKINDA 
                        </label>
                        <div>
                            <input type="text" class="large" name="Renk" id="lblKitapHakkinda" runat="server" />
                        </div>--%>
                        <label>
                            KİTAP RESMİ
                        </label>
                        <div style="display: inline-block; margin-left: 20px;">
                            <input type="file" class="upload f_UploadImageKitapResmi" id="kitapresmibutton" /><br />
                            <label id="lblKitapResmi">1</label>
                        </div>
                    </div>
                    <div class="loader">Loading  </div>
                    <a id="btnKaydet" onclick="KitapGuncelle()" class="buttonFinish">Kaydet</a>
                    <%--        <a href="#" id="btnIleri" class="buttonNext">Sonraki</a>
                    <a href="#" class="buttonPrevious buttonDisabled">Önceki</a>
                    --%>
                </div>

                <div class="section last">
                    <div style="float: left; width: 50%;">
                        <div id="lblKitapDetayID" runat="server"></div>
                        <div id="lblMarkaID" runat="server"></div>
                        <div id="lblModelID" runat="server"></div>
                        <div id="lblSeriID" runat="server"></div>
                    </div>
                    <div style="float: right; width: 50%;" align="right">
                    </div>
                </div>
                <div class="clear" style="display: none">
                </div>
            </div>
        </div>
    </form>
</body>
</html>
