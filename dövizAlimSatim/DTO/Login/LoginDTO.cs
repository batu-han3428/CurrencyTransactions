﻿using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dövizAlimSatim.DTO.Login
{
    public class LoginDTO
    {
        public string Mail { get; set; }
        
        public string Password { get; set; }
    }
}
