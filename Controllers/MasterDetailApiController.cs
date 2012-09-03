using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace Restfinity.Controllers
{
    public abstract class MasterDetailApiController<TModel, TRestModel, TManager, TMasterModel> : BaseApiController<TModel, TRestModel, TManager>
    {
        public abstract IEnumerable<TModel> GetAllDetails(Guid id);

        [HttpGet]
        public virtual IEnumerable<TRestModel> GetDetailsOf(Guid id)
        {
            var items = this.GetAllDetails(id);
            List<TRestModel> restItems = new List<TRestModel>();
            foreach (var item in items)
            {
                TRestModel restItem = ConvertToRestModel(item);
                restItems.Add(restItem);
            }

            return restItems.AsEnumerable();
        }
    }
}
