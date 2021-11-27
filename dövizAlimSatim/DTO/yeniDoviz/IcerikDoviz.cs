using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dövizAlimSatim.DTO.yeniDoviz
{
    public class IcerikDoviz
    {
        //{
        //    "Update_Date":"2021-11-27 12:15:01",
        //    "USD":{
        //        "Buying":"12,2478",
        //        "Type":"Currency",
        //        "Selling":"12,4902",
        //        "Change":"%4,09"
        //    }
        //}
        public string Buying { get; set; }
        public string Type { get; set; }
        public string Selling { get; set; }
        public string Change { get; set; }
    }
}
