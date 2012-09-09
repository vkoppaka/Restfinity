using System;
using System.Linq;

namespace Restfinity.Models.Content
{
    public class ForumPostRestModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }      
    }
}
