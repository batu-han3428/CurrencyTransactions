using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IuserResetPassword
    {
        int userID { get; set; }
        int resetCode { get; set; }
        DateTime codeDate { get; set; }
        abstract User user { get; set; }
    }
}
