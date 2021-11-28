using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dövizAlimSatim.ViewModels
{
    public class User
    {
        
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string mail { get; set; }
        public string parola { get; set; }
        public string tc { get; set; }
        public DateTimeOffset kayitTarihi { get; set; }
        public virtual balance balance { get; set; }
    
    }
}
