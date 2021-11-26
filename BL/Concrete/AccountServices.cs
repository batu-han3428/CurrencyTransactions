using BL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;
using Domain.Concrete;

namespace BL.Concrete
{
    public class AccountServices : IAccountServices
    {
        private IAccountRepository _AccountRepository;

        public AccountServices(IAccountRepository AccountRepository)
        {
            _AccountRepository = AccountRepository;
        }

        public string login(User user)
        {
            string result = _AccountRepository.login(user);

            if (result == "")
            {
                return "Mail veya Parola hatalı";
            }
            else
            {
                return result;
            }
             
        }
        public string register(User user)
        {
            
            return _AccountRepository.register(user);
        }
    }
}
