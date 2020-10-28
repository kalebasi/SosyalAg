<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="profilim.aspx.cs" Inherits="profilim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css2/icerik.css" rel="stylesheet" />
    <link href="css2/profil.css" rel="stylesheet" />
    <%--<link href="bootstrap/css/bootstrap.min.css" rel="stylesheet" />--%>
    <script src="js2/profilim.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div class="icerik-sayfasi profil">
            <div class="container"></div>
            <div class="ustresimler">
                <div class="kapak">
                    <img src="images/uyekayit.jpg" />
                </div>
                <div class="camera">
                    <button class="fas fa-camera camera-kapak" data-toggle="modal" data-target="#exampleModalKapak" data-whatever="@getbootstrap"></button>
                </div>
                <div class="ust">
                    <div class="container">
                        <div class="resim">
                            <img src="images/uyekayit.jpg" style="max-width: 100%; height: 155px;" />
                        </div>
                        <%--     <div class="menu">
                          <div class="menu-1k sayili">
                          <div><a href="#">Duvarım</a></div>
                              <div><a href="#">Okuyacaklarım</a></div>
                              <div><a href="#">Okumakta Olduklarım</a></div>
                              <div><a href="#">Okuduklarım</a></div>
                              <div><a href="#">Kütüphanem</a></div>
                          </div>
                        </div>--%>
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
                <%-- <div class="btn-group kitapligim" role="group">
      <a href="#" class="btn btn-danger kitaplik" data-toggle="modal" data-target="#exampleModal" data-whatever="@getbootstrap\">KİTAPLIĞIM</a>
                 </div>--%>
                <div class="orta-kisim">
                    <div class="profil-gonderiler">
                        <div class="baslik">
                            <h2>Kitaplar Hakkında Yorumları</h2>
                            <div id="disaridangelenid" style="font-size: 20px;"></div>
                            <%-- <a href="#" class="far fa-comments add-comment" data-toggle="modal" data-target="#exampleModal2" data-whatever="@getbootstrap" style="text-decoration: none;">Duvarına Yaz</a>--%>
                            <div id="deneme"></div>
                            <div id="lblKullaniciID" runat="server" style="font-size: 20px; display:none;"></div>
                            <div id="kullanici" style="font-size: 20px;"></div>
                        </div>
                      
                        <div id="kullaniciProfilYorumlari">
                    <%--        <div class="kutu">
                                <ul class="kitaplar sirali lg altAlta liste">
                                    <div class="btn" id="btnSil"> X </div>
                                    <li class="kitap butonlu">
                                        <div class="resim">
                                            <img src="images/beyazali.jpg" />
                                        </div>
                                        <div class="sira">1. </div>
                                        <div class="kitap-adi">BEYAZ ALİ</div>
                                        <div class="bilgi">Ömer YERLİKAYA</div>
                                        <div class="bilgi ekBilgi">
                                            <div class="btn-group">
                                                <button type="button" class="btn btn-danger dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" style="width: 120px; border-radius: 5px;">
                                                <span class="durum"> OKUYACAĞIM</span>    
                                                 <span class="caret"></span>
                                                </button>
                                                <ul class="dropdown-menu">
                                                    <li><a id="okuyacagim">Okuyacağım</a></li>
                                                    <li><a id="okuyorum">Okuyorum</a></li>
                                                    <li><a id="okudum">Okudum</a></li>
                                                    <li role="separator" class="divider"></li>
                                                    <li><a href="#">Kütüphaneye Ekle</a></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </li>
                                </ul>
                            </div>--%>


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
                    <a class="btn btn-success" onclick="ProfilBilgilerimiGuncelle()" id="btnguncelle">Güncelle</a>
                    <%-- <button type="button" class="btn btn-success" id="btnguncelle">Güncelle</button>--%>
                     <%-- <div id="lblkullaniciid"></div>--%>
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
                    <input type="file" class="upload f_UploadImageProfil" id="profilresmibutton"<br />
                    <%--<img id="myUploadedImg" alt="Photo" style="width: 180px;" />--%>

                    <%-- <label id="profilresmi">Profil Resminiz:</label>
                    <asp:FileUpload ID="fileResimler" runat="server" />
                    &nbsp;<asp:Button ID="btnResimYukle" runat="server" Text="resim(leri) yükle" />
                    <br />
                    <asp:Label ID="Label1" runat="server" Font-Size="10pt" ForeColor="Green"></asp:Label>--%>
                </div>
                <div class="modal-footer">
                    <a class="btn btn-danger" data-dismiss="modal" id="btncikis">Çıkış </a>
                    <%-- <button type="button" class="btn btn-danger" data-dismiss="modal">Çıkış</button>--%>
                    <%--    <a class="btn btn-success"onclick="btnResimYukle_Click" id="btnguncelle">Güncelle </a>--%>
                    <%--<asp:Button ID="btnResimYukle" runat="server" CssClass="btn btn-success"  Text="Güncelle" OnClick="btnResimYukle_Click"/>--%>
                    <%-- <button type="button" class="btn btn-success" id="btnguncelle">Güncelle</button>--%>
                    <%-- <div id="lblkullaniciid">Buraya Gelecek </div>--%>
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
                      <input type="file" class="upload f_UploadImageKapak" id="kapakresmibutton"<br />
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

                    <%--<div id="lblkullaniciid">Buraya Gelecek </div>--%>
                </div>
            </div>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            $('#ContentPlaceHolder1_btnResimYukle').on('click', function (e) {
                GetData();
                console.log("asdf");
            });
            function GetData() {
                var formData = new FormData();
                formData.append('file', $('#ContentPlaceHolder1_fileResimler')[0].files[0]);
                alert(formData);
                $.ajax({
                    type: "POST",
                    url: "profilim.aspx/btnResimYukle_Click",
                    data: formData,
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        alert(response.d);
                    },
                });
            }
        });
    </script>
</asp:Content>

