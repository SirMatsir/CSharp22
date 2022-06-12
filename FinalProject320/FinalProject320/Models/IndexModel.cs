using FinalProject320.Db;
using System.Collections;
using System.Linq.Expressions;

namespace FinalProject320.Models
{
    public class IndexModel
    {
        public string searchStr { get; set; }
        public IList<Gear> GearItems { get; set; }

        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
