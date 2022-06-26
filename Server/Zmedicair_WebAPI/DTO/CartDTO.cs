using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    //סל קניות
    public class CartDTO
    {
        public short ProductId { get; set; }
        public string ProductName { get; set; }
        public short Qty { get; set; }
        public double PricePerProduct { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
