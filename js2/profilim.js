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
    ID: null,
    Ad_Soyad: '',
    E_Mail: '',
    Sifre: ''
};
var Kutuphane={
    Kullanici_ID:null,
    OkumaktaOldugumKitap_ID:null
}

var KullaniciID = 0;
var lblkullaniciid = 0;

$(document).ready(function () {
    $('#profilresmibutton').on('click', function (e) {
        function sendFile(file) {
            var formData = new FormData();
            formData.append('file', $('.f_UploadImageProfil')[0].files[0]);
            $.ajax({
                type: 'post',
                url: 'fileUploader.ashx',
                data: formData,
                success: function (status) {
                    if (status !== 'error') {
                        alert("Profil Resminiz Güncellenmiştir.");
                        ProfilBilgileri();
                        ProfilYorumlari();
                        var my_path = "~/images/" + status;
                        $("#myUploadedImg").attr("src", my_path);

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
        $(".f_UploadImageProfil").on('change', function () {

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

    $('#kapakresmibutton').on('click', function (e) {
         function sendFile(file) {
            var formData = new FormData();
            formData.append('file', $('.f_UploadImageKapak')[0].files[0]);
            $.ajax({
                type: 'post',
                url: 'KapakResmi.ashx',
                data: formData,
                success: function (status) {
                    if (status !== 'error') {
                        alert("Kapak Resminiz Güncellenmiştir.");
                        ProfilBilgileri();
                        var my_path = "~/images/" + status;
                        $("#myUploadedImg").attr("src", my_path);

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
        $(".f_UploadImageKapak").on('change', function () {

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
       
   
    $('#btnResimYukle').on('click', function (e) {
        alert("test");
    });
   
    ProfilBilgileri();
    ProfilYorumlari();
   
});



function ProfilBilgileri() {
    $.ajax({
        type: "POST",
        url: "profilim.aspx/ProfilBilgileri",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $("#profilbilgileri").html(Tuple["Item2"]);
                $(".ustresimler").html(Tuple["Item3"]);
            }
            else {
                //alert("Başarısız");
            }
        },
        error: function () {

        }
    });
    return false;
}

function ProfilYorumlari() {
    $.ajax({
        type: "POST",
        url: "profilim.aspx/ProfilYorumlari",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Kitaplar Hakkında Yorumlarım");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else if (Tuple["Item1"]["Code"] === 85) {
                location.href = "login.aspx";
            }
            else {
                //alert("Başarısız");
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
           
        }
    });
    return false;
}

function ProfilBilgilerimiGetirPopUp() {
    $.ajax({
        type: "POST",
        url: "profilim.aspx/ProfilBilgilerimiGetirPopUp",
        data: {},
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        async: false,
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {

                $("#yasadigiyer").val(Tuple["Item2"]["YasadigiYer"]);
                $("#memleket").val(Tuple["Item2"]["Memleket"]);
                $("#dogumtarihi").val(Tuple["Item2"]["DogumTarihi"]);
                $("#cinsiyet").val(Tuple["Item2"]["Cinsiyet"]);
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

function ProfilBilgilerimiGuncelle() {
    SetProfilBilgileri();
    $.ajax({
        type: "POST",
        url: "profilim.aspx/ProfilBilgilerimiGuncelle",
        cache: false,
        data: JSON.stringify({ profilModel: ProfilDuzenleÖgeleri }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code===1) {
                alert("Profil Bilgileriniz Güncellenmiştir.");
                ProfilBilgileri();
            }
            else {
                alert("Başarısız.");
            }
        },
        error: function () {

        }
    });

}

function SetProfilBilgileri() {

    ProfilDuzenleÖgeleri.Kullanici_ID = $("#ctl00_ContentPlaceHolder1_lblKullaniciID").text();
    ProfilDuzenleÖgeleri.YasadigiYer = $("#yasadigiyer").val();
    ProfilDuzenleÖgeleri.Memleket = $("#memleket").val();
    ProfilDuzenleÖgeleri.DogumTarihi = $("#dogumtarihi").val();
    ProfilDuzenleÖgeleri.Cinsiyet = $("#cinsiyet").val();
}



function MenuOkuyacaklarimiGetir() {
    $.ajax({
        type: "POST",
        url: "profilim.aspx/MenuOkuyacaklarimiGetir",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Okuyacağım Kitaplar");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else {
                //alert("Başarısız");
            }
        },
        error: function () {

        }
    });
    return false;
}

function MenuOkumaktaOlduklarimiGetir() {
    $.ajax({
        type: "POST",
        url: "profilim.aspx/MenuOkumaktaOlduklarimiGetir",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Okumakta Olduğum Kitaplar");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else {
                //alert("Başarısız");
            }
        },
        error: function () {

        }
    });
    return false;
}

function MenuOkuduklarimiGetir() {
    $.ajax({
        type: "POST",
        url: "profilim.aspx/MenuOkuduklarimiGetir",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Okuduğum Kitaplar");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else {
                //alert("Başarısız");
            }
        },
        error: function () {

        }
    });
    return false;
}

function MenuKutuphanemiGetir() {
    $.ajax({
        type: "POST",
        url: "profilim.aspx/MenuKutuphanemiGetir",
        cache: false,
        data: {},
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 1) {
                $(".baslik h2").html("Kütüphanem");
                $("#kullaniciProfilYorumlari").html(Tuple["Item2"]);
            }
            else {
                //alert("Başarısız");
            }
        },
        error: function () {

        }
    });
    return false;
}



function DropdownOkumaktaOlduklarimaEkle() {
    var KitapID = event.target.id;
    var KullaniciID = $("#ctl00_ContentPlaceHolder1_lblKullaniciID").text();
    $.ajax({
        type: "POST",
        url: "profilim.aspx/OkumaktaOlduklarimaEkle",
        cache: false,
        //data: JSON.stringify({ kutuphaneModel: Kutuphane }),
        data: "{KitapID:" + KitapID + ",KullaniciID:'" + KullaniciID + "'}",
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code === 1) {
                alert("Okumakta olduğunuz kitaplara eklenmiştir");
                MenuOkumaktaOlduklarimiGetir();
            }
            else {
                alert("Bu kitap okumakta olduğunuz kitaplarda mevcuttur.");
            }
        },
        error: function () {

        }
    });
    return false;
}

function DropdownOkuyacaklarimaEkle() {
    var KitapID = event.target.id;
    var KullaniciID = $("#ctl00_ContentPlaceHolder1_lblKullaniciID").text();
    $.ajax({
        type: "POST",
        url: "profilim.aspx/OkuyacaklarimaEkle",
        cache: false,
        data: "{KitapID:'" + KitapID + "',KullaniciID:'" + KullaniciID + "'}",
        //data: JSON.stringify({ kutuphaneModel: KutuphaneOgeleri }),
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code === 1) {
                alert("Okuyacağınız kitaplara eklenmiştir.");
                MenuOkuyacaklarimiGetir();
            }
            else {
                alert("Bu kitap okumakta olduğunuz kitaplarda mevcuttur.");
            }
        },
        error: function () {

        }
    });
    return false;
}

function DropdownOkuduklarimaEkle() {
    var KitapID = event.target.id;
    var KullaniciID = $("#ctl00_ContentPlaceHolder1_lblKullaniciID").text();
    $.ajax({
        type: "POST",
        url: "profilim.aspx/OkuduklarimaEkle",
        cache: false,
        data: "{KitapID:'" + KitapID + "',KullaniciID:'" + KullaniciID + "'}",
        //data: JSON.stringify({ kutuphaneModel: KutuphaneOgeleri }),
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code === 1) {
                alert("Okuduğunuz kitaplara eklenmiştir.");
                MenuOkuduklarimiGetir();
            }
            else {
                alert("Bu kitap okumakta olduğunuz kitaplarda mevcuttur.");
            }
        },
        error: function () {

        }
    });
    return false;
}

function DropdownKutuphanemeEkle() {
    var KitapID = event.target.id;
    var KullaniciID = $("#ctl00_ContentPlaceHolder1_lblKullaniciID").text();
    $.ajax({
        type: "POST",
        url: "profilim.aspx/KutuphanemeEkle",
        cache: false,
        data: "{KitapID:'" + KitapID + "',KullaniciID:'" + KullaniciID + "'}",
        //data: JSON.stringify({ kutuphaneModel: KutuphaneOgeleri }),
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code === 1) {
                alert("Kütüphanenize Eklenmiştir.");
            }
            else {
                alert("Bu kitap kütüphanenizde mevcuttur.");
            }
        },
        error: function () {

        }
    });
    return false;
}

function KitapSil() {
    var KitapID = event.target.id;
    var KullaniciID = $("#ctl00_ContentPlaceHolder1_lblKullaniciID").text();
    $.ajax({
        type: "POST",
        url: "profilim.aspx/KitapSil",
        cache: false,
        data: "{KitapID:'" + KitapID + "',KullaniciID:'" + KullaniciID + "'}",
        //data: JSON.stringify({ kutuphaneModel: KutuphaneOgeleri }),
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple.Code === 1) {
                alert("Kitap kaldırılmıştır.");
            }
            else {
                //alert("Bu kitap kütüphanenizde mevcuttur.");
            }
        },
        error: function () {

        }
    });
    return false;
}
