using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Materials { get; set; }
        public decimal Price { get; set; }
    }
}
