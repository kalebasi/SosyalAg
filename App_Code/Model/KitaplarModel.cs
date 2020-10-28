using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KitaplarModel
{
    using System;
    [Serializable]
    public class Kitaplar
    {
        public Kitaplar()
        {

        }
        public int ID { get; set; }
        public string KitapTürü { get; set; }
    }
}