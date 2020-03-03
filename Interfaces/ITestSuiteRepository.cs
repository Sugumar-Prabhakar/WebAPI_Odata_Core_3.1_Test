using Odata_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odata_3_1.Interfaces
{
    public interface ITestSuiteRepository
    {
        Task<IEnumerable<TestSuite>> GetTestSuites();
      Task< TestSuite> GetTestSuite(int id);
    }
}
