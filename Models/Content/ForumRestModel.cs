using System;
using System.Linq;

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
