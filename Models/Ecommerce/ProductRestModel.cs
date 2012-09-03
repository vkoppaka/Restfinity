using System;
using System.Collections.Generic;
using System.Linq;

namespace Restfinity.Models.Ecommerce
{
    public class ProductRestModel
    {
        public Guid ProductId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Url { get; set; }

        public bool IsActive { get; set; }

        public List<DynamicData> CustomFields { get; set; }
    }
}
