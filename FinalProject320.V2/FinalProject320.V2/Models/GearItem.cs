using System.ComponentModel.DataAnnotations;

namespace FinalProject320.V2.Models
{
    public class GearItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int ProductCount { get; set; }
    }
}
