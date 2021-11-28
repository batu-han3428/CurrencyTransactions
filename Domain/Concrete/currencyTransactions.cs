﻿using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class currencyTransactions : IcurrencyTransactions
    {
        public int userID { get; set; }
        public float dollar { get; set; }
        public float euro { get; set; }
        public float pound { get; set; }
        public virtual User user { get; set; }
    }
}
