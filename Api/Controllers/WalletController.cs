using BL.Interface;
using Microsoft.AspNetCore.Mvc;
using Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.DTO;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : ControllerBase
    {
        private readonly IWalletServices _walletServices;

        public WalletController(IWalletServices walletServices)
        {
            _walletServices = walletServices;
        }

        [HttpPost("wallet")]
        public IActionResult wallet(Wallet wallet)
        {
            if (wallet != null)
            {
                balance balance = new balance();
                balance.userID = wallet.userID;
                balance.amount = wallet.amount;

                return Ok(_walletServices.wallet(balance));
            }
            else
            {
                return BadRequest(wallet);
            }
        }
    }
}
