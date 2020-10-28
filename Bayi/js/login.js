$(document).ready(function () {
    onfocus();
    $('.tip a ').tipsy({ gravity: 'sw' });
    $('#form-signin').show().animate({ opacity: 1 }, 100);

    $('.logo').show().animate({ opacity: 1, top: '36%' }, 400, function () {
        $('.logo').show().delay(500).animate({ opacity: 1, top: '1%' }, 200, function () {
            $('.formLogin').animate({ opacity: 1, left: '0' }, 200);
            $('.userbox').animate({ opacity: 0 }, 200).hide();
        });
    });
    $(".on_off_checkbox").iphoneStyle();
});

$("#btnGirisYap").click(function () {
 //   hideTop();
    if (disableButton("btnGirisYap")) {
        var FormValidate = $("#LoginModel").validationEngine('validate');
        if (FormValidate !== true) {
            enableButton("btnGirisYap");
            return false;
        }
        loading('Lütfen Bekleyiniz');
        var Username = escapeCharsHigh($('#username_id').val());
        var Password = escapeCharsHigh($('#password').val());

        // initializeRemember();
     
        $.ajax({
            type: "post",
            url: "Login.aspx/LoginSystem",
            data: "{Username:'" + Username + "',Password:'" + Password + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            success: function (msg) {
             
                var result = msg.d;
                if (result.Code === 56) {
                  
                    //if ($('#RememberMe').is(':checked') === true) {
                    //    $.cookie("asistanCookies", Username + " " + Password, { expires: 30 });
                    //}
                    //else {
                    //    $.cookie("asistanCookies", null);
                    //}
                    //if(Tuple["Item2"]===1)
                    setTimeout("window.location.href='Kullanicilar.aspx'", 250);
                    setTimeout('unloading();', 200);
                    enableButton("btnGirisYap");
                }
                else {
                    enableButton("btnGirisYap");
                    setTimeout('unloading();', 200);
                    showError(result.Description, 5000);
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert('hata');
                enableButton("btnGirisYap");
                setTimeout('unloading();', 200);
                showError("Hata : " + XMLHttpRequest.status + " " + XMLHttpRequest.statusText, 5000);
                //   alert(XMLHttpRequest.responseText);
            }
        });
    }
    else
        return false;
});


function disableButton(btn) {
    if ($("#" + btn).attr('disabled') === 'disabled')
        return false;
    else {
        $("#" + btn).attr('disabled', 'disabled');
        return true;
    }
}

function enableButton(btn) {
    $("#" + btn).removeAttr("disabled");
}


$('#alertMessage').click(function () {
    hideTop();
});

function showError(str, delay) {
    $('#alertMessage').removeClass('error success info warning').addClass('error').html(str).stop(true, true).show().animate({ opacity: 1, right: '0' }, 300);
    setTimeout("hideTop();", delay);
}

function showSuccess(str, delay) {
    $('#alertMessage').removeClass('error success info warning').addClass('success').html(str).stop(true, true).show().animate({ opacity: 1, right: '0' }, 300);
    setTimeout("hideTop();", delay);
}

function onfocus() {
    if ($(window).width() > 480) {
        $('.sr-only input').tipsy({ trigger: 'focus', gravity: 'w', live: true });
    } else {
        $('.sr-only input').tipsy("hide");
    }
}

function hideTop() {
    $('#alertMessage').animate({ opacity: 0, right: '-20' }, 500, function () { $(this).hide(); });
    $('.formError').remove();
}
function loading(name) {
    $('body').append('<div id="overlay"></div><div id="preloader" style="display:inline-table">' + name + '..</div>');
    $('#overlay').css('opacity', 0.1).fadeIn(function () { $('#preloader').fadeIn(); });
    return false;
}

function unloading() {
    $('#preloader').fadeOut(function () {
        $(this).remove();
        $('#overlay').fadeOut(function () {
            $(this).delay(50).remove();
        });
    });
}

function escapeCharsHigh(unsafe) {
    return unsafe
        .replace(/&/g, "&amp;")
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/"/g, "&quot;")
        .replace(/'/g, "&#039;");
}

function trlocalize(str_data) {

    return str_data
        .replace(/Ã§/g, "ç")
        .replace(/ÄŸ/g, "ğ")
        .replace(/Ã¶/g, "ö")
        .replace(/Ã¼/g, "ü")
        .replace(/Ä±/g, "ı")
        .replace(/Ã‡/g, "Ç")
        .replace(/Ã–/g, "Ö")
        .replace(/Ãœ/g, "Ü")
        .replace(/Ä°/g, "İ")
        .replace(/Ä/g, "Ğ");
}

document.getElementById("eye").addEventListener("click", function (e) {
    var seePass = document.getElementById("password");
    if (seePass.getAttribute("type") === "password") {
        seePass.setAttribute("type", "text");
    } else {
        seePass.setAttribute("type", "password");
    }
});

function initializeRemember() {
    if ($('#chckRemember').is(':checked')) {
        localStorage.removeItem('userName');
        localStorage.removeItem('password');
        localStorage.removeItem('checkBoxValidation');
        localStorage.userName = escapeCharsHigh($('#username_id').val());
        localStorage.password = escapeCharsHigh($('#password').val());
        localStorage.checkBoxValidation = $('#chckRemember').val();
    }
    else {
        localStorage.clear();
    }

}

$("#username_id").keyup(function () {
    if (document.getElementById("username_id").value === localStorage.getItem("userName")) {
        $("#password").val(localStorage.getItem("password"));
    }
    document.getElementById("password").innerHTML = localStorage.getItem("password");
});