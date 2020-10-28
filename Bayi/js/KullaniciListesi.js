var KitapOptions = {
    aranacakKelime: '',
    sayfaBasiKayitSayisi: 150,
    sayfa: 1,
    toplamKayitSayisi: 0,
    KitapTürID: null,
    durum: null
}

$(document).ready(function () {

    KitaplariGetir();
    $(".pageContainer").hide();
    setTimeout('Listele();', 500);
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
                    $('#pgGaleriListesi #ddlMarkalar').children().remove();
                    $("#pgGaleriListesi #ddlMarkalar").append($("<option>").val("").html("TÜMÜ"));
                    var x = Tuple["Item2"];
                    $.each(Tuple["Item3"], function (i, item) {
                        $("#pgGaleriListesi #ddlMarkalar").append($("<option selected=\"selected\">").val(item.ID).html(item.KitapTürü));
                    });
                    $("#pgGaleriListesi #ddlMarkalar").trigger("liszt:updated");
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

function Listele() {
    $('#tblAraclar tbody').html("<tr>"
        + "<td colspan=\"10\" style='text-align:center'>"
        //+ "<img alt=\"\" src=\"../images/loadder/loader_green.gif\" />"
        + "<i class=\"fa fa-spinner fa-pulse fa-2x fa-fw darkblue\"></i><span class=\"sr-only\">Yükleniyor...</span><br />"
        + "</td>"
        + "</tr>");
      Filtre();
    $.ajax({
        type: "POST",
        url: "Kullanicilar.aspx/Listele",
        cache: false,
        data: JSON.stringify({ aramaKriterleri: KitapOptions }),
        contentType: "application/json; charset=utf-8",
        datatype: "json",
        success: function (msg) {
            var Tuple = msg.d;
            if (Tuple["Item1"]["Code"] === 56) {
                UsersOptions.toplamKayitSayisi = Tuple["Item2"];
                PagingUsers(Tuple["Item3"]);

            }
            else if (Tuple["Item1"]["Code"] === 85) {
                location.href = "login.aspx";
            }
            else {
                $(".pageContainer").hide();
                $('#tblAraclar tbody').html("<tr>"
                    + "<td colspan=\"10\" style='text-align:center'>"
                    + Tuple["Item1"]["Description"]
                    + "</td>"
                    + "</tr>");
            }
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            $(".pageContainer").hide();
            $('#tblAraclar tbody').html("<tr>"
                + "<td colspan=\"10\" style='text-align:center'>"
                + "Hata : " + XMLHttpRequest.status + " " + XMLHttpRequest.statusText
                + "</td>"
                + "</tr>");
        }
    });
    return false;
}

   
function Filtre() {
    //if ($("#pgKullaniciListesi #ddlAramaDurum").val() === "")
    //    UsersOptions.durum = null;
    //else
    KitapOptions.toplamKayitSayisi = 0;
    KitapOptions.KitapTürID = $("#pgGaleriListesi #ddlMarkalar").val();
    KitapOptions.aranacakKelime = $("#pgGaleriListesi #txtSearchText").val();


}


// paging - load sayfalama
function PagingUsers(Items) {
    $("#Pagination").paging(UsersOptions.toplamKayitSayisi, {
        format: '[< nncnnnn >]',
        perpage: UsersOptions.sayfaBasiKayitSayisi,
        lapping: 0,
        page: UsersOptions.sayfa,
        onSelect: function (page) {
            $(".pageContainer").hide();
            $('#tblAraclar tbody').html("<tr>"
                + "<td colspan=\"10\" style='text-align:center'>"
                //+ "<img alt=\"\" src=\"../images/loadder/loader_green.gif\" />"
                + "<i class=\"fa fa-spinner fa-pulse fa-2x fa-fw darkblue\"></i><span class=\"sr-only\">Yükleniyor...</span><br />"
                + "</td>"
                + "</tr>");

            if (page !== UsersOptions.sayfa) {
                UsersOptions.sayfa = page;
                Listele();
                return false;
            }
            LoadUsers(Items);
        },
        onFormat: function (type) {
            switch (type) {
                case 'block':
                    if (this.value !== this.page)
                        return '<a href="#" class="paginate_button">' + this.value + '</a>';
                    else
                        return '<a href="#" class="paginate_active">' + this.value + '</a>';
                case 'next': // >
                    return '<a href="#" class="next paginate_button"><span class="iconc-forward3"></span></a>';
                case 'prev': // <
                    return '<a href="#" class="previous paginate_button"><span class="iconc-backward2"></span></a>';
                case 'first': // [
                    return '<a href="#" class="first paginate_button"><span class="iconc-first"></span></a>';
                case 'last': // ]
                    return '<a href="#" class="last paginate_button"><span class="iconc-last"></span></a>';
            }
        }
    });
}
function LoadUsers(Items) {
    $(".pageContainer").show();
    $("#tblAraclar tbody").html(Items);
    $(".toplamKayitSayisi").html(UsersOptions.toplamKayitSayisi);
    $(".gosterilenMin").html(((parseInt(UsersOptions.sayfaBasiKayitSayisi) * parseInt(UsersOptions.sayfa)) + 1) - parseInt(UsersOptions.sayfaBasiKayitSayisi));
    if (parseInt(UsersOptions.sayfaBasiKayitSayisi) * parseInt(UsersOptions.sayfa) < parseInt(UsersOptions.toplamKayitSayisi))
        $(".gosterilenMax").html(parseInt(UsersOptions.sayfaBasiKayitSayisi) * parseInt(UsersOptions.sayfa));
    else
        $(".gosterilenMax").html(parseInt(UsersOptions.toplamKayitSayisi));
}


// temizle butonu
$("#pgGaleriListesi #btnClearSearch").live('click', function (e) {
    e.preventDefault();
    if (e.handled === true) return false;
    e.handled = true;

    if (disableButton("btnClearSearch")) {
        AracOptions.aranacakKelime = "";
        $("#pgGaleriListesi .pageContainer").hide();
        $('#pgGaleriListesi #tblAraclar tbody').html("<tr>"
            + "<td colspan=\"10\" style='text-align:center'>"
            + "<div class=\"dataTables_info\">"
            //+ "<img alt=\"\" src=\"../images/loadder/loader_green.gif\" />"
            + "<i class=\"fa fa-spinner fa-pulse fa-2x fa-fw darkblue\"></i><span class=\"sr-only\">Yükleniyor...</span><br />"
            + "</div>"
            + "</td>"
            + "</tr>");

        $("#txtSearchText").val("");
        Listele();
        enableButton("btnClearSearch");
    }
    else
        return false;
});

