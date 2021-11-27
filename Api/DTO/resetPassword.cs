using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTO
{
    public class resetPassword
    {
        [Required]
        public string mail { get; set; }
        [Required]
        public int resetCode { get; set; }
        [Required]
        public DateTime sendingDate { get; set; }
    }
}
