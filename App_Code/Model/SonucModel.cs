using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SonucModel
{
    using System;

    public class SonucModel
    {
        public SonucModel()
        {

        }
    }

    [Serializable]
    public class ResultModel
    {
        public int Code { get; set; }
        public string Tanim { get; set; }
    }

}