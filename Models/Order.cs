﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCodeFirstApproach.Models
{
    [Table("Order")]
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Order_ID { get; set; }
        public DateTime OrderDate { get; set; }
        [Column("OrderAmt")]
        public int Amount { get; set; }
        public Customer cust { get; set; } //navigation prop
    }  
}
