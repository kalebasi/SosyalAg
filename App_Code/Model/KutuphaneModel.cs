using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneModel
{
    using KitaplarModel;
    using KullanicilarModel;
    using SonucModel;
    using System;
    [Serializable]
    public class Kutuphane
    {
        public Kutuphane()
        {

        }
       public int? ID { get; set; }
       public int? Kullanici_ID { get; set; }
       public int? OkuyacagimKitap_ID { get; set; }
       public int? OkumaktaOldugumKitap_ID { get; set; }
       public int? OkudugumKitap_ID { get; set; }
       public int? KutuphaneKitap_ID { get; set; }
       public virtual ResultModel Result { get; set; }
       public virtual Kullanicilar kullanici { get; set; }
    }
}