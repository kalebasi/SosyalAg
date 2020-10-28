<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="kitap.aspx.cs" Inherits="kitap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css2/icerik.css" rel="stylesheet" />
    <script src="js2/kitap.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div class="icerik-sayfasi">
            <div class="container"></div>
            <div class="ustbilgi" id="kitapBilgileri">
                <div class="arkaPlan">
                    <div class="arkaPlan2">
                        <%-- <img src="images/golgelerin-efendisi-ilk-yillar-.jpg" style="width: 100%; height: 100%; background-position: center" />--%>
                    </div>
                    <div class="arkaPlan3"></div>
                </div>
                <div class="container">
                    <div class="resim">
                        <%-- <img src="images/golgelerin-efendisi-ilk-yillar-.jpg" />--%>
                    </div>
                    <div class="kitapadi">
                        <%-- <h1>Gölgelerin Efendisi İlk Yıllar-2</h1>--%>
                        <div class="yazar">
                            <%--<h4>John Flanagan</h4>--%>
                        </div>
                    </div>
                </div>
            </div>
          
            <div class="container">
                  <div class="button">
                <div class="button" style="">
                    <div class="">
                        <a class="okuyacaklarima-ekle btn bir btn-secondary">Okuyacaklarıma Ekle</a>
                    </div>
                </div>
            </div>
                <div class="sol-kisim" style="padding-top:140px;">

                    <%--  <div id="lblkitaptürid" style="margin-top: 250px">1</div>
                    <button id="btnlistele">TIKLA</button>--%>
                    <div class="btn btn-success" id="btnbegendim">Beğendim</div>
                    <div class="btn btn-danger" id="btnbegenmedim">Beğenmedim</div>
                    
                </div>
                <div class="orta-kisim">
                    <div class="baslik">
                        <h2>Kitap Hakkındaki Yorumlar</h2>
                        <a href="#" id="yorumekle" class="far fa-comments add-comment" data-toggle="modal" data-target="#exampleModal" data-whatever="@getbootstrap" style="text-decoration: none;">Yorum Ekle</a>
                        <div id="lblKullanici_ID" runat="server" style="display:none;"></div>
                        <div id="lblKitap_ID" runat="server" style="display:none;"></div>
                    </div>
                    <div id="kullaniciKitapYorumlari">
                        <%--   <div class="yorum">
                        <div class="ust-baslik">
                            <div class="resim">
                                <img src="images/uyekayit.jpg" style="width: 100%; height: 100%;" />
                            </div>
                            <div class="yazi">
                                <h3 class="okur-adi">Yorumcu1</h3>
                            </div>
                        </div>
                        <div class="bosluk"></div>
                        <div class="icerik">
                            <div>
                                Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.
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
                                <h3 class="okur-adi">Yorumcu2</h3>
                            </div>
                        </div>
                        <div class="bosluk"></div>
                        <div class="icerik">
                            <div>
                                Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.
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
                                <h3 class="okur-adi">Yorumcu3</h3>
                            </div>
                        </div>
                        <div class="bosluk"></div>
                        <div class="icerik">
                            <div>
                                Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.
                            </div>
                        </div>
                        <div style="margin-bottom: 10px; margin-top: 0px;"></div>
                    </div>--%>
                    </div>
                </div>
                <div class="ana-sag">
                    <div class="trans-baslik" style="margin-top: 71px;">
                        <h2>Kitabın Basım Bilgileri</h2>
                    </div>
                    <div class="kutu-basim kutu bilgiler">
                        <%--   <div class="oge onlyDesktop">
                            <div class="kutu-baslik">Adı:</div>
                            <div class="bilgi">Gelirken Ekmek Al</div>
                        </div>
                        <div class="oge onlyDesktop">
                            <div class="kutu-baslik">Yazar:</div>
                            <div class="bilgi">Şermin Yaşar</div>
                        </div>
                        <div class="oge">
                            <div class="kutu-baslik">Baskı Tarihi:</div>
                            <div class="bilgi">Ekim 2019</div>
                        </div>
                        <div class="oge">
                            <div class="kutu-baslik">Sayfa Sayısı:</div>
                            <div class="bilgi">196</div>
                        </div>
                        <div class="oge">
                            <div class="kutu-baslik">ISBN</div>
                            <div class="bilgi">9786050966534</div>
                        </div>
                        <div class="oge">
                            <div class="kutu-baslik">Kitabın Türü:</div>
                            <div class="bilgi">Edebiyat</div>
                        </div>
                        <div class="oge">
                            <div class="kutu-baslik">Dil:</div>
                            <div class="bilgi">Türkçe</div>
                        </div>
                        <div class="oge">
                            <div class="kutu-baslik">Ülke:</div>
                            <div class="bilgi">Türkiye</div>
                        </div>
                        <div class="oge">
                            <div class="kutu-baslik">Yayınevi:</div>
                            <div class="bilgi">Doğan Kitap</div>
                        </div>
                        <div class="oge metin">
                            <div class="" style="width: 100%;">
                                <div class="" style="max-height: 210px; overflow: hidden;">
                                    <div >                                     ASDADSADASDADASDSADSADSADSAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAASDASAVVVAVVSAVASVAVAVAVAVAVSVAVSVSAVAVASVASVAVAVAVAVAVAVAVAVAVAVAVAVSAVASVASVAASDSAVASSDSADASVASDSADASVASDASACSDSAVASDASFASDASVASDASFADSAFASDAFASDSAFASDSAFASDASFASDASFASDASFASDASFASDSAFASDFASFASDSAASACASCSAFFSAFASFSFASFAS.
                                    </div>
                                </div>
                                <div></div>
                            </div>
                        </div>--%>
                    </div>
                    <div class="trans-baslik">
                        <h2>Kitabı Okuyanlar</h2>
                    </div>
                    <div class="liste-yatay-kutu-kucuk kutu-okuyanlar kutu">
                        <div class="liste-yatay okurlar">
                            <ul>
                               <%-- <li>
                                    <div class="resim">
                                        <a>
                                            <img src="images/araba.jpg" />
                                        </a>
                                    </div>
                                </li>--%>
                            </ul>
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
                    <h5 class="modal-title" id="exampleModalLabel">YORUMUNUZ</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <form>
                        <%--   <div class="form-group">
                            <label for="recipient-name" class="col-form-label">İsim Soyisim:</label>
                            <input type="text" class="form-control" id="isimsoyisim">
                        </div>--%>
                        <div class="form-group">
                            <label for="message-text" class="col-form-label">Yorumunuz:</label>
                            <textarea class="form-control" id="yapilanyorum" style="margin: 0px 0.0195313px 0px 0px; width: 568px; height: 92px;"></textarea>
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
                    <a class="btn btn-success" onclick="YorumEkle()" id="btnyorumkaydet">Yorum Yap </a>
                    <%-- <button type="button" class="btn btn-success" id="btnguncelle">Güncelle</button>--%>
                    <div id="lblKullaniciID" runat="server" style="display:none;"></div>
                    <div id="lblkitaptüridpop" runat="server" style="display:none;"></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

