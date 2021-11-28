using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dövizAlimSatim.ViewModels
{
    public class movements
    {
        public int id { get; set; }
        public int userID { get; set; }
        public bool wallet { get; set; }
        public bool currency { get; set; }
        public bool buySell { get; set; }
        public float amount { get; set; }
        public DateTime date { get; set; }
        public virtual currencyTransactions currencyTransactions { get; set; }
    }
}
