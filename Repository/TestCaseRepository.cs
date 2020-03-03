using Microsoft.EntityFrameworkCore;
using Odata_3_1.Interfaces;
using Odata_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odata_3_1.Repository
{
    public class TestCaseRepository : ITestCaseRepository
    {
        TestDBContext _context = null;
        public TestCaseRepository(TestDBContext context)
        {
            _context = context;
        }

        public async Task<TestCase> GetTestCase(int id)
        {
            return await _context.TestCase.FirstOrDefaultAsync(x => x.TestCaseId == id);
        }

        public async Task<IEnumerable<TestCase>> GetTestCases()
        {
            return await _context.TestCase.ToListAsync();
        }
    }
}
