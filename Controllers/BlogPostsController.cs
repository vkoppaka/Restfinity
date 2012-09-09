using System;
using System.Collections.Generic;
using System.Linq;
using Restfinity.Models.Content;
using Telerik.Sitefinity.Blogs.Model;
using Telerik.Sitefinity.Modules.Blogs;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class BlogPostsController : MasterDetailApiController<BlogPost, BlogPostRestModel, BlogsManager, Blog>
    {
        public override BlogsManager GetManager()
        {
            return BlogsManager.GetManager();
        }

        public override IEnumerable<BlogPost> GetAll()
        {
            return this.GetManager().GetBlogPosts();
        }
        
        public override IEnumerable<BlogPost> GetAllDetails(Guid id)
        {
            return this.GetManager().GetBlogPosts().Where(bp => bp.Parent.Id == id);
        }

        public override BlogPost GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetBlogPost(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override BlogPostRestModel ConvertToRestModel(BlogPost item)
        {
            BlogPostRestModel restModel = new BlogPostRestModel()
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
