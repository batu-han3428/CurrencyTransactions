using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class balance : Ibalance
    {
        public int userID { get; set; }
        public float amount { get; set; }
        public virtual User user { get; set; }
    }
}
