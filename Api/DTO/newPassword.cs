using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTO
{
    public class newPassword
    {
        [Required]
        public string mail { get; set; }

        [Required]
        public string password { get; set; }
    }
}
