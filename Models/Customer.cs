﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace malshetwi_Project3_SDA.LMS.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        //Relations
        public List<Order> Order { get; set; }
    }
}
