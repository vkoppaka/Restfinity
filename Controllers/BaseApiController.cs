using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Restfinity.Controllers
{
    public abstract class BaseApiController<TModel, TRestModel, TManager> : ApiController
    {
        public abstract IEnumerable<TModel> GetAll();
        public abstract TModel GetOne(Guid id);
        public abstract TRestModel ConvertToRestModel(TModel item);
        public abstract TManager GetManager();

        [HttpGet]
        public virtual IEnumerable<TRestModel> Get()
        {
            var items = this.GetAll();
            List<TRestModel> restItems = new List<TRestModel>();
            foreach (var item in items)
            {
                TRestModel restItem = ConvertToRestModel(item);
                restItems.Add(restItem);
            }

            return restItems.AsEnumerable();
        }

        [HttpGet]
        public virtual HttpResponseMessage Get(Guid id)
        {
            TModel item = this.GetOne(id);
            if (item == null)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "There is no item of type " + typeof(TModel) + " with ID " + id.ToString()));
            }

            TRestModel newsRestModel = ConvertToRestModel(item);

            return Request.CreateResponse(HttpStatusCode.OK, newsRestModel);
        }
    }
}
