using System;

namespace AdoNetFramework
{
    public class OrderTotalAmount
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime? Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
}