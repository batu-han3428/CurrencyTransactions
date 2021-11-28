using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface Imovements
    {
        int id { get; set; }
        int userID { get; set; }
        bool wallet { get; set; }
        bool currency { get; set; }
        bool buySell { get; set; }
        float amount { get; set; }
        DateTime date { get; set; }
        abstract List<User> user { get; set; }
    }
}
