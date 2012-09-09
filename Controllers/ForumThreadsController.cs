using Restfinity.Models.Content;
using System;
using System.Collections.Generic;
using Telerik.Sitefinity.Forums;
using Telerik.Sitefinity.Forums.Model;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class ForumThreadsController : MasterDetailApiController<ForumThread, ForumThreadRestModel, ForumsManager, Forum>
    {
        public override ForumsManager GetManager()
        {
            return ForumsManager.GetManager();
        }

        public override IEnumerable<ForumThread> GetAll()
        {
            return this.GetManager().GetThreads();
        }

        public override ForumThread GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetThread(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override IEnumerable<ForumThread> GetAllDetails(Guid id)
        {
            return this.GetManager().GetThreads(id);
        }

        public override ForumThreadRestModel ConvertToRestModel(ForumThread item)
        {
            ForumThreadRestModel restModel = new ForumThreadRestModel()
            {
                Id = item.Id,
                Title = item.Title,
                ThreadType = item.ThreadType,
                Url = item.UrlName.Value,
                PostsCount = item.PostsCount,
                ViewsCount = item.ViewsCount
            };
            return restModel;
        }
    }
}
