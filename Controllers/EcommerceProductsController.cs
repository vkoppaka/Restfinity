using System;
using System.Collections.Generic;
using System.Linq;
using Restfinity.Models.Ecommerce;
using Telerik.Sitefinity.Ecommerce.Catalog.Model;
using Telerik.Sitefinity.Modules.Ecommerce.Catalog;
using Telerik.Sitefinity.SitefinityExceptions;

namespace Restfinity.Controllers
{
    public class EcommerceProductsController : BaseApiController<Product, ProductRestModel, CatalogManager>
    {
        public override CatalogManager GetManager()
        {
           return CatalogManager.GetManager();
        }

        public override IEnumerable<Product> GetAll()
        {
            return this.GetManager().GetProducts();
        }

        public override Product GetOne(Guid id)
        {
            try
            {
                return this.GetManager().GetProduct(id);
            }
            catch (ItemNotFoundException)
            {
                return null;
            }
        }
       
        public override ProductRestModel ConvertToRestModel(Product product)
        {
            ProductRestModel productRestModel = new ProductRestModel()
            {
                ProductId = product.Id,
                Title = product.Title.Value,
                Description = product.Description,
                Price = product.Price,
                Url = product.UrlName.Value,
                IsActive = product.IsActive
            };
            return productRestModel;
        }
    }
}
