using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dövizAlimSatim.ViewModels
{
    public class balance
    {
        public int userID { get; set; }
        public float amount { get; set; }
        public virtual movements movements { get; set; }
    }
}
