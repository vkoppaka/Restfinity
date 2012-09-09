using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Sitefinity.Forums.Model;

namespace Restfinity.Models.Content
{
    public class ForumThreadRestModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }       
        public string Url { get; set; }
        public ForumThreadType ThreadType { get; set; }
        public int PostsCount { get; set; }
        public int ViewsCount { get; set; }
    }
}
