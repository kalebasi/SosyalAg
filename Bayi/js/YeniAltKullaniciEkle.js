var KitapModelItem =
{
    //ID: null,
    Kitaplar_ID: null,
    KitapAdi: '',
    KitapYazari: '',
    KitapResmi:'',
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

    KitaplariGetir();  
    $(".strl").hide();
    $(".combox").chosen();
   
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
                $('#pgAltAracEkle #ddlKitapTürleri').children().remove();
                $("#pgAltAracEkle #ddlKitapTürleri").append($("<option>").val("").html("TÜMÜ"));
                var x = Tuple["Item2"];
                $.each(Tuple["Item3"], function (i, item) {
                    $("#pgAltAracEkle #ddlKitapTürleri").append($("<option selected=\"selected\">").val(item.ID).html(item.KitapTürü));
                });
                $("#pgAltAracEkle #ddlKitapTürleri").trigger("liszt:updated");
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

function KitapValues() {

    //KitapModelItem.ID = escapeChars($("#pgAltAracEkle #lblAracDetayID").text());
    KitapModelItem.Kitaplar_ID = escapeChars($("#pgAltAracEkle #ddlKitapTürleri").val());
    KitapModelItem.KitapAdi = escapeChars($("#pgAltAracEkle #lblKitapAdi").val());
    KitapModelItem.KitapYazari = escapeChars($("#pgAltAracEkle #lblKitapYazari").val());
    KitapModelItem.KitapResmi = escapeChars($("#pgAltAracEkle #lblKitapResmi").text());
    KitapModelItem.BasimTarihi = escapeChars($("#pgAltAracEkle #lblBasimTarihi").val());
    KitapModelItem.SayfaSayisi = escapeChars($("#pgAltAracEkle #lblSayfaSayisi").val());
    KitapModelItem.ISBN = escapeChars($("#pgAltAracEkle #lblISBN").val());

    KitapModelItem.Dil = escapeChars($("#pgAltAracEkle #lblDil").val());
    KitapModelItem.Ulke = escapeChars($("#pgAltAracEkle #lblUlke").val());
    KitapModelItem.YayınEvi = escapeChars($("#pgAltAracEkle #lblYayinEvi").val());
    KitapModelItem.KitapHakkinda = escapeChars($("#pgAltAracEkle #lblKitapHakkinda").val());
    
}

$("#btnKaydet").click(function () {
    //console.log(kullaniciModelItem);
    hideTop();
   
    if (disableButton("btnKaydet")) {
        var FormValidate = $("#pgAltAracEkle").validationEngine('validate');
        if (FormValidate !== true) {
            enableButton("btnKaydet");
            return false;
        }
        KitapValues();
        $.ajax({
            type: "POST",
            url: "YeniAltKullaniciEkle.aspx/YeniKitapEkle",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ kitapModel: KitapModelItem }),
            dataType: 'json',
            cache: false,
            success: function (msg) {
                var tuple = msg.d;
                if (tuple["Item1"].Code === 56) {
                    alert("Kitap Başarılı Bir Şekilde Kayıt Edilmiştir.");
                    showSuccess(tuple["Item1"].Description, 3000);
                    setTimeout(function () { $.fancybox.close(); }, 1000);
                    setTimeout('unloading();', 200);
                    enableButton("btnKaydet");
                }
                else if (tuple["Item1"].Code === 27) {
                    alert("Bilgiler Boş Bırakılamaz");
                }
                else {
                    alert("Hata");
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                showError("Hata : " + XMLHttpRequest.status + " " + XMLHttpRequest.statusText, 5000);
                setTimeout('unloading();', 200);
                enableButton("btnKaydet");
            }
        });
    }
    else
        return false;
});



$("#btnKaydetIptal").click(function () {
    $('#close_windows').trigger('click');
});
