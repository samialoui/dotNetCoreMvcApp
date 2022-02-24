using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace dotNetCoreMvcApp
{
    public partial class TblBooks
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string Quantity { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public long CostPrice { get; set; }
        public long SellingPrice { get; set; }
        public string BarCode { get; set; }
        public string Remarks { get; set; }
    }
}
