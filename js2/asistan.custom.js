var rootPath = findRootPath();
var SirketCookie = null;
var SmsSablonuKullanacakTurler = "";
$("#BtnPhoneKapali").live("click", function () {
    $.cookie("TelefonuKapat", 1);
});
$("#BtnPhoneCevapla").live("click", function () {
    $.cookie("TelefonuCevapla", 1);
});
$(function () {

    $('#PhoneButtonSlide li').stop().animate({ 'marginLeft': '-65px' }, 1000);

    $('#PhoneButtonSlide > li').hover(
        function () {
            $($(this)).stop().animate({ 'marginLeft': '-2px' }, 200);

            $($(this)).stop().animate({ 'marginLeft': '-2px' }, 200);
        },
        function () {
            $($(this)).stop().animate({ 'marginLeft': '-65px' }, 200);
        }
    );
});

$.fn.imgdata = function (key) {
    return this.find('.dataImg li:eq(' + key + ')').text();
}
$.fn.hdata = function (key) {
    return this.find('.dataSet li:eq(' + key + ')').text();
}
var buttonActions = {
    'close_windows': function () {
        ResetForm();
        $.fancybox.close();
      
      
        $("form").validationEngine('hideAll');
        $(".tipsy").hide();
    }
}
var Base64 = {
    _keyStr: "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=", encode: function (e) { var t = ""; var n, r, i, s, o, u, a; var f = 0; e = Base64._utf8_encode(e); while (f < e.length) { n = e.charCodeAt(f++); r = e.charCodeAt(f++); i = e.charCodeAt(f++); s = n >> 2; o = (n & 3) << 4 | r >> 4; u = (r & 15) << 2 | i >> 6; a = i & 63; if (isNaN(r)) { u = a = 64 } else if (isNaN(i)) { a = 64 } t = t + this._keyStr.charAt(s) + this._keyStr.charAt(o) + this._keyStr.charAt(u) + this._keyStr.charAt(a) } return t }, decode: function (e) {
        var t = ""; var n, r, i; var s, o, u, a; var f = 0;
        e = e.replace(/\++[++^A-Za-z0-9+/=]/g, ""); while (f < e.length) { s = this._keyStr.indexOf(e.charAt(f++)); o = this._keyStr.indexOf(e.charAt(f++)); u = this._keyStr.indexOf(e.charAt(f++)); a = this._keyStr.indexOf(e.charAt(f++)); n = s << 2 | o >> 4; r = (o & 15) << 4 | u >> 2; i = (u & 3) << 6 | a; t = t + String.fromCharCode(n); if (u != 64) { t = t + String.fromCharCode(r) } if (a != 64) { t = t + String.fromCharCode(i) } } t = Base64._utf8_decode(t); return t
    }, _utf8_encode: function (e) { e = e.replace(/\r\n/g, "n"); var t = ""; for (var n = 0; n < e.length; n++) { var r = e.charCodeAt(n); if (r < 128) { t += String.fromCharCode(r) } else if (r > 127 && r < 2048) { t += String.fromCharCode(r >> 6 | 192); t += String.fromCharCode(r & 63 | 128) } else { t += String.fromCharCode(r >> 12 | 224); t += String.fromCharCode(r >> 6 & 63 | 128); t += String.fromCharCode(r & 63 | 128) } } return t }, _utf8_decode: function (e) { var t = ""; var n = 0; var r = c1 = c2 = 0; while (n < e.length) { r = e.charCodeAt(n); if (r < 128) { t += String.fromCharCode(r); n++ } else if (r > 191 && r < 224) { c2 = e.charCodeAt(n + 1); t += String.fromCharCode((r & 31) << 6 | c2 & 63); n += 2 } else { c2 = e.charCodeAt(n + 1); c3 = e.charCodeAt(n + 2); t += String.fromCharCode((r & 15) << 12 | (c2 & 63) << 6 | c3 & 63); n += 3 } } return t }
}
$(document).ready(function () {
    try
    {
        // if ($.cookie("SirketCookie") != null) {
        //SirketCookie = JSON.parse(Base64.decode($(".lblSa").text()));
        //  SirketCookie = JSON.parse($.cookie("SirketCookie"));
        // alert(SirketCookie.SmsSablonuKullanacakTurler);
        //   }
    }
    catch (err)
    {}
   
    $(".dropDown1").chosen();

    $.ajaxSetup({
        cache: false
    });

    // Tabs
    $("ul.tabs li").fadeIn(400);
    $("ul.tabs li:first").addClass("active").fadeIn(400);
    $(".tab_content:first").fadeIn();
    $("ul.tabs li").live('click', function () {
        $("ul.tabs li").removeClass("active");
        $(this).addClass("active");
        var activeTab = $(this).find("a").attr("href");
        $('.tab_content').fadeOut();
        $(activeTab).delay(400).fadeIn();
        ResetForm();
        return false;
    });
    
    $(".ctrlf5").live('click', function () {
        location.reload(true);
    });
    // WYSIWYG Editor
    $("#editor,#editor2").cleditor();

    // Form validationEngine
    //	$('form.validation').validationEngine();		
    //	$('form.validation_demo').validationEngine();	

    // Input filter
    $('.numericonly input').autotab_magic().autotab_filter('numeric');
    $('.textonly input').autotab_magic().autotab_filter('text');
    $('.alphaonly input').autotab_magic().autotab_filter('alpha');
    $('.regexonly input').autotab_magic().autotab_filter({ format: 'custom', pattern: '[^0-9\.]' });
    $('.alluppercase input').autotab_magic().autotab_filter({ format: 'alphanumeric', uppercase: true });
    $('.multi').live('click', function (e) {
        $(this).parents().find(".multiselect-search").focus();
    });
});

