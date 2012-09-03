using Restfinity.Models.Content;
using System;
using System.Collections.Generic;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.News.Model;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class NewsController : BaseApiController<NewsItem, NewsRestModel, NewsManager>
    {
        public override NewsManager GetManager()
        {
            return NewsManager.GetManager();
        }

        public override IEnumerable<NewsItem> GetAll()
        {
            return this.GetManager().GetNewsItems();
        }

        public override NewsItem GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetNewsItem(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override NewsRestModel ConvertToRestModel(NewsItem item)
        {
            NewsRestModel newsRestModel = new NewsRestModel()
            {
                Id = item.Id,
                Title = item.Title.Value,
                Description = item.Description,
                Status = item.Status,
                Url = item.UrlName.Value
            };
            return newsRestModel;
        }
    }
}
