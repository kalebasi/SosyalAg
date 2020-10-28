var KitapModelItem =
{
    ID: null,
    Kitaplar_ID: null,
    KitapAdi: '',
    KitapYazari: '',
    KitapResmi: '',
    BasimTarihi: '',
    SayfaSayisi: '',
    ISBN: '',
    Dil: '',
    Ulke: '',
    YayınEvi: '',
    KitapHakkinda: ''
};
$(document).ready(function () {
    $('#kitapresmibutton').on('click', function (e) {
        function sendFile(file) {
            var formData = new FormData();
            formData.append('file', $('.f_UploadImageKitapResmi')[0].files[0]);
            $.ajax({
                type: 'post',
                url: 'KitapResmi.ashx',
                data: formData,
                success: function (status) {
                    if (status !== 'error') {
                        document.getElementById("lblKitapResmi").innerHTML = status;
                    }
                },
                processData: false,
                contentType: false,
                error: function (e) {
                    alert("Whoops something went wrong! ");
                    console.log(e);
                }
            });
        }
        var _URL = window.URL || window.webkitURL;
        $(".f_UploadImageKitapResmi").on('change', function () {

            var file, img;
            if ((file = this.files[0])) {
                img = new Image();
                img.onload = function () {
                    sendFile(file);
                };
                img.onerror = function () {
                    alert("Not a valid file:" + file.type);
                };
                img.src = _URL.createObjectURL(file);
            }
        });
    });

    $(".strl").hide();
    KitaplariGetir();
    KitapModelItem.ID = escapeChars($('#pgAltAracGuncelle #lblKitapDetayID').text());
    KitapDetay(KitapModelItem.ID);
});

function KitaplariGetir() {

    $.ajax({
        type: "POST",
        url: "Kullanicilar.aspx/KitaplariGetir",
        contentType: "application/json; charset=utf-8",
        data: {},
        dataType: 'json',
        cache: false,
        async: false,
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 56) {
                $('#pgAltAracGuncelle #ddlKitapTürü').children().remove();
                $("#pgAltAracGuncelle #ddlKitapTürü").append($("<option>").val("").html("TÜMÜ"));
                var x = Tuple["Item2"];
                $.each(Tuple["Item3"], function (i, item) {
                    $("#pgAltAracGuncelle #ddlKitapTürü").append($("<option selected=\"selected\">").val(item.ID).html(item.KitapTürü));
                });
                $("#pgAltAracGuncelle #ddlKitapTürü").trigger("liszt:updated");
            }
            else if (Tuple["Item1"]["Code"] === 85) {
                window.location = "Login.aspx";
            }
            else {

                // Hata var
                showError(Tuple["Item1"]["Description"], 3000);
                setTimeout('unloading();', 200);
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            // Hata var

            showError("Hata : " + XMLHttpRequest.status + " " + XMLHttpRequest.statusText, 5000);
            setTimeout('unloading();', 200);
        }

    });
}