$(function () {

   // LResize();
    //$(window).resize(function () { LResize(); Processgraph(); });
    //$(window).scroll(function () { scrollmenu(); });

    //Close_windows
    $('.butAcc').live('click', function (e) {
        if (buttonActions[this.id]) {
            buttonActions[this.id].call(this);
            
        }
        e.preventDefault();
    });

    //exam ui slider element
    $("#slider-range-min").slider({
        range: "min",
        value: 212,
        min: 1,
        max: 700,
        slide: function (event, ui) {
            $("#amount").text("$" + ui.value);
        }
    });
    $("#amount").text("$" + $("#slider-range-min").slider("value"));

    $("#slider-range").slider({
        range: true,
        min: 0,
        max: 500,
        values: [75, 300],
        slide: function (event, ui) {
            $("#amount2").text("$" + ui.values[0] + " - $" + ui.values[1]);
        }
    });
    $("#amount2").text("$" + $("#slider-range").slider("values", 0) + " - $" + $("#slider-range").slider("values", 1));

    $("#slider").slider({
        value: 100,
        min: 0,
        max: 500,
        step: 50,
        slide: function (event, ui) {
            $("#amount3").text("$" + ui.value);
        }
    });
    $("#amount3").text("$" + $("#slider").slider("value"));
    $("#eq > span").each(function () {
        // read initial values from markup and remove that
        var value = parseInt($(this).text(), 10);
        $(this).empty().slider({
            value: value,
            range: "min",
            animate: true,
            orientation: "vertical"
        });
    });
    $("#red, #green, #blue").slider({
        orientation: "horizontal",
        range: "min",
        max: 255,
        value: 127,
        slide: refreshSwatch,
        change: refreshSwatch
    });
    $("#red").slider("value", 190);
    $("#green").slider("value", 221);
    $("#blue").slider("value", 23);


    //autocomplete
    var availableTags = [
        "ActionScript",
        "AppleScript",
        "Asp",
        "BASIC",
        "C",
        "C++",
        "Clojure",
        "COBOL",
        "ColdFusion",
        "Erlang",
        "Fortran",
        "Groovy",
        "Haskell",
        "Java",
        "JavaScript",
        "Lisp",
        "Perl",
        "PHP",
        "Python",
        "Ruby",
        "Scala",
        "Scheme"
    ];
    $("#sAtcom").autocomplete({
        source: availableTags
    });

    //datepicker
    $("input.datepicker").datepicker({
        autoSize: true,
        appendText: '(dd-mm-yyyy)',
        dateFormat: 'dd-mm-yy'
    });
    $("div.datepickerInline").datepicker({
        dateFormat: 'dd-mm-yy',
        numberOfMonths: 1
    });
    $("input.birthday").datepicker({
        changeMonth: true,
        changeYear: true,
        dateFormat: 'dd-mm-yy'
    });


    //datetimepicker
    $(".datetimepk").datetimepicker({
        firstDay: 1 // Start with Monday
    });

    $('#timepicker').timepicker({});

    //Color picker 
    //$('#colorPicker').ColorPicker({
    //    color: '#a4d143',
    //    onShow: function (colpkr) {
    //        $(colpkr).fadeIn(500);
    //        return false;
    //    },
    //    onHide: function (colpkr) {
    //        $(colpkr).fadeOut(500);
    //        return false;
    //    },
    //    onChange: function (hsb, hex, rgb) {
    //        $('#colorPicker div').css('backgroundColor', '#' + hex);
    //    }
    //});
    //$('#colorPickerFlat').ColorPicker({ flat: true, color: '#a4d143' });
    //$('#colorpickerField,#bgColor').ColorPicker({
    //    onSubmit: function (hsb, hex, rgb, el) {
    //        $(el).val('#' + hex);
    //        $(el).ColorPickerHide();
    //        $('#colorpickerField,#bgColor').css('backgroundColor', '#' + hex);
    //    },
    //    onHide: function (colpkr) {
    //        $(colpkr).fadeOut(500);
    //        return false;
    //    },
    //    onChange: function (hsb, hex, rgb, el) {
    //        $('#colorpickerField,#bgColor').val('#' + hex);
    //        $('#colorpickerField,#bgColor').css('backgroundColor', '#' + hex);
    //    },
    //    onBeforeShow: function () {
    //        $(this).ColorPickerSetColor(this.value);
    //    }
    //}).bind('keyup', function () {
    //    $(this).ColorPickerSetColor(this.value);
    //});

    //$('#color').ColorPicker({
    //    onSubmit: function (hsb, hex, rgb, el) {
    //        $(el).val('#' + hex);
    //        $(el).ColorPickerHide();
    //        $('#color').css('backgroundColor', '#' + hex);
    //    },
    //    onHide: function (colpkr) {
    //        $(colpkr).fadeOut(500);
    //        return false;
    //    },
    //    onChange: function (hsb, hex, rgb, el) {
    //        $('#color').val('#' + hex);
    //        $('#color').css('backgroundColor', '#' + hex);
    //    },
    //    onBeforeShow: function () {
    //        $(this).ColorPickerSetColor(this.value);
    //    }
    //}).bind('keyup', function () {
    //    $(this).ColorPickerSetColor(this.value);
    //});


    //	//Button Click  Ajax Loading
    //	$('.loading').live('click',function() { 
    //		  var str=$(this).attr('title'); 
    //		  var overlay=$(this).attr('rel'); 
    //		  loading("Lütfen Bekleyiniz",overlay);
    //		  setTimeout("unloading()",1500); 
    //	  });
    	$('#preloader').live('click',function(){
    			unloading();
    	 });


    $('.searchAutocomplete').click(function () {
        $('.searchText').toggle('slow', function () {
            // Animation complete.
        });
    });
    // Submit Form 
    $('a.submit_form').live('click', function () {
        var form_id = $(this).parents('form').attr('id');
        $("#" + form_id).submit();
    })

    // Logout Click  

    // Wizard Steps 
    //$('#wizard').smartWizard();
    //$('#wizardvalidate').smartWizard();


    // Tipsy Tootip
    $('.tip a ').tipsy({ gravity: 's', live: true });
    $('.ntip a ').tipsy({ gravity: 'n', live: true });
    $('.wtip a ').tipsy({ gravity: 'w', live: true });
    $('.etip a,.Base').tipsy({ gravity: 'e', live: true });
    $('.netip a ').tipsy({ gravity: 'ne', live: true });
    $('.nwtip a  ').tipsy({ gravity: 'nw', live: true });
    $('.swtip a,.iconmenu li a ').tipsy({ gravity: 'sw', live: true });
    $('.setip a ').tipsy({ gravity: 'se', live: true });
    $('.wtip input').tipsy({ trigger: 'focus', gravity: 'w', live: true });
    $('.etip input').tipsy({ trigger: 'focus', gravity: 'e', live: true });
    $('.iconBox, div.logout').tipsy({ gravity: 'ne', live: true });

    // Maskedinput 
    $.mask.definitions['~'] = "[+-]";
    $(".date").mask("99-99-9999", { completed: function () { } });
    $(".datepicker").datepicker().mask("99-99-9999");
    $(".time").timepicker().mask("99:99");
    $(".phoneNum").mask("(999) 999-99-99");
    $(".gsmNum").mask("(999) 999-99-99");
    $(".tcNo").mask("99999999999");
    $("#phoneExt").mask("(999) 999-9999? x99999");
    $("#iphone").mask("+33 999 999 999");
    $("#tin").mask("99-9999999");
    $("#ssn").mask("999-99-9999");
    $("#product").mask("a*-999-a999", { placeholder: " " });
    $("#eyescript").mask("~9.99 ~9.99 999");
    $("#po").mask("PO: aaa-999-***");
    $("#pct").mask("99%", { completed: function () { Processgraph(); } });
    // Maskedinput
    function Processgraph() {
        var bar = $('.bar'), bw = bar.width(), percent = bar.find('.percent'), circle = bar.find('.circle'), ps = percent.find('span'),
            cs = circle.find('span'), name = 'rotate';
        var t = $('#pct'), val = t.val();
        if (val) {
            val = t.val().replace("%", "");

            if (val >= 0 && val <= 100) {
                var w = 100 - val, pw = (bw * w) / 100,
                    pa = { width: w + '%' },
                    cw = (bw - pw), ca = { "left": cw }
                ps.animate(pa);
                cs.text(val + '%');
                circle.animate(ca, function () {
                    circle.removeClass(name)
                }).addClass(name);
            } else {
                alert('range: 0 - 100');
                t.val('');
            }
        }
    }


    // Fancybox    

    $(".pop_box").fancybox({
        'showCloseButton': true,
        'centerOnScroll': true,
        'titleShow': false,
        'hideOnContentClick': false,
        'enableEscapeButton': false,
        'hideOnOverlayClick': false,
        'cache': false,
        'onStart': function () {
            $("form").validationEngine('hideAll');
            $(".tipsy").hide();
        },
        'preload': false,
        'autoSize': true,
    });
    $(".pop_img").fancybox({ 'showCloseButton': true, 'centerOnScroll': true, 'overlayOpacity': 0.8, 'padding': 0 });

    $('.albumImage').dblclick(function () {
        $("a[rel=glr]").fancybox({ 'showCloseButton': true, 'centerOnScroll': true, 'overlayOpacity': 0.8, 'padding': 0 });
        $(this).find('a').trigger('click');
    })
    function test(value) {
        alert("This rating's value is " + value);
    }

    // rating_star
    $("#rating_star").rating_star({
        rating_star_length: '10',
        rating_initial_value: '3'
    });

    // Profile webcam 
    //var camera = $('#camera'), screen = $('#screen');
    //webcam.set_api_url('upload.php');
    //screen.html(
    //    webcam.get_html(screen.width(), screen.height())
    //);
    //var shootEnabled = false;
    //$(".takeWebcam").click(function () {
    //    $(".webcam").show('blind');
    //    return false;
    //});
    //$("#closeButton").click(function () {
    //    $(".webcam").hide('blind');
    //    return false;
    //});
    //$('#takeButton').click(function () {
    //    if (!shootEnabled) {
    //        return false;
    //    }
    //    webcam.freeze();
    //    togglePane()
    //    return false;
    //});
    //$('#retakeButton').click(function () {
    //    webcam.reset();
    //    togglePane()
    //    return false;
    //});
    //$('#uploadAvatar').click(function () {
    //    webcam.upload();
    //    togglePane()
    //    webcam.reset();
    //    return false;
    //});
    //webcam.set_hook('onLoad', function () {
    //    shootEnabled = true;
    //});
    //webcam.set_hook('onError', function (e) {
    //    screen.html(e);
    //});
    //function togglePane() {
    //    var visible = $(' .buttonPane:visible:first');
    //    var hidden = $(' .buttonPane:hidden:first');
    //    visible.fadeOut('fast', function () {
    //        hidden.show();
    //    });
    //}


    // images  editor tranfer
    $('#reflect').click(function () {
        $('.animate').animate({ "reflect": true });
    });
    $('#reflectX').click(function () {
        $('.animate').animate({ "reflectX": true });
    });
    $('#reflectY').click(function () {
        $('.animate').animate({ "reflectY": true });
    });
    $('#reflectXY').click(function () {
        $('.animate').animate({ "reflectXY": true });
    });
    $('#reflectYX').click(function () {
        $('.animate').animate({ "reflectYX": true });
    });
    ///////////////////////////////////////////////////////////////////////////		

    // images  editor crop			
    //$('#target').Jcrop({
    //    bgFade: true,
    //    bgOpacity: .7,
    //    onChange: updateCoords,
    //    onSelect: updateCoords,
    //    aspectRatio: 4 / 3
    //}, function () {
    //    var bounds = this.getBounds();
    //    boundx = bounds[0];
    //    boundy = bounds[1];
    //    jcrop_api = this;
    //    var x1 = (boundx - 240) / 2;
    //    var y1 = (boundy - 180) / 2;
    //    var x2 = (x1 + 240);
    //    var y2 = (y1 + 180);
    //    jcrop_api.animateTo([x1, y1, x2, y2]);
    //});
    //function updateCoords(c) {
    //    $('#x').val(c.x);
    //    $('#y').val(c.y);
    //    $('#w').val(c.w);
    //    $('#h').val(c.h);
    //};
    ///////////////////////////////////////////////////////////////////////////

    // spinner options 
    var itemListspinner = [
        { url: "http://ejohn.org", title: "John Resig" },
        { url: "http://bassistance.de/", title: "J&ouml;rn Zaefferer" },
        { url: "http://snook.ca/jonathan/", title: "Jonathan Snook" },
        { url: "http://rdworth.org/", title: "Richard Worth" },
        { url: "http://www.paulbakaus.com/", title: "Paul Bakaus" },
        { url: "http://www.yehudakatz.com/", title: "Yehuda Katz" },
        { url: "http://www.azarask.in/", title: "Aza Raskin" },
        { url: "http://www.karlswedberg.com/", title: "Karl Swedberg" },
        { url: "http://scottjehl.com/", title: "Scott Jehl" },
        { url: "http://jdsharp.us/", title: "Jonathan Sharp" },
        { url: "http://www.kevinhoyt.org/", title: "Kevin Hoyt" },
        { url: "http://www.codylindley.com/", title: "Cody Lindley" },
        { url: "http://malsup.com/jquery/", title: "Mike Alsup" }
    ];

    var optionspinner = {
        'sDec': { decimals: 2 },
        'sMinMax': { min: -100, max: 100 },
        'sStep': { stepping: 0.25 },
        'sCur': { currency: '$' },
        'sInline': {},
        'sLink': {
            init: function (e, ui) {
                for (var i = 0; i < itemListspinner.length; i++) {
                    ui.add('<a href="' + itemListspinner[i].url + '" target="_blank">' + itemListspinner[i].title + '</a>');
                }
            },
            format: '<a href="%(url)" target="_blank">%(title)</a>',
            items: itemListspinner
        }
    };
    for (var n in optionspinner) {
        $("#" + n).spinner(optionspinner[n]);
    }


    // Sortable
    $("#picThumb").sortable({
        opacity: 0.6, handle: '.move', connectWith: '.picThumbUpload', items: '.picThumbUpload'
    });
    $("#main_menu").sortable({
        opacity: 0.6, connectWith: '.limenu', items: '.limenu'
    });
    $("#sortable").sortable({
        opacity: 0.6, revert: true, cursor: "move", zIndex: 9000
    });


    // Effect 
    $('.SEclick, .SEmousedown, .SEclicktime,.SEremote,.SEremote2,.SEremote3,.SEremote4').jrumble();
    $('.SE').jrumble({
        x: 2,
        y: 2,
        rotation: 1
    });

    $('.alertMessage.error ').jrumble({
        x: 10,
        y: 10,
        rotation: 4
    });

    $('.alertMessage.success').jrumble({
        x: 4,
        y: 0,
        rotation: 0
    });

    $('.alertMessage.warning').jrumble({
        x: 0,
        y: 0,
        rotation: 5
    });

    $('.SE').hover(function () {
        $(this).trigger('startRumble');
    }, function () {
        $(this).trigger('stopRumble');
    });

    $('.SEclick').toggle(function () {
        $(this).trigger('startRumble');
    }, function () {
        $(this).trigger('stopRumble');
    });

    $('.SEmousedown').bind({
        'mousedown': function () {
            $(this).trigger('startRumble');
        },
        'mouseup': function () {
            $(this).trigger('stopRumble');
        }
    });

    $('.SEclicktime').click(function () {
        var demoTimeout;
        $this = $(this);
        clearTimeout(demoTimeout);
        $this.trigger('startRumble');
        demoTimeout = setTimeout(function () { $this.trigger('stopRumble'); }, 1500)
    });
    $('.SEremote').hover(function () {
        $('.SEremote2').trigger('startRumble');
    }, function () {
        $('.SEremote2').trigger('stopRumble');
    });

    $('.SEremote2').hover(function () {
        $('.SEremote').trigger('startRumble');
    }, function () {
        $('.SEremote').trigger('stopRumble');
    })

    $('.SEremote3').hover(function () {
        $('.alertMessage').trigger('startRumble');
    }, function () {
        $('.alertMessage').trigger('stopRumble');
    })

    $('.SEremote4').hover(function () {
        $('.alertMessage.error').trigger('startRumble');
    }, function () {
        $('.alertMessage.error').trigger('stopRumble');
    })


    // Dual select boxes
    //$.configureBoxes();

    // Textareaelastic
    //$('#Textareaelastic').elastic();

    // Textarea limit
    $('.textAreaAdresLimit').limit('500', '.limitchars');


    // placeholder text 
    $('input[placeholder], textarea[placeholder]').placeholder();

    // Checkbox 
    $('.ck,.chkbox,.checkAll ,input:radio').customInput();

    // Checkbox Limit
    $('.limit3m').limitInput({ max: 3, disablelabels: true });

    // Select boxes
    //	$(function() {
    //        $(' select').not("select.chzn-select,select[multiple],select#box1Storage,select#box2Storage").selectmenu({
    //            style: 'dropdown',
    //            transferClasses: true,
    //            width: null
    //        });
    //    });

    // Select boxes in Data table
    $(".dataTables_wrapper .dataTables_length select").addClass("small");
    $("table tbody tr td:first-child .custom-checkbox:first-child").css("margin: 0px 3px 3px 3px");

    // Mutiselection


    // Checkbox iphoneStyle
    $(".on_off_checkbox").iphoneStyle();  // Label On / Off

    $(".show_email").iphoneStyle({  //  Custom Label 
        checkedLabel: "show Email",
        uncheckedLabel: "Don't show ",
        labelWidth: '85px'
    });
    $(".preOrder").iphoneStyle({  //  Custom Label 
        checkedLabel: "in stocks",
        uncheckedLabel: "out stocks",
        labelWidth: '76px'
    });
    $(".online").iphoneStyle({  //  Custom Label 
        checkedLabel: "online",
        uncheckedLabel: "offline ",
        labelWidth: '55px'
    });
    $(".show_conmap").iphoneStyle({ //  Custom Label  With  onChange function
        checkedLabel: "show map",
        uncheckedLabel: "Don't show ",
        labelWidth: '85px',
        onChange: function () {
            var chek = $(".show_conmap").attr('checked');
            if (chek) {
                $(".disabled_map").fadeOut();
            } else {
                $(".disabled_map").fadeIn();
            }
        }
    });


    // Checkbox  All in Data Table
    $(".checkAll").live('click', function () {
        var table = $(this).parents('table').attr('id');
        var checkedStatus = this.checked;
        var id = this.id;
        $("table#" + table + " tbody tr td:first-child input:checkbox").each(function () {
            this.checked = checkedStatus;
            if (this.checked) {
                $(this).attr('checked', true);
                $('label[for=' + $(this).attr('id') + ']').addClass('checked ');
            } else {
                $(this).attr('checked', false);
                $('label[for=' + $(this).attr('id') + ']').removeClass('checked ');
            }
        });
    });

    // Checkbox  All Last coloumns in Data Table
    $(".checkAllLast").live('click', function () {
        var table = $(this).parents('table').attr('id');
        var checkedStatus = this.checked;
        var id = this.id;
        $("table#" + table + " tbody tr td:last-child input:checkbox").each(function () {
            this.checked = checkedStatus;
            if (this.checked) {
                $(this).attr('checked', true);
                $('label[for=' + $(this).attr('id') + ']').addClass('checked ');
            } else {
                $(this).attr('checked', false);
                $('label[for=' + $(this).attr('id') + ']').removeClass('checked ');
            }
        });
    });

    $(".chkbox").live('click', function () {
        var checkedStatus = this.checked;
        var id = $(this).attr('id');
        if (checkedStatus) {
            $(this).attr('checked', true);
            $('label[for=' + id + ']').addClass('checked ');
        }
        else {
            $(this).attr('checked', false);
            $('label[for=' + id + ']').removeClass('checked ');
        }
    });
    $(".chkboxp").live('click', function () {
        var checkedStatus = this.checked;
        var id = $(this).attr('id');
        if (checkedStatus) {
            $(this).attr('checked', true);
            $('label[for=' + id + ']').addClass('checked ');
        }
        else {
            $(this).attr('checked', false);
            $('label[for=' + id + ']').removeClass('checked ');
        }
    });

    $(".chkbox1").live('click', function () {
        var checkedStatus = this.checked;
        var id = $(this).attr('id');
        if (checkedStatus) {
            $(this).attr('checked', true);
            $('label[for=' + id + ']').addClass('checked ');
        }
        else {
            $(this).attr('checked', false);
            $('label[for=' + id + ']').removeClass('checked ');
        }
    });

    $(".chkbox2").live('click', function () {
        var checkedStatus = this.checked;
        var id = $(this).attr('id');
        if (checkedStatus) {
            $(this).attr('checked', true);
            $('label[for=' + id + ']').addClass('checked ');
        }
        else {
            $(this).attr('checked', false);
            $('label[for=' + id + ']').removeClass('checked ');
        }
    });





    // ShowCode 
    $('.showCode').sourcerer('js html css php');
    $('.showCodeJS').sourcerer('js');
    $('.showCodeHTML').sourcerer('html');
    $('.showCodePHP').sourcerer('php');
    $('.showCodeCSS').sourcerer('css');

    // icon  gray Hover
    $('.iconBox.gray').hover(function () {
        var name = $(this).find('img').attr('alt');
        $(this).find('img').animate({ opacity: 0.5 }, 0, function () {
            $(this).attr('src', rootPath + 'images/icon/color_18/' + name + '.png').animate({ opacity: 1 }, 700);
        });
    }, function () {
        var name = $(this).find('img').attr('alt');
        $(this).find('img').attr('src', rootPath + 'images/icon/gray_18/' + name + '.png');
    })

    // Animation icon  Logout 
    $('div.logout').hover(function () {
        var name = $(this).find('img').attr('alt');
        $(this).find('img').animate({ opacity: 0.4 }, 200, function () {
            $(this).attr('src', rootPath + 'images/' + name + '.png').animate({ opacity: 1 }, 500);
        });
    }, function () {
        var name = $(this).find('img').attr('name');
        $(this).find('img').animate({ opacity: 0.5 }, 200, function () {
            $(this).attr('src', rootPath + 'images/' + name + '.png').animate({ opacity: 1 }, 500);
        });
    })

    // Animation icon  setting 
    $('div.setting').hover(function () {
        $(this).find('img').addClass('gearhover');
    }, function () {
        $(this).find('img').removeClass('gearhover');
    })

    // shoutcutBox   Hover
    //	$('.shoutcutBox').hover(function(){
    //		  $(this).animate({ left: '+=15'}, 200);
    //	},function(){
    //		$(this).animate({ left: '0'}, 200);
    //	 })

    // shoutcutBox   Hover
    $("#shortcut li").hover(function () {
        var e = this;
        $(e).find("a").stop().animate({ marginTop: "-7px" }, 200, function () {
            $(e).find("a").animate({ marginTop: "-5px" }, 200);
        });
    }, function () {
        var e = this;
        $(e).find("a").stop().animate({ marginTop: "2px" }, 200, function () {
            $(e).find("a").animate({ marginTop: "0px" }, 200);
        });
    });



    // hide notify  Message with click
    $('#alertMessage').live('click', function () {
        $(this).stop(true, true).animate({ opacity: 0, right: '-20' }, 500, function () { $(this).hide(); });
    });

    // jScrollPane  Overflow
    $('#albumsList,.albumpics,.overflow,.todate').jScrollPane({ autoReinitialise: true });

    // images hover
    $('.picHolder,.SEdemo').hover(
          function () {
              $(this).find('.picTitle').fadeTo(200, 1);
          }, function () {
              $(this).find('.picTitle').fadeTo(200, 0);
          }
      )



    // Conversation box tool
    $('.msg').live({
        mouseenter: function () {
            $(this).find('.toolMsg').show();
        }, mouseleave: function () {
            $(this).find('.toolMsg').hide();
        }
    }
    );


    // filemanager. 
    // onload
    //$('#finder').elfinder({
    //    url: rootPath + 'components/elfinder/connectors/php/connector-fileimport.php',
    //    docked: true, dialog: { title: 'File manager', modal: true, width: 700 }
    //})
    // on click
    $('#filemanager').click(function () {
        var callback = $(this).attr('id');
        var type = $(this).attr('title');
        fileDialog(callback, type);
    });
    // on click callback
    $('#open_icon,#open_icon2,#open_icon3').click(function () {
        var callback = $(this).attr('id');
        var type = $(this).attr('title');
        var input = $(this).attr('rel');
        fileDialogCallback(callback, type, input);
    });
    // on focus  callback
    $('.fileDialog').live('focus', function () {
        var callback, input = $(this).attr('id');
        var type = $(this).attr('title');
        fileDialogCallback(callback, type, input);
    })


    // Confirm Delete.
    $(".Delete").live('click', function () {
        var row = $(this).parents('tr');
        var dataSet = $(this).parents('form');
        var id = $(this).attr("id");
        var name = $(this).attr("name");
        var data = 'id=' + id;
        Delete(data, name, row, 0, dataSet);
    });

    $(".DeleteAll").live('click', function () {
        var rel = $(this).attr('rel');
        alert(rel);
        var row = $(this).parents('.tab_content').attr('id');
        var row = row + ' .load_page ';
        if (!rel) {
            var rel = 0;
            var row = $('#load_data').attr('id');
        }
        var dataSet = $('form:eq(' + rel + ')');
        var data = $('form:eq(' + rel + ')').serialize();
        var name = $(".Delete").attr('name');
        Delete(data, name, row, 2, dataSet);
    });


    // Overlay form
    $(".on_load").live('click', function () {
        $('body').append('<div id="overlay"></div>');
        $('#overlay').css('opacity', 0.4).fadeIn(400);
        var activeLoad = $(this).attr("name");
        var titleTabs = $(this).attr("title");
        $("ul.tabs li").hide();
        $('ul.tabs li').each(function (index) {
            var activeTab = $('ul.tabs li:eq(' + index + ')').find("a").attr("href")
            if (activeTab == activeLoad) {
                $("ul.tabs ").append('<li class=active><a    href="' + activeLoad + '" class=" prev on_prev "  id="on_prev_pro" name="' + activeLoad + '" >' + titleTabs + '</a></li>');
                $("ul.tabs li:last").fadeIn();
            }
        });
        $('.widget .content').css({ 'position': 'relative', 'z-index': '1001' });
        $(".load_page").hide();
        $('.show_add').show();
    });
    $(".on_prev").live('click', function () {
        $("ul.tabs li:last").remove();
        $("ul.tabs li").fadeIn();
        var pageLoad = $(this).attr("rel");
        var activeLoad = $(this).attr("name");
        $(".show_add, .show_edit").hide();
        $(".show_edit").html('').hide();
        $(activeLoad).fadeIn();
        $(' .load_page').fadeIn(400, function () {
            $('#overlay').fadeOut(function () {
                $('.widget .content').delay(500).css({ 'z-index': '', 'box-shadow': '', '-moz-box-shadow': '', '-webkit-box-shadow': '' });
            });
        });
        ResetForm();
    });

    // Calendar 
    var date = new Date();
    var d = date.getDate();
    var m = date.getMonth();
    var y = date.getFullYear();
    $('#calendar').fullCalendar({
        header: {
            left: 'title',
            center: 'prev,next  ',
            right: 'today month,basicWeek,agendaDay'
        },
        buttonText: {
            prev: 'Previous',
            next: 'Next '
        },
        editable: true,
        refetchEvents: 'refetchEvents',
        selectable: true,
        selectHelper: true,
        dayClick: function (date, allDay, jsEvent, view) {
            var nDate = $.fullCalendar.formatDate(date, 'd');
            var dDate = $.fullCalendar.formatDate(date, 'dddd ');
            var fullDate = $.fullCalendar.formatDate(date, ' MMMM , yyyy');
            $('#calendar .fc-header-title h2').html('<div class="dateBox"><div class="nD">' + nDate + '</div><div class="dD">' + dDate + '<div class="fullD">' + fullDate + '</div><div></div><div class="clear"></div>');
        },
        events: 'https://www.google.com/calendar/feeds/zicedemo%40gmail.com/public/basic',
        eventClick: function (event) {
            // opens events in a popup window
            window.open(event.url, 'gcalevent', 'width=700,height=600');
            return false;
        },
        loading: function (bool) {
            if (bool) {
                loading('loading');
            } else {
                unloading();
            }
        }
    });



    // CHARTS        
    $("table.chart").each(function () {
        var colors = [];
        var height = $(this).height();
        $("table.chart thead th:not(:first)").each(function () {
            colors.push($(this).css("color"));
        });

        $(this).graphTable({
            series: 'columns',
            position: 'replace',
            width: '96%',
            height: '423px',
            colors: colors
        }, {
            xaxis: { tickSize: 1 },
            yaxis: {
                max: 1000,
                min: 0,
            }, series: {
                points: { show: true },
                lines: { show: true, fill: true, steps: false },
            }
        });
    });
    $("table.chart2").each(function () {
        var colors = [];
        $("table.chart thead th:not(:first)").each(function () {
            colors.push($(this).css("color"));
        });
        $(this).graphTable({
            series: 'columns', position: 'replace', width: '100%', height: '300px', colors: colors
        }, {
            xaxis: { tickSize: 1, },
            yaxis: {
                max: 1000,
                min: 200,
            }, series: {
                points: { show: true },
                lines: { show: true, fill: true, steps: false },
            }
        });
    });
    //	$("table.chart-pie").each(function() {
    //        var colors = [];
    //        $("table.chart-pie thead th:not(:first)").each(function() {
    //            colors.push($(this).css("color"));
    //        });
    //        $(this).graphTable({
    //            series: 'columns',
    //            position: 'replace',
    //			  width : '100%',
    //            height: '325px',
    //            colors: colors
    //        }, {
    //		series: {
    //            pie: { 
    //                show: true,
    //				innerRadius: 0.5,
    //                radius: 1,
    //				tilt: 1,
    //                label: {
    //                    show: true,
    //                    radius: 1,
    //                    formatter: function(label, series){
    //                        return '<div id="tooltipPie"><b>'+label+'</b> : '+Math.round(series.percent)+'%</div>';
    //                    },
    //                    background: { opacity: 0 }
    //                }
    //            }
    //        },
    //        legend: {
    //            show: false
    //        },
    //			grid: {
    //				hoverable: false,
    //				autoHighlight: true
    //			}
    //        });
    //    });


    $("table.chart-line").each(function () {
        var colors = [];
        $("table.chart-line thead th:not(:first)").each(function () {
            colors.push($(this).css("color"));
        });
        $(this).graphTable({
            series: 'columns', position: 'replace', width: '99%', height: '350px', colors: colors
        }, {
            xaxis: { tickSize: 3 },
            series: {
                points: { show: true },
                lines: { show: true, fill: false, steps: false },
                bars: { show: false, barWidth: 0.6 },
            },
            yaxis: {
                max: 1000,
                min: 0,
            }
        });
    });
    $("table.chart-bar").each(function () {
        var colors = [];
        $("table.chart-bars thead th:not(:first)").each(function () {
            colors.push($(this).css("color"));
        });
        $(this).graphTable({
            series: 'columns',
            position: 'replace',
            width: '100%',
            height: '350px',
            colors: colors
        }, {
            xaxis: {
                tickSize: 1
            },
            series: {
                bars: {
                    show: true,
                    lineWidth: 1,
                    barWidth: 0.7,
                    fill: true,
                    fillColor: null,
                    align: "center",
                    horizontal: false
                },
                lines: {
                    show: false
                },
                points: {
                    show: false
                }
            },
            yaxis: {
                max: null,
                autoscaleMargin: 0.02
            }
        });
    });


    function showTooltip(x, y, contents) {
        $('<div id="tooltip" >' + contents + '</div>').css({
            position: 'absolute',
            display: 'none',
            top: y - 13,
            left: x + 10
        }).appendTo("body").show();
    }

    var previousPoint = null;
    $(".chart_flot").bind("plothover", function (event, pos, item) {

        $("#x").text(pos.x);
        $("#y").text(pos.y);

        if (item) {
            if (previousPoint != item.dataIndex) {
                previousPoint = item.dataIndex;

                $(this).attr('title', item.series.label);
                $(this).trigger('click');
                $("#tooltip").remove();
                var x = item.datapoint[0],
                    y = item.datapoint[1];

                showTooltip(item.pageX, item.pageY, "<b>" + item.series.label + "</b> : " + y);
            }
        } else {
            $("#tooltip").remove();
            previousPoint = null;
        }
    });


});


