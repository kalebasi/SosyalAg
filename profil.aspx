<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="profil.aspx.cs" Inherits="profil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css2/icerik.css" rel="stylesheet" />
    <link href="css2/profil.css" rel="stylesheet" />
    <script src="js2/profil.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div>
        <div class="icerik-sayfasi profil">
            <div class="container"></div>
            <div class="ustresimler">
                <div class="kapak">
                    <img src="images/uyekayit.jpg" />
                </div>
                <div>
                    <%-- <button class="fas fa-camera camera-kapak" data-toggle="modal" data-target="#exampleModalKapak" data-whatever="@getbootstrap"></button>--%>
                </div>
                <div class="ust">
                    <div class="container">
                        <div class="resim">
                            <img src="images/uyekayit.jpg" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="sol-kisim" id="profilbilgileri">
                    <%--  <div class="kullanici-adi">
                        <h1>İbrahim Can</h1>
                    </div>
                    <div class="kisisel-bilgiler">
                        <div class="bilgiler">
                            <div class="ikon">
                                <span class="fas fa-map-marker-alt"></span>
                            </div>
                            <div class="bilgi">
                                <h4>İstanbul'da yaşıyor.</h4>
                            </div>
                        </div>
                        <div class="bilgiler">
                            <div class="ikon">
                                <span class="fas fa-home blue "></span>
                            </div>
                            <div class="bilgi">
                                <h4>Memleketi Giresun</h4>
                            </div>
                        </div>
                        <div class="bilgiler">
                            <div class="ikon">
                                <span class="fas fa-birthday-cake "></span>
                            </div>
                            <div class="bilgi">
                                <h4>6 Haziran 1997</h4>
                            </div>
                        </div>
                        <div class="bilgiler">
                            <div class="ikon">
                                <span class="fas fa-transgender"></span>
                            </div>
                            <div class="bilgi">
                                <h4>Erkek</h4>
                            </div>
                        </div>
                        <div class="profil-btn">
                            <div class="btn-group" role="group">
                                <a href="#" id="profilduzenle" onclick="btnclick()" class="btn btn-danger" data-toggle="modal" data-target="#exampleModal" data-whatever="@getbootstrap">PROFİLİMİ DÜZENLE</a>
                            </div>
                            <div class="btn-group" role="group">
                                <button class="fas fa-camera camera-profil" type="button"  data-toggle="modal" data-target="#exampleModalProfil" data-whatever="@getbootstrap">
                                </button>
                            </div>
                        </div>
                    </div>
                    <label id="lblid"></label>--%>
                </div>
                <div class="orta-kisim">
                    <div class="profil-gonderiler">
                        <div class="baslik">
                            <h2>Kitaplar Hakkında Yorumları</h2>
                            <div id="disaridangelenid" style="font-size: 20px;"></div>
                            <%-- <a href="#" class="far fa-comments add-comment" data-toggle="modal" data-target="#exampleModal2" data-whatever="@getbootstrap" style="text-decoration: none;">Duvarına Yaz</a>--%>

                            <div id="lblKullaniciID" runat="server" style="font-size: 20px;"></div>
                            <%--<div id="kullanici" style="font-size: 20px;">1</div>--%>
                        </div>
                        <div id="kullaniciProfilYorumlari">

                            <%--                <div class="yorum">
                                <div class="ust-baslik">
                                    <div class="resim">
                                        <img src="images/uyekayit.jpg" style="width: 100%; height: 100%;" />
                                    </div>
                                    <div class="yazi">
                                        <h3 class="okur-adi">Yorumcu1</h3>
                                    </div>
                                </div>
                                <div class="icerik">
                                    <div>
                                        Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.
                                    </div>
                                </div>
                                <div class="kitap-yorum">
                                    <div class="resim">
                                        <a href="Kitaplik.aspx">
                                           <img src="images/john-flanagan.jpg" style="width: 100%; height: 100%;"/>
                                        </a>
                                    </div>
                                    <div class="kitap-hakkinda">
                                        <div class="adi">
                                            <span class="kitap_yazar_adi">Gölgelerin Efendisi, John Flanagan</span>
                                        </div>
                                    </div>
                                </div>
                                <div style="margin-bottom: 10px; margin-top: 0px;"></div>
                            </div>
                            <div class="yorum">
                                <div class="ust-baslik">
                                    <div class="resim">
                                        <img src="images/uyekayit.jpg" style="width: 100%; height: 100%;" />
                                    </div>
                                    <div class="yazi">
                                        <h3 class="okur-adi">Yorumcu1</h3>
                                    </div>
                                </div>
                                <div class="icerik">
                                    <div>
                                        Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.
                                    </div>
                                </div>
                                <div class="kitap-yorum">
                                    <div class="resim">
                                        <a href="Kitaplik.aspx">
                                            <img src="images/john-flanagan.jpg" style="width: 100%; height: 100%;" />
                                        </a>
                                    </div>
                                    <div class="kitap-hakkinda">
                                        <div class="adi">
                                            <span class="kitap_yazar_adi">Gölgelerin Efendisi, John Flanagan</span>
                                        </div>
                                    </div>
                                </div>
                                <div style="margin-bottom: 10px; margin-top: 0px;"></div>
                            </div>--%>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">PROFİL</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <form>
                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Yaşadığınız Yer:</label>
                            <input type="text" class="form-control" id="yasadigiyer">
                        </div>
                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Memleketiniz:</label>
                            <input type="text" class="form-control" id="memleket">
                        </div>
                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Doğum Tarihiniz:</label>
                            <input type="text" class="form-control" id="dogumtarihi">
                        </div>
                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Cinsiyetiniz:</label>
                            <input type="text" class="form-control" id="cinsiyet">
                        </div>
                        <%--  <div class="form-group">
                            <label for="message-text" class="col-form-label">Message:</label>
                            <textarea class="form-control" id="txtmsj"></textarea>
                        </div>--%>
                    </form>
                </div>
                <div class="modal-footer">
                    <a class="btn btn-danger" data-dismiss="modal" id="btncikis">Çıkış </a>
                    <%-- <button type="button" class="btn btn-danger" data-dismiss="modal">Çıkış</button>--%>
                    <a class="btn btn-success" onclick="ProfilBilgilerimiGuncelle()" id="btnguncelle">Güncelle </a>
                    <%-- <button type="button" class="btn btn-success" id="btnguncelle">Güncelle</button>--%>
                    <div id="lblkullaniciid">Buraya Gelecek </div>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">YORUMUNUZ</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <form>
                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">İsim Soyisim:</label>
                            <input type="text" class="form-control" id="isimsoyisim">
                        </div>
                        <div class="form-group">
                            <label for="message-text" class="col-form-label">Yorumunuz:</label>
                            <textarea class="form-control" id="yapilanyorum"></textarea>
                        </div>
                        <%--  <div class="form-group">
                            <label for="message-text" class="col-form-label">Message:</label>
                            <textarea class="form-control" id="txtmsj"></textarea>
                        </div>--%>
                    </form>
                </div>
                <div class="modal-footer">
                    <a class="btn btn-danger" data-dismiss="modal" id="btncikis">Çıkış </a>
                    <%-- <button type="button" class="btn btn-danger" data-dismiss="modal">Çıkış</button>--%>
                    <a class="btn btn-success" onclick="DuvarınaYaz()" id="btnYorumKaydet">Yorum Yap </a>
                    <%-- <button type="button" class="btn btn-success" id="btnguncelle">Güncelle</button>--%>
                    <div id="lblkullaniciiduvar">1</div>
                    <div id="lblkitaptüridpop"></div>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="exampleModalProfil" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">PROFİL FOTOĞRAFINIZ</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">

                    <%--  <label id="profilresmi">Profil Resminiz:</label>
                        <asp:FileUpload id="fileResimler" runat="server"/>
                        &nbsp;<asp:Button ID="btnResimYukle" runat="server" text="resim(leri) yükle" OnClick="btnResimYukle_Click" />
                        <br />
                        <asp:Label ID="Label1" runat="server" Font-Size="10pt" ForeColor="Green"></asp:Label>--%>
                </div>
                <div class="modal-footer">
                    <a class="btn btn-danger" data-dismiss="modal" id="btncikis">Çıkış </a>
                    <%-- <button type="button" class="btn btn-danger" data-dismiss="modal">Çıkış</button>--%>
                    <%--    <a class="btn btn-success"onclick="btnResimYukle_Click" id="btnguncelle">Güncelle </a>--%>
                    <%--<asp:Button ID="btnResimYukle" runat="server" CssClass="btn btn-success"  Text="Güncelle" OnClick="btnResimYukle_Click"/>--%>
                    <%-- <button type="button" class="btn btn-success" id="btnguncelle">Güncelle</button>--%>
                    <div id="lblkullaniciid">Buraya Gelecek </div>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="exampleModalKapak" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">KAPAK FOTOĞRAFINIZ</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <%--        <form id="form1">
                        <label id="kapakfotografi">Kapak Fotoğrafınız:</label>
                        <asp:FileUpload ID="FileUpload4" runat="server" class="multi" />
                        &nbsp;<asp:Button ID="btnResimYukle1" runat="server" Text="Resim(leri) Yükle" 
               onclick="btnResimYukle_Click" />
                        <br />
                        <asp:Label ID="Label2" runat="server" Font-Size="10pt" ForeColor="Green"></asp:Label>
                    </form>--%>
                </div>
                <div class="modal-footer">
                    <a class="btn btn-danger" data-dismiss="modal" id="btncikis">Çıkış </a>
                    <%-- <button type="button" class="btn btn-danger" data-dismiss="modal">Çıkış</button>--%>
                    <%-- <a class="btn btn-success" onclick="ProfilBilgilerimiGuncelle()" id="btnguncelle">Güncelle </a>--%>
                    <%--    &nbsp;<asp:Button ID="Button1" runat="server" Text="Resim(leri) Yükle" 
                     onclick="btnResimYukle_Click" />--%>

                    <%--   <button type="button" class="btn btn-success" id="btnguncelle">Güncelle</button>--%>

                    <div id="lblkullaniciid">Buraya Gelecek </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

