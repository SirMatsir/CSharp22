using System;
using System.Collections.Generic;

namespace FinalProject320.Db
{
    public partial class InstrumentDb
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string ProductDescription { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public string ProductCategory { get; set; } = null!;
        public int ProductQuantity { get; set; }
    }
}
