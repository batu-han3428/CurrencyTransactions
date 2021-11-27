using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IUser
    {
        int id { get; set; }
        string ad { get; set; }
        string soyad { get; set; }
        string mail { get; set; }
        string parola { get; set; }
        string tc { get; set; }
        DateTimeOffset kayitTarihi { get; set; }
        abstract userResetPassword UserResetPassword { get; set; }
    }
}
