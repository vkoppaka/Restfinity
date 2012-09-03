using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace Restfinity.Controllers
{
    public abstract class MasterDetailApiController<T, T1, T2, T3> :BaseApiController<T, T1, T2>
    {
        public abstract IEnumerable<T> GetAllDetails(Guid id);

        [HttpGet]
        public virtual IEnumerable<T1> GetDetailsOf(Guid id)
        {
            var items = this.GetAllDetails(id);
            List<T1> restItems = new List<T1>();
            foreach (var item in items)
            {
                T1 restItem = ConvertToRestModel(item);
                restItems.Add(restItem);
            }

            return restItems.AsEnumerable();
        }
    }
}
