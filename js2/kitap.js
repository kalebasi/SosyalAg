var YorumÖgeleri = {
    Kullanici_ID: null,
    KitapBilgileri_ID: null,
    Yorum: ''
}
var KutuphaneOgeleri = {
    Kullanici_ID: null,
    OkuyacagimKitap_ID: null
}

$(document).ready(function () {
    //KitaplariListele(1);
    $("#navbarSekmeleri").fadeIn();
    var a = $(location).attr('href');
    KitapBasimBilgileri(a.split('=')[1]);
    KitapBilgileri(a.split('=')[1]);

    $(".okuyacaklarima-ekle").click(function () {
        OkuyacaklarimaEkle();
    });
    $("#btnbegendim").click(function () {
        Begendim();
    });
    $("#btnbegenmedim").click(function () {
        Begenmedim();
    });
});

function Begendim() {
    var OySayisi = $("#ToplamOySayisi").text();
    var KitapID = $("#ctl00_ContentPlaceHolder1_lblKitap_ID").text();
    $.ajax({
        type: "POST",
        url: "kitap.aspx/OyBegendim",
        cache: false,
        data: "{'OySayisi':" + OySayisi + ",KitapID:" + KitapID + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code===1) {
                alert("Fikrinizi paylaştığınız için teşekkürler.");
            }
            else {
                alert("Bu kitaba daha önce oy kullandınız.");
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

        }
    });
    return false;
}

function Begenmedim() {
    var OySayisi = $("#ToplamOySayisi").text();
    var KitapID = $("#ctl00_ContentPlaceHolder1_lblKitap_ID").text();
    $.ajax({
        type: "POST",
        url: "kitap.aspx/OyBegenmedim",
        cache: false,
        data: "{'OySayisi':" + OySayisi + ",KitapID:" + KitapID + "}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code === 1) {
                alert("Fikrinizi paylaştığınız için teşekkürler.");
            }
            else {
                alert("Bu kitaba daha önce oy kullandınız.");
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

        }
    });
    return false;
}

function OkuyacaklarimaEkle() {
    //var KullaniciID= $("#ctl00_ContentPlaceHolder1_lblKullanici_ID").text();
    var KitapID= $("#ctl00_ContentPlaceHolder1_lblKitap_ID").text();
    $.ajax({
        type: "POST",
        url: "kitap.aspx/OkuyacaklarimaEkle",
        cache: false,
        data: "{'KitapID':'" + KitapID + "'}",
        //data: JSON.stringify({ kutuphaneModel: KutuphaneOgeleri }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code===1) {
                alert("Okunacaklar Listesine Eklenmiştir.");
            }
            else {
                alert(Tuple.Tanim);
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

        }
    });
    return false;
}
function KitapBilgileri(KitapID) {
    $.ajax({
        type: "POST",
        url: "kitap.aspx/KitapBilgileri",
        cache: false,
        data: "{'KitapID':'" + KitapID + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Tuple = msg.d;
            $("#kitapBilgileri").html(Tuple["Item3"]);
            $("#ToplamOySayisi").html(Tuple["Item3"]["BegenenKisiSayisi"]);
            if (Tuple["Item1"]["Code"] === 1) {
                $("#kullaniciKitapYorumlari").html(Tuple["Item4"]);
            }
            else {
                alert("Henüz bu kitaba yorum yapılmamıştır.");
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

        }
    });
    return false;
}
function KitapBasimBilgileri(KitapID) {
    $.ajax({
        type: "POST",
        url: "kitap.aspx/KitapBasimBilgileri",
        cache: false,
        data: "{'KitapID':'" + KitapID + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".kutu-basim").html(Tuple["Item2"]);
                $(".okurlar ul").html(Tuple["Item3"]);
            }
            else {
                alert("Başarısız");
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {

        }
    });
    return false;
}
function YorumEkle() {
    SetYorum();
    //alert("KullaniciID:" + YorumÖgeleri.Kullanici_ID);
    //alert("KitapID:" + YorumÖgeleri.KitapBilgileri_ID);
    $.ajax({
        type: "POST",
        url: "kitap.aspx/YeniYorumEkle",
        cache: false,
        data: JSON.stringify({ yorumModel: YorumÖgeleri }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var result = msg.d;
            if (result.Code===1) {
                alert("Bizimle fikirlerinizi paylaştığınız için teşekkür ederiz.");
                var a = $(location).attr('href');
                KitapBilgileri(a.split('=')[1]);
            }
            else {
                alert("Boş Yorum Yapılamaz");
            }
        },
        error: function () {
            alert("Boş Yorum Yapılamaz");
        }
    });
    return false;
}
function SetYorum() {
    YorumÖgeleri.Kullanici_ID = $("#ctl00_ContentPlaceHolder1_lblKullanici_ID").text();
    YorumÖgeleri.KitapBilgileri_ID = $("#ctl00_ContentPlaceHolder1_lblkitaptüridpop").text();
    YorumÖgeleri.Yorum = $("#yapilanyorum").val();
}
