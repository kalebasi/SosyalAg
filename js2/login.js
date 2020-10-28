var UyeKayit={
    Ad_Soyad:'',
    E_Mail: '',
    Sifre: ''
}
var Login = {
    E_Mail: '',
    Sifre: ''
}

$(document).ready(function () {
    $("#btnUyeol").click(function () {
        YeniKullaniciKayit();
    });
  
    //$("#btn").click(function () {
    //    alert("Butona tıklanıldı");
    //});

});

function YeniKullaniciKayit() {
    UyeKayit.Ad_Soyad = $("#isim").val();
    UyeKayit.E_Mail = $("#e_mail").val();
    UyeKayit.Sifre = $("#sifre").val();
    $.ajax({
        type: "POST",
        url: "uyeol.aspx/UyeKayit",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ uyekayit: UyeKayit }),
        dataType: "json",
        cache: false,
        success: function (msg) {
            var result = msg.d;
            if (result.Code === 1) {
                alert("Kaydınız Başarı İle Tamamlanmıştır");
                window.location.href = "login.aspx";
                setTimeout('unloading();', 200);
            }
            else if (result.Code===57) {
                alert("Bu E-Mail adresinde kayıt mevcuttur.Lütfen farklı bir e-mail adresi giriniz!");
                setTimeout('unloading();', 200);
            }
            else {
                alert("Bilgiler Boş Geçilemez");
                setTimeout('unloading();', 200);
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert("Geçersiz E-mail adresi girdiniz");
            showError("Hata : " + XMLHttpRequest.status + " " + XMLHttpRequest.statusText, 5000);
            setTimeout('unloading();', 200);
        }
    });
}

function OturumAc()
{
    Login.E_Mail = $("#email").val();
    Login.Sifre = $("#password").val();
    $.ajax({
        type:'POST',
        url: 'login.aspx/OturumAc',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify({ login: Login }),
        dataType: 'json',
        async: true,
        cache: false,
        success: function (msg) {
            var result = msg.d;
            if (result.Code === 1) {
                //setTimeout("window.location.href='kitaplik.aspx'", 250);
                setTimeout(window.location.href = "Kitaplik.aspx", 250);
                $("#btnKayitOl").fadeOut();
                $("#btnGirisYap").fadeOut();
                //setTimeout('unloading();', 200);
            }
            else if (result.Code === 0) {
                alert('E-mail veya şifrenizi hatalı girdiniz.');
            }
            //else {
            //    setTimeout('unloading();', 200);
            //    showError(result.Tanim, 5000);
            //}
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            setTimeout('unloading();', 200);
            showError("Hata : " + XMLHttpRequest.status + " " + XMLHttpRequest.statusText, 5000);
        }
    });
    return false;
}