// Check browser fixbug
var mybrowser = navigator.userAgent;
if (mybrowser.indexOf('MSIE') > 0) {
    $(function () {
        $('.formEl_b fieldset').css('padding-top', '0');
        $('div.section label small').css('font-size', '10px');
        $('div.section  div .select_box').css({ 'margin-left': '-5px' });
      //  $('.iPhoneCheckContainer label').css({ 'padding-top': '6px' });
        $('.uibutton').css({ 'padding-top': '6px' });
        $('.uibutton.icon:before').css({ 'top': '1px' });
        $('.dataTables_wrapper .dataTables_length ').css({ 'margin-bottom': '10px' });
    });
}
if (mybrowser.indexOf('Firefox') > 0) {
    $(function () {
        $('.formEl_b fieldset  legend').css('margin-bottom', '0px');
        $('table .custom-checkbox label').css('left', '3px');
    });
}
if (mybrowser.indexOf('Presto') > 0) {
    $('select').css('padding-top', '8px');
}
if (mybrowser.indexOf('Chrome') > 0) {
    $(function () {
        $('div.tab_content  ul.uibutton-group').css('margin-top', '-40px');
        $('div.section  div .select_box').css({ 'margin-top': '0px', 'margin-left': '-2px' });
        $('select').css('padding', '6px');
        $('table .custom-checkbox label').css('left', '3px');
    });
}
if (mybrowser.indexOf('Safari') > 0) { }


