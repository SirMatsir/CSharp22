using FinalProject320.Db;
using System.Collections;
using System.Collections.Generic;

namespace FinalProject320.Models
{
    public class SearchModel : IEnumerable
    {
        public IList<Gear> GearItems { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
