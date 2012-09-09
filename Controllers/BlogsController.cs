using System;
using System.Collections.Generic;
using System.Linq;
using Restfinity.Models.Content;
using Telerik.Sitefinity.Blogs.Model;
using Telerik.Sitefinity.Modules.Blogs;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class BlogsController : BaseApiController<Blog, BlogRestModel, BlogsManager>
    {
        public override BlogsManager GetManager()
        {
            return BlogsManager.GetManager();
        }

        public override IEnumerable<Blog> GetAll()
        {
            return this.GetManager().GetBlogs();
        }

        public override Blog GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetBlog(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override BlogRestModel ConvertToRestModel(Blog item)
        {
            BlogRestModel restModel = new BlogRestModel()
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
