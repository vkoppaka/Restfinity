using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Utilities.TypeConverters;

namespace Restfinity.Controllers
{
    public class DynamicModulesController : ApiController
    {
        public IEnumerable<DynamicContent> Get()
        {
            DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager();
            Type openingType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Careers.Opening");
            
            var myCollection = dynamicModuleManager.GetDataItems(openingType);
            // At this point myCollection contains the items from type openingType
            return myCollection;

        }
    }
}