function fileDialogCallback(callback, type, input) {
    $('<div id="finder_' + callback + '"/>').elfinder({
        url: rootPath + 'components/elfinder/connectors/php/connector-' + type + '.php', editorCallback: function (url) {
            $('#' + input).val(url);
        }, closeOnEditorCallback: true, dialog: { title: 'File manager', modal: true, width: 700 }
    })
}
function fileDialog(callback, type) {
    $('<div id="finder_' + callback + '"/>').elfinder({
        url: rootPath + 'components/elfinder/connectors/php/connector-' + type + '.php', dialog: { title: 'File manager', modal: true, width: 700 }
    })
}


function Delete(data, name, row, type, dataSet) {
    var loadpage = dataSet.hdata(0);
    var url = dataSet.hdata(1);
    var table = dataSet.hdata(2);
    var data = data + "&tabel=" + table;
    $.confirm({
        'title': 'Onay Mesajı', 'message': " <strong>Aşağıdaki Kayıtları Silmek İstiyor musunuz ? </strong><br /><font color=red>' " + name + " ' </font> ", 'buttons': {
            'Yes': {
                'class': 'special',
                'action': function () {
                    loading('Lütfen Bekleyiniz...');
                    $('#preloader').html('Deleting...');
                    if (type == 0) { row.slideUp(function () { showSuccess('Success', 5000); unloading(); }); return false; }
                    if (type == 1) { row.slideUp(function () { showSuccess('Success', 5000); unloading(); }); return false; }
                    setTimeout("unloading();", 300);
                }
            }, 'No': { 'class': '' }
        }
    });
}

