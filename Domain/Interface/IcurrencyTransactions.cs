using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IcurrencyTransactions
    {
        int userID { get; set; }
        float dollar { get; set; }
        float euro { get; set; }
        float pound { get; set; }
        abstract User user { get; set; }
    }
}