function KitapDetay(KitapID) {
    var id = KitapID;
    loading("Lütfen Bekleyiniz...");
    $.ajax({
        type: "post",
        url: "AltKullaniciDuzenle.aspx/KitapBilgileriniGetir",
        data: "{'KitapID':'" + id + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 56) {
                $("#pgAltAracGuncelle #lblKitapAdi").val(Tuple["Item2"]["KitapAdi"]);
                $("#pgAltAracGuncelle #lblKitapYazari").val(Tuple["Item2"]["KitapYazari"]);
                $("#pgAltAracGuncelle #lblBasimTarihi").val(Tuple["Item2"]["BasimTarihi"]);
                $("#pgAltAracGuncelle #lblSayfaSayisi").val(Tuple["Item2"]["SayfaSayisi"]);
                $("#pgAltAracGuncelle #lblISBN").val(Tuple["Item2"]["ISBN"]);
                $("#pgAltAracGuncelle #lblDil").val(Tuple["Item2"]["Dil"]);
                $("#pgAltAracGuncelle #lblUlke").val(Tuple["Item2"]["Ulke"]);
                $("#pgAltAracGuncelle #lblYayinEvi").val(Tuple["Item2"]["YayınEvi"]);
                $("#pgAltAracGuncelle #lblKitapHakkinda").val(Tuple["Item2"]["KitapHakkinda"]);
                $("#pgAltAracGuncelle #lblKitapResmi").text(Tuple["Item2"]["KitapResmi"]);
                setTimeout('unloading();', 200);
            }
            else if (Tuple["Item1"]["Code"] === 85) {
                setTimeout(function () { $.fancybox.close(); }, 1000);
                window.location = "Login.aspx";
            }
            else {
                showError(Tuple["Item1"]["Description"], 3000);
                setTimeout(function () { $.fancybox.close(); }, 500);
                setTimeout('unloading();', 200);
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            showError("Hata : " + XMLHttpRequest.status + " " + XMLHttpRequest.statusText, 5000);
            setTimeout(function () { $.fancybox.close(); }, 500);
            setTimeout('unloading();', 200);
        }
    });
}

function KitapBilgileriniDuzenle() {
    KitapModelItem.ID = escapeChars($("#pgAltAracGuncelle #lblKitapDetayID").text());
    KitapModelItem.Kitaplar_ID = escapeChars($("#pgAltAracGuncelle #ddlKitapTürü").val());
    KitapModelItem.KitapAdi = escapeChars($("#pgAltAracGuncelle #lblKitapAdi").val());
    KitapModelItem.KitapYazari = escapeChars($("#pgAltAracGuncelle #lblKitapYazari").val());
    KitapModelItem.KitapResmi = escapeChars($("#pgAltAracGuncelle #lblKitapResmi").text());
    KitapModelItem.BasimTarihi = escapeChars($("#pgAltAracGuncelle #lblBasimTarihi").val());

    KitapModelItem.SayfaSayisi = escapeChars($("#pgAltAracGuncelle #lblSayfaSayisi").val());
    KitapModelItem.ISBN = escapeChars($("#pgAltAracGuncelle #lblISBN").val());
    KitapModelItem.Dil = escapeChars($("#pgAltAracGuncelle #lblDil").val());
    KitapModelItem.Ulke = escapeChars($("#pgAltAracGuncelle #lblUlke").val());
    KitapModelItem.YayınEvi = escapeChars($("#pgAltAracGuncelle #lblYayinEvi").val());
    KitapModelItem.KitapHakkinda = escapeChars($("#pgAltAracGuncelle #lblKitapHakkinda").val());

}

$("#pgAltAracGuncelle #btnKaydet").click(function () {
    KitapBilgileriniDuzenle();
    loading('Lütfen Bekleyiniz');
    $.ajax({
        type: "POST",
        url: "AltKullaniciDuzenle.aspx/KitapBilgileriniGuncelle",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ kitapModel: KitapModelItem }),
        dataType: 'json',
        cache: false,
        success: function (msg) {
            var resultModel = msg.d;
            if (resultModel.Code === 56) {
                alert("Kitap Bilgileri Güncellenmiştir.");
                Listele();
                setTimeout(function () { $.fancybox.close(); }, 1000);
                setTimeout('unloading();', 200);
                enableButton("btnKaydet");
            }
            else if (resultModel.Code === 85) {
                setTimeout(function () { $.fancybox.close(); }, 1000);
                window.location = "Login.aspx";
            }
            else {
                showError(resultModel.Description, 3000);
                setTimeout('unloading();', 200);
                enableButton("btnKaydet");
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            showError("Hata : " + XMLHttpRequest.status + " " + XMLHttpRequest.statusText, 5000);
            setTimeout('unloading();', 200);
            enableButton("btnKaydet");
        }
    });
});

$("#pgAltAracGuncelle #btnKaydetIptal").click(function () {
    $('#close_windows').trigger('click');
});


