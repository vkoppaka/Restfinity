using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Restfinity.Controllers
{
    public abstract class BaseApiController<T, T1, T2> : ApiController
    {
        public abstract IEnumerable<T> GetAll();
        public abstract T GetOne(Guid id);
        public abstract T1 ConvertToRestModel(T item);
        public abstract T2 GetManager();

        [HttpGet]
        public virtual IEnumerable<T1> Get()
        {
            var items = this.GetAll();
            List<T1> restItems = new List<T1>();
            foreach (var item in items)
            {
                T1 restItem = ConvertToRestModel(item);
                restItems.Add(restItem);
            }

            return restItems.AsEnumerable();
        }

        [HttpGet]
        public virtual HttpResponseMessage Get(Guid id)
        {
            T item = this.GetOne(id);
            if (item == null)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "There is no item with that ID."));
            }

            T1 newsRestModel = ConvertToRestModel(item);

            return Request.CreateResponse(HttpStatusCode.OK, newsRestModel);
        }
    }
}
