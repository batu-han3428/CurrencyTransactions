using System;
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
    public class WalletRepository : IWalletRepository
    {
        SqlDbContext<balance> context;
        public WalletRepository()
        {
            context = new SqlDbContext<balance>();
        }      
       
        public string wallet(balance balance)
        {
            return context.takeAction(balance, "updateBalance", processType.Update);
        }
    }
}
