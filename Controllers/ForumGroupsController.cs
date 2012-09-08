using Restfinity.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity.Blogs.Model;
using Telerik.Sitefinity.Forums;
using Telerik.Sitefinity.Forums.Model;
using Telerik.Sitefinity.Modules.Blogs;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class ForumGroupsController : BaseApiController<ForumGroup, ForumGroupRestModel, ForumsManager>
    {
        public override ForumsManager GetManager()
        {
            return ForumsManager.GetManager();
        }

        public override IEnumerable<ForumGroup> GetAll()
        {
            return this.GetManager().GetGroups();
        }

        public override ForumGroup GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetGroup(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override ForumGroupRestModel ConvertToRestModel(ForumGroup item)
        {
            ForumGroupRestModel restModel = new ForumGroupRestModel()
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description
            };
            return restModel;
        }
    }
}
