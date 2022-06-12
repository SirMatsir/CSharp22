using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace FinalProject320.Db
{
    public partial class Gear : IEnumerable, IQueryable
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the item name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the item description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the per-item value")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter the item category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter the item quantity")]
        public int ProductCount { get; set; }

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
