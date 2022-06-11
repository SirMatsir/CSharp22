using System;
using System.Collections.Generic;

namespace FinalProject320.Db
{
    public partial class MusicGear
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string Category { get; set; } = null!;
        public int ProductCount { get; set; }
    }
}
