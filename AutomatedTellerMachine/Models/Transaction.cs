﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class Transaction
    {
        [Required]
        [DataType(DataType.Currency)]
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int CheckingAccountId { get; set; }
        public virtual CheckingAccount CheckingAccount { get; set; }
    }
}