function ResetForm() {
    $('form').each(function (index) {
        var form_id = $('form:eq(' + index + ')').attr('id');
        if (form_id && form_id != 'aspnetForm') {
        $('#' + form_id).get(0).reset();
        $('#' + form_id).validationEngine('hideAll');
        var editor = $('#' + form_id).find('#editor').attr('id');
        if (editor) {
            $('#editor').cleditor()[0].clear();
        }
    }
    });
        $('.ui-dialog').find('input:text, input:password, input:file, select, textarea').val('');
        $('.ui-dialog').find('input:radio, input:checkbox').removeAttr('checked').removeAttr('selected');
    
}
function ResetFormParameter(KapsayiciDiv) {
    $('form #' + KapsayiciDiv).each(function (index) {
        var form_id = $('form:eq(' + index + ')').attr('id');
        if (form_id && form_id != 'aspnetForm') {
            $('#' + form_id).get(0).reset();
            $('#' + form_id).validationEngine('hideAll');
            var editor = $('#' + form_id).find('#editor').attr('id');
            if (editor) {
                $('#editor').cleditor()[0].clear();
            }
        }
    });
    $('.ui-dialog').find('input:text, input:password, input:file, select, textarea').val('');
    $('.ui-dialog').find('input:radio, input:checkbox').removeAttr('checked').removeAttr('selected');

}
function hexFromRGB(r, g, b) {
    var hex = [
        r.toString(16),
        g.toString(16),
        b.toString(16)
    ];
    $.each(hex, function (nr, val) {
        if (val.length === 1) {
            hex[nr] = "0" + val;
        }
    });
    return hex.join("").toUpperCase();
}
function refreshSwatch() {
    var red = $("#red").slider("value"),
        green = $("#green").slider("value"),
        blue = $("#blue").slider("value"),
        hex = hexFromRGB(red, green, blue);
    $("#swatch").css("background-color", "#" + hex);
}

