using System;
using System.Collections.Generic;
using Restfinity.Models.Content;
using Telerik.Sitefinity.Forums;
using Telerik.Sitefinity.Forums.Model;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class ForumPostsController : MasterDetailApiController<ForumPost, ForumPostRestModel, ForumsManager, ForumThread>
    {
        public override ForumsManager GetManager()
        {
            return ForumsManager.GetManager();
        }

        public override IEnumerable<ForumPost> GetAll()
        {
            return this.GetManager().GetPosts();
        }

        public override ForumPost GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetPost(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override IEnumerable<ForumPost> GetAllDetails(Guid id)
        {
            return this.GetManager().GetPosts(id);
        }

        public override ForumPostRestModel ConvertToRestModel(ForumPost item)
        {
            ForumPostRestModel restModel = new ForumPostRestModel()
            {
                Id = item.Id,
                Title = item.Title,
                Content = item.Content
             };
            return restModel;
        }
    }
}
