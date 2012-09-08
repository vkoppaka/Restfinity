using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restfinity.Models.Content
{
    public class ForumRestModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }        
    }
}
