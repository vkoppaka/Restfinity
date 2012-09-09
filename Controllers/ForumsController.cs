using System;
using System.Collections.Generic;
using System.Linq;
using Restfinity.Models.Content;
using Telerik.Sitefinity.Forums;
using Telerik.Sitefinity.Forums.Model;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class ForumsController : MasterDetailApiController<Forum, ForumRestModel, ForumsManager, ForumGroup>
    {
        public override ForumsManager GetManager()
        {
            return ForumsManager.GetManager();
        }

        public override IEnumerable<Forum> GetAll()
        {
            return this.GetManager().GetForums();
        }

        public override Forum GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetForum(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }
      
        public override IEnumerable<Forum> GetAllDetails(Guid id)
        {
            return this.GetManager().GetForums(id);
        }

        public override ForumRestModel ConvertToRestModel(Forum item)
        {
            ForumRestModel restModel = new ForumRestModel()
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description,
                Url = item.UrlName.Value
            };
            return restModel;
        }
    }
}
