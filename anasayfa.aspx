<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="anasayfa.aspx.cs" Inherits="anasayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="js2/login.js"></script>
    <script src="js2/anasayfa.js"></script>
    <link href="css2/anasayfa.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Carousel
    ================================================== -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li> 
            <li data-target="#myCarousel" data-slide-to="3"></li>
        </ol>
        <div class="carousel-inner" role="listbox" <%--style="margin-top:50px;"--%>>
            <div class="item active">
                <img src="images/Kitap-ile-ilgili-ozlu-sozler.jpg" />
                <%--   <img class="first-slide" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="First slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>Example headline.</h1>
              <p>Note: If you're viewing this page via a <code>file://</code> URL, the "next" and "previous" Glyphicon buttons on the left and right might not load/display properly due to web browser security rules.</p>
              <p><a class="btn btn-lg btn-primary" href="#" role="button">Sign up today</a></p>
            </div>
          </div>--%>
            </div>
            <div class="item">
                <img src="images/Kitap-okumanin-onemini-anlatan-sozler.jpg" />
                <%--  <img class="second-slide" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Second slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>Another example headline.</h1>
              <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
              <p><a class="btn btn-lg btn-primary" href="#" role="button">Learn more</a></p>
            </div>
          </div>  --%>
            </div>
            <div class="item">
                <img src="images/Kitaplar-İle-İlgili-Güzel-Sözler.jpg" />
                <%--      <img class="third-slide" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Third slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>One more for good measure.</h1>
              <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
              <p><a class="btn btn-lg btn-primary" href="#" role="button">Browse gallery</a></p>
            </div>
          </div>--%>
            </div>
            <div class="item">
                <img src="images/Okumak-İle-İlgili-Sözler.jpg" />
                <%--     <img class="third-slide" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Third slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>One more for good measure.</h1>
              <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
              <p><a class="btn btn-lg btn-primary" href="#" role="button">Browse gallery</a></p>
            </div>
          </div>
        </div>--%>
            </div>
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            </a>
        </div>
        <!-- /.carousel -->



        <!-- Marketing messaging and featurettes
    ================================================== -->
        <!-- Wrap the rest of the page in another container to center all the content. -->

        <div class="container marketing">
            <div class="baslik">EN ÇOK BEĞENİLEN KİTAPLAR </div>
            <!-- Three columns of text below the carousel -->
            <div class="row" style="margin-top: 20px;">
                <%-- <div class="col-lg-4">
          <img class="img-circle" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Generic placeholder image" width="140" height="140">
          <h2>Kitap Başlığı</h2>
          <p>Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod. Nullam id dolor id nibh ultricies vehicula ut id elit. Morbi leo risus, porta ac consectetur ac, vestibulum at eros. Praesent commodo cursus magna.</p>
          <p><a class="btn btn-default" href="#" role="button">Kitabı İncele &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
       
        <div class="col-lg-4">
          <img class="img-circle" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Generic placeholder image" width="140" height="140">
          <h2>Heading</h2>
          <p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis consectetur purus sit amet fermentum. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh.</p>
          <p><a class="btn btn-default" href="#" role="button">View details &raquo;</a></p>
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-4">
          <img class="img-circle" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Generic placeholder image" width="140" height="140">
          <h2>Heading</h2>
          <p>Donec sed odio dui. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>
          <p><a class="btn btn-default" href="#" role="button">View details &raquo;</a></p>
        </div><!-- /.col-lg-4 -->--%>
            </div>
            <!-- /.row -->

        </div>
        <div class="en-fazla-okur">
            <div class="baslik">EN ÇOK OKUYAN OKURLAR </div>
            <div class="okur">
            </div>

            <!-- /.col-lg-4 -->
            <%--    <div class="okuyucu-bilgileri">
                <img class="img-circle" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Generic placeholder image" width="140" height="140">
                <h3>Kullanıcı Adı</h3>
            </div>
            <div class="okuyucu-bilgileri">
                <img class="img-circle" src="data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==" alt="Generic placeholder image" width="140" height="140">
                <h3>Kullanıcı Adı</h3>
            </div>--%>
        </div>
          <footer style="width: auto; height: 50px; background-color: LIGHTGOLDENRODYELLOW"></footer>
    </div>
  

    <%-- <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">GİRİŞ</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <form>
                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">E-Mail : </label>
                            <input type="text" class="form-control" id="email">
                        </div>
                            <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Password : </label>
                            <input type="password" class="form-control" id="password">
                      <%--  <div class="form-group">
                            <label for="message-text" class="col-form-label">Message:</label>
                            <textarea class="form-control" id="txtmsj"></textarea>
                        </div>
                    </form>
                </div>
                <div class="modal-footer">
                   <a  class="btn btn-success" onclick="OturumAc()" id="btnGirisYap"> Giriş  </a>   
                   <button type="button" class="btn btn-success" id="btnguncelle">Güncelle</button>
                  <div id="lblkullaniciid"> Buraya Gelecek </div>
                </div>
            </div>
        </div>
    </div>--%>
</asp:Content>

