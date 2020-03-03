using Microsoft.EntityFrameworkCore;
using Odata_3_1.Interfaces;
using Odata_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odata_3_1.Repository
{
    public class TestSuiteRepository : ITestSuiteRepository
    {
        TestDBContext _context = null;
        public TestSuiteRepository(TestDBContext context)
        {
            _context = context;
        }

        public async Task<TestSuite> GetTestSuite(int id)
        {
            return await _context.TestSuite.FirstOrDefaultAsync(x => x.TestSuiteId == id);
        }

        public async Task<IEnumerable<TestSuite> > GetTestSuites()
        {
            return await _context.TestSuite.ToListAsync();
        }
    }
}
