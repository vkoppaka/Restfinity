using System;
using System.Linq;

namespace Restfinity.Models.Content
{
    public class EventsRestModel : ContentRestModel
    {
        public DateTime EventStartDate { get; set; }
        public DateTime? EventEndDate { get; set; }
    }
}
