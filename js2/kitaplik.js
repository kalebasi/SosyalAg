var YorumÖgeleri = {
    Kullanici_ID: null,
    KitapBilgileri_ID:null,
    Yorum:''
}

var KitaptürID = 0;
var KitapID = 0;
var lblkitaptürid = 0;
var lblkullaniciid = 0;

$(document).ready(function () {
    KitapTürleriListele();
    //KitaplariListele(1);
    var a = $(location).attr('href');
    KitaplariListele(a.split('=')[1]);
    KitapBilgileri(a.split('=')[1]);
});

function KitaplariListele(KitapTürID) {

    $.ajax({
        type: "POST",
        url: "kitaplik.aspx/KitapListele",
        cache: false,
        data: "{'KitapTürID':'" + KitapTürID + "'}",
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $("#Kitaplik_Liste").html(Tuple["Item3"]);

            }
            else if (Tuple["Item1"]["Code"] === 85) {
                location.href = "login.aspx";
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

function KitapTürleriListele() {
    $.ajax({
        type: "POST",
        url: "kitaplik.aspx/KitapTürleriListele",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 56) {
                $("#KitapTürleri_Liste").html(Tuple["Item3"]);
                var a = $(location).attr('href');
                KitaplariListele(a.split('=')[1]);
            }
            else if (Tuple["Item1"]["Code"] === 85) {
                location.href = "login.aspx";
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
