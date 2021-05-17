﻿using System;

namespace OrderService.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ShipmentDate { get; set; }
    }
}
