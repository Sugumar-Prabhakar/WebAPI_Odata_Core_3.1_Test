using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;
using Odata_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odata_3_1
{
    public static class EDMModel
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<TestSuite>("TestSuites");
            builder.EntitySet<TestCase>("TestCases");
            return builder.GetEdmModel();
        }
    }
}
