using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ErrorCodes
/// </summary>
public class ErrorCodes
{
    public int asistanCode { get; set; }
    public int ErrorCode { get; set; }
    public string ErrorCodeStr { get; set; }
    public string ErrorName { get; set; }
    public string ErrorDescription { get; set; }

    public static List<ErrorCodes> ErrorCodeList()
    {
        List<ErrorCodes> errorCodes = new List<ErrorCodes>();
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 0,
            ErrorCode = -1,
            ErrorName = "PROCESSING",
            ErrorDescription = "Paket işleniyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 1,
            ErrorCode = 2,
            ErrorName = "NOT_STARTED",
            ErrorDescription = "Gönderim başlamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 2,
            ErrorCode = 1,
            ErrorName = "NOT_CONFIRMED",
            ErrorDescription = "Gönderim onay bekliyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 3,
            ErrorCode = 4,
            ErrorName = "WAITING",
            ErrorDescription = "Şuanda gönderiliyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 4,
            ErrorCode = 3,
            ErrorName = "ABORTED",
            ErrorDescription = "Gönderim iptal edildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 5,
            ErrorCode = 10,
            ErrorName = "SUSPENDED",
            ErrorDescription = "Gönderim duraklatıldı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 6,
            ErrorCode = 5,
            ErrorName = "TO_RETRY",
            ErrorDescription = "Paket tekrar gönderilecek."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 7,
            ErrorCode = 7,
            ErrorName = "SUCCESSFUL",
            ErrorDescription = "Başarılı"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 8,
            ErrorCode = 8,
            ErrorName = "FAIL",
            ErrorDescription = "Başarısız"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 9,
            ErrorCode = 9,
            ErrorName = "FORWARD_DATED",
            ErrorDescription = "İleri tarihli paket"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 10,
            ErrorCode = 11,
            ErrorName = "SERVICE_FAILURE",
            ErrorDescription = "Engine gönderim esnasında hata oluştu."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 11,
            ErrorCode = -1,
            ErrorName = "SYSTEM_FAILURE",
            ErrorDescription = "Uzak sunucu ile bağlantı kurulamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 12,
            ErrorCode = 12,
            ErrorName = "READ",
            ErrorDescription = "Okundu."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 13,
            ErrorCode = 13,
            ErrorName = "FILE_DONE",
            ErrorDescription = "Text2Speech için ses dosyası oluşturuldu."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 14,
            ErrorCode = 14,
            ErrorName = "FILE_WAITING",
            ErrorDescription = "Text2Speech için dosya oluşturulması bekleniyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 15,
            ErrorCode = 15,
            ErrorName = "UNSUFFICIENT_CRE",
            ErrorDescription = "Paket gönderimi için kredi yetersiz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 16,
            ErrorCode = 16,
            ErrorName = "CREDIT_DEBT",
            ErrorDescription = "Paket borçlu durumdadır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 17,
            ErrorCode = 17,
            ErrorName = "TURKCELL_WAITING",
            ErrorDescription = "Gönderilen Sms Turkcell tarafında beklemede kaldı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 18,
            ErrorCode = 18,
            ErrorName = "INVALID_DESTINATION_FORMAT",
            ErrorDescription = "Hatalı format."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 19,
            ErrorCode = 19,
            ErrorName = "INVALID_MESSAGE_LENGTH",
            ErrorDescription = "Geçersiz mesaj uzunluğu"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 20,
            ErrorCode = 20,
            ErrorName = "WAITING_REPORT",
            ErrorDescription = "Rapor Bekleniyor"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 21,
            ErrorCode = 21,
            ErrorName = "BLACKLISTED",
            ErrorDescription = "Paket, göndericinin blacklist filtresine takıldı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 22,
            ErrorCode = -1,
            ErrorName = "UNAUTHORIZED_USER",
            ErrorDescription = "Kullanıcı veya hesap yetkisi yok."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 23,
            ErrorCode = 701,
            ErrorName = "AUTHENTICATION_FAILURE",
            ErrorDescription = "Girilen bilgilere sahip bir kullanıcı bulunamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 24,
            ErrorCode = 6,
            ErrorName = "INVALID_TEMPLATE_OR_ORIGINATOR",
            ErrorDescription = "Gönderici ya da şablon bilgisi geçersiz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 25,
            ErrorCode = 7,
            ErrorName = "NO_VALID_PHONENUMBER_TO_BE_SEND",
            ErrorDescription = "Geçerli herhangi bir alıcı telefon numarası bulunamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 26,
            ErrorCode = 8,
            ErrorName = "INVALID_VALIDITY_PERIOD",
            ErrorDescription = "ValidityPeriod değeri asgari(60) ve azami(3360) değerler arasında bulunmamaktadır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 27,
            ErrorCode = 11,
            ErrorName = "INPUT_PARAMETER_ERROR",
            ErrorDescription = "Alınan parametrelerden biri veya birkaçı hatalı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 28,
            ErrorCode = 14,
            ErrorName = "CONTAINS_PARAMETER_TEXT_BUT_NO_TEMPLATE_PARAMETER",
            ErrorDescription = "Parametreli gönderim olmadğı halde servise parametre listesi gönderildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 29,
            ErrorCode = 21,
            ErrorName = "DUPLICATED_CLIENTTRANSACTIONID",
            ErrorDescription = "Belirtilen clientTransactionId önceden kullanılmış."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 30,
            ErrorCode = 0,
            ErrorName = "INVALID_TEMPLATE_NAME",
            ErrorDescription = "Geçersiz şablon adı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 31,
            ErrorCode = 1,
            ErrorName = "INVALID_CONTENT_LENGTH",
            ErrorDescription = "Mesaj içeriği boş veya limit olan 612 karakterden fazla bulunmaktadır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 32,
            ErrorCode = 2,
            ErrorName = "TEMPLATE_NAME_ALREADY_EXISTS",
            ErrorDescription = "Mükerrer şablon adı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 33,
            ErrorCode = 3,
            ErrorName = "PARAMETER_COUNT_MISMATCH",
            ErrorDescription = "Parametre sayısı numara sayısı ile eşit değil."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 34,
            ErrorCode = 5,
            ErrorName = "INVALID_PARAMETER_COLUMN_NAME",
            ErrorDescription = "Parametre olarak geçersiz bir kolon adı girildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 35,
            ErrorCode = 9,
            ErrorName = "TEMPLATE_NOT_FOUND",
            ErrorDescription = "Şablon Bulunamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 36,
            ErrorCode = 11,
            ErrorName = "CONTAINS_PHONENUMBER_BUT_NO_PARAMETER_TEXT",
            ErrorDescription = "Parametreli gönderim : Telefon numarası mevcut – parametreler mevcut değil."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 37,
            ErrorCode = 12,
            ErrorName = "CONTAINS_PARAMETER_TEXT_BUT_NO_PHONENUMBER",
            ErrorDescription = "Parametreli gönderim : Telefon numarası mevcut değil – parametreler mevcut."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 38,
            ErrorCode = 13,
            ErrorName = "PARAMETER_TEXT_COUNT_PER_PHONENUMBER_MISMATCH",
            ErrorDescription = "Parametreli gönderim : parameterTextListForPhoneNumbers değişkeni ile gönderilen bazı listelerdeki parametre sayıları ile şablon içerisindeki parametre sayıları tutmuyor.",
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 39,
            ErrorCode = 15,
            ErrorName = "NO_PLAN_TYPE_FOUND_FOR_CUSTOMER",
            ErrorDescription = "Müşteri sms servisi için ödeme planına sahip değil."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 40,
            ErrorCode = 16,
            ErrorName = "INVALID_DATE_INPUT",
            ErrorDescription = "Tarih parametresi yanlış bir formatta girildi.(yyyy-MM-dd HH:mm)"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 41,
            ErrorCode = 17,
            ErrorName = "INVALID_SEND_DATE",
            ErrorDescription = "İleri tarihli gönderimlerde geçmiş tarih kullanılamaz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 42,
            ErrorCode = 18,
            ErrorName = "INVALID_ABORT_REQUEST",
            ErrorDescription = "İptal etmek istenilen gönderim tamamlanmamış olmak zorundadır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 43,
            ErrorCode = 20,
            ErrorName = "CLIENTPACKETIDLIST_PHONENUMBER_COUNT_MISMATCH",
            ErrorDescription = "ClientPacketIdList eleman sayısı telefon numarası sayısına eşit olmalıdır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 44,
            ErrorCode = 22,
            ErrorName = "INVALID_PARAMETER_IN_TEMPLATE",
            ErrorDescription = "Şablonda geçersiz parametre/parametreler mevcut."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 45,
            ErrorCode = 23,
            ErrorName = "NO_DESTINATION_SUPPLIED",
            ErrorDescription = "Geçerli herhangi bir telefon numarası bulunamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 46,
            ErrorCode = 24,
            ErrorName = "INVALID_SCHEDULING_PATTERN",
            ErrorDescription = "Zamanlanmış gönderim için geçersiz bir şablon girdiniz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 47,
            ErrorCode = 25,
            ErrorName = "NO_VALID_SCHEDULING_PATTERN",
            ErrorDescription = "Kişi ve gruplar için hiç bir geçerli zamanlanmış gönderim şablonu oluşturulamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 48,
            ErrorCode = 26,
            ErrorName = "INVALID_HOUR_OF_DAY",
            ErrorDescription = "Zamanlanmış gönderim için geçersiz bir saat bilgisi girildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 49,
            ErrorCode = 27,
            ErrorName = "INVALID_USAGE_SCHEDULINGPATTERN",
            ErrorDescription = "Zamanlanmış gönderimde gönderim şablonu için kolon belirtildiğinde , numara listesi kullanılamaz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 50,
            ErrorCode = 28,
            ErrorName = "INVALID_TIME_PARAMETER_TO_ANNUAL_SMS",
            ErrorDescription = "Özel günler için gönderilecek smslerde saat veya dakika yanlış formatta yazıldı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 51,
            ErrorCode = 30,
            ErrorName = "INVALID__COLUMN_NAME_FOR_ANNUAL_DATE",
            ErrorDescription = "Özel gün kuralı oluşturulurken girilen gönderim tarihinin alınacağı kolon ismi hatalı girildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 52,
            ErrorCode = 31,
            ErrorName = "INVALID_COLUMN_NAME_FOR_DESTINATION",
            ErrorDescription = "Özel gün kuralı oluşturulurken girilen DestinationColumnName parametresi hatalı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 53,
            ErrorCode = 32,
            ErrorName = "INVALID_COLUMNNAME_FOR_CSV",
            ErrorDescription = "CSV raporlama için verilen kolon isimlerinden biri hatalı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 54,
            ErrorCode = 33,
            ErrorName = "ANY_VALID_TRANSACTION_BE_FOUND_TO_PASSIVATE",
            ErrorDescription = "İptal edilecek geçerli herhangi bir zamanlanmış gönderim bulunamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 55,
            ErrorCode = 34,
            ErrorName = "PHONE_NUMBER_HAS_BEEN_BLACKLSITED",
            ErrorDescription = "Belirtilen telefon numarası karalistede bulunmaktadır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 56,
            ErrorCode = 0,
            ErrorName = "NO_ERROR",
            ErrorDescription = "İşlem başarıyla gerçekleştirildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 57,
            ErrorCode = 1,
            ErrorName = "SYSTEM_UNEXPECTED_ERROR",
            ErrorDescription = "Beklenmeyen bir hata oluştu."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 58,
            ErrorCode = 2,
            ErrorName = "SYSTEM_DB_CONNECT_ERROR",
            ErrorDescription = "Veritabanı bağlantısı kurulamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 59,
            ErrorCode = 12,
            ErrorName = "INPUT_XML_PARSE_ERROR",
            ErrorDescription = "XML ayrıştırılamadı, XML içeriği hatalı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 60,
            ErrorCode = 13,
            ErrorName = "INPUT_DECOMPRESSION_ERROR",
            ErrorDescription = "Sıkıştırılmış veri açılamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 61,
            ErrorCode = 14,
            ErrorName = "INPUT_DATE_PARSE_ERROR",
            ErrorDescription = "Date nesnesi ayrıştırılamadı. 'yyyy-MM-dd' formatını kullanınız."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 62,
            ErrorCode = 15,
            ErrorName = "SERVICE_ID_COULD_NOT_FOUND",
            ErrorDescription = "Servis Id parametresi hatalı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 63,
            ErrorCode = 16,
            ErrorName = "JSON_INPUT_PARAMETER_ERROR",
            ErrorDescription = "JSON parametrelerden bir ya da bir kaçı hatalı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 64,
            ErrorCode = 21,
            ErrorName = "ENTRY_NOT_FOUND",
            ErrorDescription = "Kayıt sistemde bulunmuyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 65,
            ErrorCode = 22,
            ErrorName = "ENTRY_DUPLICATE",
            ErrorDescription = "Aynı kayıt sistemde zaten mevcut."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 66,
            ErrorCode = 23,
            ErrorName = "ENTRY_HAS_MISSING_PARTS",
            ErrorDescription = "Kayıt sistemde fakat eksik bilgiler mevcut."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 67,
            ErrorCode = 31,
            ErrorName = "PERMISSION_NOTGRANTED",
            ErrorDescription = "Kullanım izni verilmemiş."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 68,
            ErrorCode = 32,
            ErrorName = "PERMISSION_UNSUFFICIENT_CUSTOMER_CREDIT",
            ErrorDescription = "Müşteri kredisi yeterli değil."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 69,
            ErrorCode = 33,
            ErrorName = "PERMISSION_UNSUFFICIENT_VENDOR_CREDIT",
            ErrorDescription = "Bayi kredisi yeterli değil."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 70,
            ErrorCode = 34,
            ErrorName = "INVALID_USER_NAME",
            ErrorDescription = "Kullanıcı adı Geçersiz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 71,
            ErrorCode = 35,
            ErrorName = "PERMISSION_NO_ACTIVE_CUSTOMER_CREDIT",
            ErrorDescription = "Müşterinin aktif kredi yüklemesi bulunmuyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 72,
            ErrorCode = 36,
            ErrorName = "PERMISSION_NO_ACTIVE_VENDOR_CREDIT",
            ErrorDescription = "Bayinin aktif kredi yüklemesi bulunmuyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 73,
            ErrorCode = 42,
            ErrorName = "NO_PLAN_TYPE_FOUND_FOR_CUSTOMER",
            ErrorDescription = "Müşterinin bu servis için plan tipi yok."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 74,
            ErrorCode = 43,
            ErrorName = "INVALID_CSV_COLUMN",
            ErrorDescription = "Geçersiz CSV kolon ismi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 75,
            ErrorCode = 44,
            ErrorName = "INVALID_OLD_PASSWORD",
            ErrorDescription = "Değiştirilmek istenen şifre geçersiz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 76,
            ErrorCode = 45,
            ErrorName = "SEND_EMAIL_FAILURE",
            ErrorDescription = "Email gönderiminde hata oluştu."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 77,
            ErrorCode = 46,
            ErrorName = "INVALID_EMAIL_ADDRESS",
            ErrorDescription = "Geçersiz Email adresi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 78,
            ErrorCode = 47,
            ErrorName = "INVALID_SERVICE_ID",
            ErrorDescription = "Geçersiz bir servis id girildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 79,
            ErrorCode = 48,
            ErrorName = "INVALID_PRIVATE_COLUMN",
            ErrorDescription = "Geçersiz özel tanımlı alan."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 80,
            ErrorCode = -999,
            ErrorName = "INVALID_GSM_NUMBERS",
            ErrorDescription = "Alıcı telefon numaralarından bir yada bir kaçı istenilen formatta değil."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 81,
            ErrorCode = -998,
            ErrorName = "INVALID_API_KEY",
            ErrorDescription = "Tanımsız / Hatalı ApiKey bilgisi girildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 82,
            ErrorCode = -997,
            ErrorName = "NO_FOUND_CUSTOMER_ACCOUNT",
            ErrorDescription = "Hatalı / yetkisiz AccountID bilgisi girildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 83,
            ErrorCode = -996,
            ErrorName = "ENTRY_DUPLICATE_CONFIRM",
            ErrorDescription = "Belirtilen TransactionId daha önce onaylanmış."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 84,
            ErrorCode = -995,
            ErrorName = "ENTRY_DUPLICATE_ABORT",
            ErrorDescription = "Belirtilen TransactionId daha önce iptal edilmiş."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 85,
            ErrorCode = -994,
            ErrorName = "NO_FOUND_SESSION",
            ErrorDescription = "Kullanıcı oturumu oluşturulamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 86,
            ErrorCode = -993,
            ErrorName = "AUTHENTICATION_FAILURE_BLOCK",
            ErrorDescription = "Girilen bilgilere ait kullanıcı bloke edildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 87,
            ErrorCode = 10,
            ErrorName = "CONTAINS_TCKNO_BUT_NO_PARAMETER_TEXT",
            ErrorDescription = "Parametreli gönderim : Tck numarası mevcut – parametreler mevcut değil."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 88,
            ErrorCode = 11,
            ErrorName = "CONTAINS_PARAMETER_TEXT_BUT_NO_TCK",
            ErrorDescription = "Parametreli gönderim : Tck numarası mevcut değil – parametreler mevcut."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 89,
            ErrorCode = 20,
            ErrorName = "CLIENTPACKETIDLIST_TCKNOS_COUNT_MISMATCH",
            ErrorDescription = "clientPacketIdList eleman sayısı tck numarası sayısına eşit olmalıdır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 90,
            ErrorCode = 21,
            ErrorName = "INVALID_CLIENTTRANSACTIONID",
            ErrorDescription = "Geçersiz clientTransactionId"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 91,
            ErrorCodeStr = "00",
            ErrorDescription = "Sistem Hatası"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 92,
            ErrorCodeStr = "23",
            ErrorDescription = "Kullanıcı Zaman Aşımında"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 93,
            ErrorCodeStr = "03",
            ErrorDescription = "Geçersiz içerik"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 94,
            ErrorCodeStr = "04",
            ErrorDescription = "Bilinmeyen SMS tipi"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 95,
            ErrorCodeStr = "06",
            ErrorDescription = "Mesaj metni ya da Alıcı bilgisi girilmemiş"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 96,
            ErrorCodeStr = "07",
            ErrorDescription = "İçerik uzun fakat Concat özelliği ayarlanmadığından mesaj birleştirilemiyor"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 97,
            ErrorCodeStr = "08",
            ErrorDescription = "Kullanıcının mesaj göndereceği gateway tanımlı değil ya da şu anda çalışmıyor"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 98,
            ErrorCodeStr = "09",
            ErrorDescription = "Yanlış tarih formatı.Tarih ddMMyyyyhhmm formatında olmalıdır"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 99,
            ErrorCodeStr = "11",
            ErrorDescription = "TC Kimlik No gönderim yetkisi bulunmamaktadır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 100,
            ErrorCodeStr = "3222",
            ErrorDescription = "Mükerrer içerik."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 101,
            ErrorCodeStr = "3225",
            ErrorDescription = "Encoding değeri hatalı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 102,
            ErrorCodeStr = "3223",
            ErrorDescription = "Veritabanı işlem hatası."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 103,
            ErrorCodeStr = "3224",
            ErrorDescription = "WebServis işlem hatası."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 104,
            ErrorCodeStr = "1400",
            ErrorDescription = "Geçersiz Command parametresi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 105,
            ErrorCodeStr = "1405",
            ErrorDescription = "Başlangıç tarihi, Bitiş tarihinden büyük olamaz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 106,
            ErrorCodeStr = "1420",
            ErrorDescription = "Kanal Kodu parametresi eksik."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 107,
            ErrorCodeStr = "1422",
            ErrorDescription = "Şifre Parametresi eksik."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 108,
            ErrorCode = 33,
            ErrorName = "ON_SENDER_FOR_RETRY",
            ErrorDescription = "Tekrar göndermek için ayarlanmış."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 109,
            ErrorCodeStr = "02",
            ErrorDescription = "Takip no hatalı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 110,
            ErrorCodeStr = "04",
            ErrorDescription = "Gönderim başarısız oldu."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 111,
            ErrorCodeStr = "05",
            ErrorDescription = "Gönderim devam ediyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 112,
            ErrorCodeStr = "06",
            ErrorDescription = "Geçersiz parametre."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 113,
            ErrorCodeStr = "07",
            ErrorDescription = "Takip no’ya ait gönderim bulunamadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 114,
            ErrorCodeStr = "08",
            ErrorDescription = "Gönderim kullanıcı tarafından iptal edilmiş."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 115,
            ErrorCodeStr = "09",
            ErrorDescription = "Geçersiz tarih formatı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 116,
            ErrorCode = 22,
            ErrorName = "REPEATING_DESTINATION",
            ErrorDescription = "Paket, mükerrer gönderim izni verilmediği için gönderilmedi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 117,
            ErrorCode = 25,
            ErrorName = "TURKCELL_INVALID_RESPONSE_ON_SENDER",
            ErrorDescription = "Paket için operatöre gönderim isteği yapıldı, geçerli bir cevap alınamadı. Paketlerin durumu bilinmiyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 118,
            ErrorCode = 26,
            ErrorName = "BUILD_XML_ERROR_ON_SENDER",
            ErrorDescription = "Paket operatöre gönderilemedi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 119,
            ErrorCode = 27,
            ErrorName = "SEND_ERROR_ON_SENDER",
            ErrorDescription = "Paketin operatöre gönderimi sırasında hata oluştu."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 120,
            ErrorCode = 28,
            ErrorName = "UPDATE_ERROR_ON_SENDER",
            ErrorDescription = "Paketin Turkcell e gönderimi yapıldı. Daha sonra yaşanan bir hata sebebiyle raporlama yapılamıyor."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 121,
            ErrorCode = 32,
            ErrorName = "ABORTED_BY_SCHEDULER",
            ErrorDescription = "Gönderimin takvimlendirme bitiş tarihi geçtiği için paketin gönderimi iptal edildi."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 123,
            ErrorCode = 99,
            ErrorName = "UNKNOWN",
            ErrorDescription = "Bilinmeyen hata."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 130,
            ErrorCode = 130,
            ErrorName = "Tekil gönderim limiti aşıldı. Toplu gönderimlerde aynı yada farklı mesaj metinlerinizi tek pakette gönderebilirsiniz.",
            ErrorDescription = "Tekil gönderim limiti aşıldı. Toplu gönderimlerde aynı yada farklı mesaj metinlerinizi tek pakette gönderebilirsiniz."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 131,
            ErrorCode = 131,
            ErrorName = "Single Shot Sms Gönderim Yetkiniz Bulunmamaktadır.",
            ErrorDescription = "Single Shot Sms Gönderim Yetkiniz Bulunmamaktadır."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 132,
            ErrorCode = 132,
            ErrorName = "İzin verilen sanal numara kalmadı.",
            ErrorDescription = "İzin verilen sanal numara kalmadı."
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 133,
            ErrorCode = 133,
            ErrorName = "TRANSIT_BAYI_KREDI_HATASI",
            ErrorDescription = "Transit limit aşımı nedeniyle gönderim başarısız oldu!"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 134,
            ErrorCode = 87,
            ErrorName = "INVALID_ORIGINATOR",
            ErrorDescription = "Alfanumerik Turkcell'de tanımlı değil!"
        });
        errorCodes.Add(new ErrorCodes()
        {
            asistanCode = 135,
            ErrorCode = 135,
            ErrorName = "PAKET_CAKISMASI",
            ErrorDescription = "Sistem hatası nedeniyle paketiniz gönderilemedi! Şimdi tekrar gönderebilirsiniz..."
        });
        return errorCodes;
    }

    public static List<ErrorCodes> TurkcellErrorList()
    {
        List<ErrorCodes> errorCodes = new List<ErrorCodes>();
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 0,
            ErrorDescription = "Numara Turkcell Network’ünde tanımlı değil",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 1,
            ErrorDescription = "Serviste geçici kesinti",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 2,
            ErrorDescription = "Serviste geçici kesinti",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 3,
            ErrorDescription = "Serviste geçici kesinti",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 4,
            ErrorDescription = "Serviste geçici kesinti",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 5,
            ErrorDescription = "Serviste geçici kesinti",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 6,
            ErrorDescription = "Serviste geçici kesinti",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 7,
            ErrorDescription = "Serviste geçici kesinti",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 8,
            ErrorDescription = "Serviste geçici kesinti",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 9,
            ErrorDescription = "Illegal error code",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 10,
            ErrorDescription = "Network time-out",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 87,
            ErrorDescription = "Alfanumerik Turkcell'de tanımlı değil.",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 100,
            ErrorDescription = "Facility not supported",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 101,
            ErrorDescription = "Numara Turkcell Network’ünde tanımlı değil",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 102,
            ErrorDescription = "Facility not provided",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 103,
            ErrorDescription = "SMS servis kullanımı kısıtlanmış",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 104,
            ErrorDescription = "Operation barred",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 105,
            ErrorDescription = "SC congestion",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 106,
            ErrorDescription = "Facility not supported",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 107,
            ErrorDescription = "Mobil istasyon kapalı",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 108,
            ErrorDescription = "Mesaj başarısız",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 109,
            ErrorDescription = "Sc congestion",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 110,
            ErrorDescription = "Protocol error",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 111,
            ErrorDescription = "MS not equipped",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 112,
            ErrorDescription = "Unknown SC",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 113,
            ErrorDescription = "SC congestion",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 114,
            ErrorDescription = "Mobil istasyonda sorun var",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 115,
            ErrorDescription = "MS not a subscriber",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 116,
            ErrorDescription = "Error in MS",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 117,
            ErrorDescription = "SMS lower layer not provisioned",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 118,
            ErrorDescription = "Sistem hatası",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 119,
            ErrorDescription = "PLMN system failure",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 120,
            ErrorDescription = "HLR system failure",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 121,
            ErrorDescription = "VLR system failure",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 122,
            ErrorDescription = "Previous VLR system failure",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 123,
            ErrorDescription = "Controlling MSC system failure",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 124,
            ErrorDescription = "VMSC system failure",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 125,
            ErrorDescription = "EIR system failure",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 126,
            ErrorDescription = "System failure",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 127,
            ErrorDescription = "Unexpected data value",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 200,
            ErrorDescription = "Error in address service centre",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 201,
            ErrorDescription = "Invalid absolute Validity Period",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 202,
            ErrorDescription = "Short message exceeds maximum",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 203,
            ErrorDescription = "Unable to Unpack GSM message",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 204,
            ErrorDescription = "Unable to convert to IRA ALPHABET",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 205,
            ErrorDescription = "Invalid validity period format",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 206,
            ErrorDescription = "Invalid destination address",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 207,
            ErrorDescription = "Duplicate message submit",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 208,
            ErrorDescription = "Invalid message type indicator",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = 300,
            ErrorDescription = "BOŞ İÇERİK NEDENİYLE GÖNDERİLEMEDİ!",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = -444,
            ErrorDescription = "Mesaj filtreleme nedeniyle reddedildi. (Abone istemiyor)",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = -426,
            ErrorDescription = "Kullanıcının mesaj göndermeye izni yok",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = -466,
            ErrorDescription = "Geçersiz Validity Period",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = -467,
            ErrorDescription = "TYPE = 2 verilmesine rağmen GSM 7 Bit Karakter içermeyen UZUN (concat) mesaj",
        });
        errorCodes.Add(new ErrorCodes()
        {
            ErrorCode = -470,
            ErrorDescription = "TCKN'e bir MSISDN bağlı değil / Geçersiz TCKN / Rehberde kayıtlı değil",
        });
        return errorCodes;
    }

    public static ErrorCodes GetErrorDesc(int asistanCode)
    {
        ErrorCodes result = new ErrorCodes();
        List<ErrorCodes> x = new List<ErrorCodes>();
        x = ErrorCodeList();
        bool islem = false;
        for (int i = 0; i < x.Count; i++)
        {
            if (asistanCode == x[i].asistanCode)
            {
                islem = true;
                result = x[i];
            }
        }
        if (!islem)
            result = x[57];
        return result;
    }

    public static ErrorCodes GetErrorDesc(string ErrorName)
    {
        ErrorCodes result = new ErrorCodes();
        List<ErrorCodes> x = new List<ErrorCodes>();
        x = ErrorCodeList();
        bool islem = false;
        for (int i = 0; i < x.Count; i++)
        {
            if (ErrorName == x[i].ErrorName)
            {
                islem = true;
                result = x[i];
            }
        }
        if (!islem)
            result = x[57];
        return result;
    }

    public static int GetasistanCodeWithErrorName(string ErrorName)
    {
        int asistanCode = 0;
        List<ErrorCodes> x = new List<ErrorCodes>();
        x = ErrorCodeList();
        bool islem = false;
        for (int i = 0; i < x.Count; i++)
        {
            if (ErrorName == x[i].ErrorName)
            {
                islem = true;
                asistanCode = x[i].asistanCode;
            }
        }
        if (!islem)
            asistanCode = x[57].asistanCode;
        return asistanCode;
    }

    public static string GetTurkcellErrorDesc(string ErrorCode)
    {
        string desc = ErrorCode;
        try
        {
            Convert.ToInt32(ErrorCode);
        }
        catch
        { return desc; }

        List<ErrorCodes> x = new List<ErrorCodes>();
        x = TurkcellErrorList();
        for (int i = 0; i < x.Count; i++)
        {
            if (Convert.ToInt32(ErrorCode) == x[i].ErrorCode)
            {
                desc = x[i].ErrorDescription;
            }
        }
        return desc;
    }
}
