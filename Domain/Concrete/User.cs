using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;

namespace Domain.Concrete
{
    public class User : IUser
    {
        [Key]
        public int id { get; set; }
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
        [Required]
        public DateTimeOffset kayitTarihi { get; set; }
    }
}
