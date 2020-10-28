using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Resim
/// </summary>

    namespace Resim_Model
{
    using System;
    [Serializable]
    public class Resim
    {
        public Resim()
        {

        }
        public int ID { get; set; }
        public string resim { get; set; }
    }
}