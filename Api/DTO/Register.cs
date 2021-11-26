using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTO
{
    public class Register
    {
        [Required]
        public string ad { get; set; }

        [Required]
        public string soyad { get; set; }

        [Required]
        public string mail { get; set; }

        [Required]
        public string parola { get; set; }

        [Required]
        public string tc { get; set; }
    }
}
