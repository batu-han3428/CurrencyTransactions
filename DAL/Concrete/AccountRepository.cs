﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Domain.Concrete;
using Domain.Contexts;
using Domain.Methods;

namespace DAL.Concrete
{
    public class AccountRepository: IAccountRepository
    {
        SqlDbContext<User> context;
        public AccountRepository()
        {
            context = new SqlDbContext<User>();
        }
       
        public string login(User user)
        {         
            return context.takeAction(user, "login", processType.Select);
        }

        public string register(User user)
        {          
            return context.takeAction(user, "register", processType.Insert); ;
        }

        public string resetPassword(User user)
        {            
            return context.takeAction(user, "resetPassword", processType.Insert);
        }

        public string newPassword(User user)
        {
            return context.takeAction(user, "newPassword", processType.Update);
        }

    }
}
