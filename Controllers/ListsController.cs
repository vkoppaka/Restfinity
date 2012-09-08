using Restfinity.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity.Lists.Model;
using Telerik.Sitefinity.Modules.Lists;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class ListsController : BaseApiController<List, ListRestModel, ListsManager>
    {
        public override ListsManager GetManager()
        {
            return ListsManager.GetManager();
        }

        public override IEnumerable<List> GetAll()
        {
            return this.GetManager().GetLists();
        }

        public override List GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetList(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override ListRestModel ConvertToRestModel(List item)
        {
            ListRestModel restModel = new ListRestModel()
            {
                Id = item.Id,
                Title = item.Title.Value,
                Description = item.Description,
                Status = item.Status,
                Url = item.UrlName.Value
            };
            return restModel;
        }
    }
}
