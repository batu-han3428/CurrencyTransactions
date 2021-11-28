using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface Ibalance
    {
        int userID { get; set; }
        float amount { get; set; }
        abstract User user { get; set; }
    }
}