function showError(str, delay) {
    $('#alertMessage').removeClass('error success info warning').addClass('error').html(str).stop(true, true).show().animate({ opacity: 1, right: '0' }, 300);
    setTimeout("hideTop();", delay);
}

function showSuccess(str, delay) {
    $('#alertMessage').removeClass('error success info warning').addClass('success').html(str).stop(true, true).show().animate({ opacity: 1, right: '0' }, 300);
    setTimeout("hideTop();", delay);
}

function showWarning(str, delay) {
    $('#alertMessage').removeClass('error success info warning').addClass('warning').html(str).stop(true, true).show().animate({ opacity: 1, right: '0' }, 300);
    setTimeout("hideTop();", delay);
}

function showInfo(str, delay) {
    $('#alertMessage').removeClass('error success info warning').addClass('info').html(str).stop(true, true).show().animate({ opacity: 1, right: '0' }, 300);
    setTimeout("hideTop();", delay);
}

function hideTop() {
    $('#alertMessage').animate({ opacity: 0, right: '-20' }, 500, function () { $(this).hide(); });
    $('.formError').remove();
}

function loading(name) {
    $('body').append('<div id="overlay"></div><div id="preloader">' + name + '..</div>');
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

function imgRow() {
    var maxrow = $('.albumpics').width();
    if (maxrow) {
        maxItem = Math.floor(maxrow / 160);
        maxW = maxItem * 160;
        mL = (maxrow - maxW) / 2;
        $('.albumpics ul').css({
            'width': maxW,
            'marginLeft': mL
        })
    }
}

function scrollmenu() {
    if ($(window).scrollTop() >= 1) {
        $("#header ").css("z-index", "50");
    } else {
        $("#header ").css("z-index", "47");
    }
}

function LResize() {
    imgRow();
    scrollmenu();
    $("#shadowhead").show();
    if ($(window).width() <= 480) {
        $(' .albumImagePreview').show();
        $('.screen-msg').hide();
        $('.albumsList').hide();
    }
    if ($(window).width() <= 768) {
        $('body').addClass('nobg');
        $('#content').css({ marginLeft: "70px" });
        $('#main_menu').removeClass('main_menu').addClass('iconmenu');
        $('#main_menu li').each(function () {
            var title = $(this).find('b').text();
            $(this).find('a').attr('title', title);
        });
        $('#main_menu li a').find('b').hide();
        $('#main_menu li ').find('ul').hide();
    } else {
        $('body').removeClass('nobg')
        $('#content').css({ marginLeft: "240px" });
        $('#main_menu').removeClass('iconmenu ').addClass('main_menu');
        $('#main_menu li a').find('b').show();
    }
    //if ($(window).width() > 1024) {
    //    //	$('#main_menu').removeClass('iconmenu ').addClass('main_menu');
    //    //	$('#main_menu li a').find('b').show();	
    //}
}
function escapeChars(unsafe) {
    if (unsafe != null && unsafe != "" && unsafe != "undefined")
        return unsafe.replace(/'/g, "&#039;").replace(/\\/g, "\\\\");
    else
        return unsafe;
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
function startsWith(haystack, needle, isCaseSensitive) {

    if (isCaseSensitive) {

        haystack = haystack.toUpperCase();
        needle = needle.toUpperCase();

    }

    return haystack.substr(0, needle.length) == needle ? true : false;
}

var entityMap = {
    "'": '&#39;',
    '"': '&quot;'
};

function escapeHtml(string) {
    return String(string).replace(/[&<>"'\/]/g, function (s) {
        return entityMap[s];
    });
}

function trim(stringToTrim) {
    return stringToTrim.replace(/^\s+|\s+$/g, "");
}
function ltrim(stringToTrim) {
    return stringToTrim.replace(/^\s+/, "");
}
function rtrim(stringToTrim) {
    return stringToTrim.replace(/\s+$/, "");
}

function keyPressed(e) {
    var key;
    if (window.event)
        key = window.event.keyCode; //IE
    else
        key = e.which; //firefox      

    if (key != 13)
        return key;
    else
        return false;

}

function disableButton(btn) {
    if ($("#" + btn).attr('disabled') == 'disabled')
        return false;
    else {
        $("#" + btn).attr('disabled', 'disabled');
        return true;
    }
}

function enableButton(btn) {
    $("#" + btn).removeAttr("disabled");
}

function parseJsonDate(jsonDateString) {
    return new Date(parseInt(jsonDateString.replace('/Date(', '')));
}

function ConvertToDate(value) {
    return value.substring(6) + "-" + value.substring(3, 5) + "-" + value.substring(0, 2);
}

function findRootPath() {
    var pathName1 = "/" + location.pathname.split('/')[1] + "/";
    var pathName2 = location.pathname.substring(0, location.pathname.lastIndexOf('/') + 1);

    if (pathName1 != pathName2)
        return "../";

    return "";
}
function SayfaAdiniVer() {
    var pagePathName = window.location.pathname;
    return pagePathName.substring(pagePathName.lastIndexOf("/") + 1);
}
