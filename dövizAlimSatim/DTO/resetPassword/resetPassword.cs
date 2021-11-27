using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dövizAlimSatim.DTO.resetPassword
{
    public class resetPassword
    {
        public string mail { get; set; }
        public int resetCode { get; set; }
        public DateTime sendingDate { get; set; }
    }
}
