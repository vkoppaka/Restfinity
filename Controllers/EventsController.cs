using Restfinity.Models.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;
using Telerik.Sitefinity.Events.Model;
using Telerik.Sitefinity.Modules.Events;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class EventsController : BaseApiController<Event, EventsRestModel, EventsManager>
    {
        public override EventsManager GetManager()
        {
            return EventsManager.GetManager();
        }

        public override IEnumerable<Event> GetAll()
        {
            return this.GetManager().GetEvents();
        }

        public override Event GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetEvent(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }

        public override EventsRestModel ConvertToRestModel(Event item)
        {
            EventsRestModel restModel = new EventsRestModel()
            {
                Id = item.Id,
                Title = item.Title.Value,
                Description = item.Description,
                Status = item.Status,
                Url = item.UrlName.Value,
                EventStartDate = item.EventStart,
                EventEndDate = item.EventEnd
            };
            return restModel;
        }
    }
}
