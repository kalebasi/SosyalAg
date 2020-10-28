var ProfilDuzenleÖgeleri = {
    Kullanici_ID: null,
    YasadigiYer: '',
    Memleket: '',
    DogumTarihi: '',
    Cinsiyet: ''
};
var YorumÖgeleri = {
    Kullanici_ID: null,
    Yorum: ''
};
var profilModelItem =
{
    ID:null,
    Ad_Soyad: '',
    E_Mail:'',
    Sifre:''
};

var KullaniciID = 0;
var lblkullaniciid = 0;

$(document).ready(function () {
    
    $('#btnResimYukle').on('click', function (e) {
        alert("test");
    });
    
    var a = $(location).attr('href');
    ProfilBilgileri(a.split('=')[1]);
    ProfilYorumlari(a.split('=')[1]);
});





function ProfilBilgileri(KullaniciID) {
    $.ajax({
        type: "POST",
        url: "profil.aspx/ProfilBilgileri",
        cache: false,
        data: "{'KullaniciID':'" + KullaniciID + "'}",
        contentType:"application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $("#profilbilgileri").html(Tuple["Item2"]);
                $(".ustresimler").html(Tuple["Item3"]);
            }
            else {
                alert("Başarısız");
            }
        },
        error: function () {

        }
    });
    return false;
}

function ProfilYorumlari() {
    var a = $(location).attr('href');
    var KullaniciID = a.split('=')[1];
    $.ajax({
        type: "POST",
        url: "profil.aspx/ProfilYorumlari",
        cache: false,
        data: "{'KullaniciID':'" + KullaniciID + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Kitaplar Hakkında Yorumları");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else if (Tuple["Item1"]["Code"] === 85) {
                location.href = "login.aspx";
            }
            else {
                //alert("");
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
           
        }
    });
    return false;
}

function MenuOkuyacaklarimiGetir() {
    var a = $(location).attr('href');
    var KullaniciID = a.split('=')[1];
    $.ajax({
        type: "POST",
        url: "profil.aspx/MenuOkuyacaklarimiGetir",
        cache: false,
        data: "{KullaniciID:" + KullaniciID + "}",
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Okuyacağı Kitaplar");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else {
                alert("Kitap Bulunamamıştır.");
            }
        },
        error: function () {

        }
    });
    return false;
}

function MenuOkumaktaOlduklarimiGetir() {
    var a = $(location).attr('href');
    var KullaniciID = a.split('=')[1];
    $.ajax({
        type: "POST",
        url: "profil.aspx/MenuOkumaktaOlduklarimiGetir",
        cache: false,
        data: "{KullaniciID:" + KullaniciID + "}",
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Okumakta Olduğu Kitaplar");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else {
                alert("Kitap Bulunamamıştır.");
            }
        },
        error: function () {

        }
    });
    return false;
}

function MenuOkuduklarimiGetir() {
    var a = $(location).attr('href');
    var KullaniciID = a.split('=')[1];
    $.ajax({
        type: "POST",
        url: "profil.aspx/MenuOkuduklarimiGetir",
        cache: false,
        data: "{KullaniciID:" + KullaniciID + "}",
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Okuduğu Kitaplar");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else {
                alert("Kitap Bulunamamıştır.");
            }
        },
        error: function () {

        }
    });
    return false;
}

