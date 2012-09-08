using Restfinity.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using Telerik.Sitefinity.Blogs.Model;
using Telerik.Sitefinity.Lists.Model;
using Telerik.Sitefinity.Modules.Blogs;
using Telerik.Sitefinity.Modules.Lists;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class ListItemsController : MasterDetailApiController<ListItem, ListItemRestModel, ListsManager, List>
    {
        public override ListsManager GetManager()
        {
            return ListsManager.GetManager();
        }

        public override IEnumerable<ListItem> GetAll()
        {
            return this.GetManager().GetListItems();
        }
        
        public override IEnumerable<ListItem> GetAllDetails(Guid id)
        {
            return this.GetManager().GetListItems().Where(bp => bp.Parent.Id == id);
        }

        public override ListItem GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetListItem(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override ListItemRestModel ConvertToRestModel(ListItem item)
        {
            ListItemRestModel restModel = new ListItemRestModel()
            {
                Id = item.Id,
                Title = item.Title.Value,
                Description = item.Content.Value,
                Status = item.Status,
                Url = item.UrlName.Value
            };
            return restModel;
        }
    }
}
