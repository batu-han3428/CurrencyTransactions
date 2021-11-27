using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface IAccountServices
    {
        string login(User user);
        string register(User user);
        string resetPassword(User user);
        string newPassword(User user);
    }
}
