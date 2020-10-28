$(document).ready(function () { $(".dropDown1").chosen();

    $('#logout').click(function () {
        loading("Lütfen Bekleyiniz");

        $.ajax({
            type: "POST",
            url: "Default.aspx/LogoutSystem",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (msg) {
                if (msg.d.Code == 56) {
                    $.cookie("asistanCookies", null);
                    $.cookie("HizliAramaKapanmaZamani", null);
                    setTimeout("window.location.href='" + "Login.aspx'", 250);
                }
                else {
                    showError(msg.d.Description, 3000);
                    $.cookie("HizliAramaKapanmaZamani", null);
                    setTimeout("unloading()", 1000);
                }
            },
            error: function (xhr) {
                showError("Hata : " + xhr.status + " " + xhr.statusText, 5000);
                $.cookie("HizliAramaKapanmaZamani", null);
                setTimeout("unloading()", 1000);
            }
        });
    });

});

function SayiYuvarla(value, decPlaces) {
    return Math.round(value * Math.pow(10, decPlaces)) / Math.pow(10, decPlaces);
}

