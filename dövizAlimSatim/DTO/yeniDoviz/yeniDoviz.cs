using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dövizAlimSatim.DTO.yeniDoviz
{
    public class yeniDoviz
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

        public string Update_Date { get; set; }
        public IcerikDoviz USD { get; set; }
        public IcerikDoviz EUR { get; set; }
        public IcerikDoviz GBP { get; set; }
    }
}
