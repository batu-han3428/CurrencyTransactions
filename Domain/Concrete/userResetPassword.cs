using Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class userResetPassword : IuserResetPassword
    {
        [Key]
        public int userID { get; set; }

        public int resetCode { get; set; }
        public DateTime codeDate { get; set; }
        public virtual User user { get; set; }
    }
}
