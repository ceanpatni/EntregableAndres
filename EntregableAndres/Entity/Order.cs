﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntregableAndres.Entity
{
    public class Order
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
