﻿using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IAccountRepository
    {
        string login(User user);
        string register(User user);
        string resetPassword(User user);
        string newPassword(User user);
    }
}
