using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Sitefinity.GenericContent.Model;

namespace Restfinity.Models.Content
{
    public class ContentRestModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public ContentLifecycleStatus Status { get; set; }
        public List<DynamicData> CustomFields { get; set; }
    }
}
