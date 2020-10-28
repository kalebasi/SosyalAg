$(document).ready(function () {
    KitaplariListele();
    OkuyuculariListele();
});

function KitaplariListele() {
    $.ajax({
        type: "POST",
        url: "anasayfa.aspx/AnasayfaKitapListele",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 56) {
                $(".row").html(Tuple["Item3"]);

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
function OkuyuculariListele() {
    $.ajax({
        type: "POST",
        url: "anasayfa.aspx/AnasayfaOkuyucuListele",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 56) {
                $(".okur").html(Tuple["Item3"]);

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