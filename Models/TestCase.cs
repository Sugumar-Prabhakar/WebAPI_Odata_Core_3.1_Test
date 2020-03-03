using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odata_3_1.Models
{
    public class TestCase
    {
        public long TestCaseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int?  TestSuiteId { get; set; }
        public virtual TestSuite TestSuite { get; set; }
    }
}
