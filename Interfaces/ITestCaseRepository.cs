using Odata_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odata_3_1.Interfaces
{
   public  interface ITestCaseRepository
    {
        Task<IEnumerable<TestCase>> GetTestCases();
        Task<TestCase> GetTestCase(int id);
    }
}
