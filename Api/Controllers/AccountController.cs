using Api.DTO;
using BL.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Concrete;
using System.Text.Json;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServices _accountServices;

        public AccountController(IAccountServices accountServices)
        {
            _accountServices = accountServices;
        }

        [HttpPost("login")]
        public IActionResult login(Login userDTO)
        {
            if (userDTO != null)
            {
                User user = new User();
                user.mail = userDTO.Mail;
                user.parola = userDTO.Password;

                return Ok(_accountServices.login(user));
            }
            else
            {
                return BadRequest(userDTO);
            }                      
        }

        [HttpPost("register")]
        public IActionResult register(Register registerDTO)
        {
            if (registerDTO != null)
            {
                User user = new User();
                user.ad = registerDTO.ad;
                user.soyad = registerDTO.soyad;
                user.mail = registerDTO.mail;
                user.parola = registerDTO.parola;
                user.tc = registerDTO.tc;

                return Ok(_accountServices.register(user));
            }
            else
            {
                return BadRequest(registerDTO);
            }
        }
    }
}
