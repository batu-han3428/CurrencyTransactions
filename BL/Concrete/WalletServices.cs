using Domain.Interface;
using BL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Concrete;
using DAL.Interface;

namespace BL.Concrete
{
    public class WalletServices:IWalletServices
    {
        private IWalletRepository _walletRepository;

        public WalletServices(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public string wallet(balance balance)
        {
            return _walletRepository.wallet(balance);
        }
    }
}
