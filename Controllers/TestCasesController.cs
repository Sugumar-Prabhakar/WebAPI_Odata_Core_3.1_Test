using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Odata_3_1.Interfaces;
using Odata_3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odata_3_1.Controllers
{
    public class TestCasesController : ODataController
    {
        ITestCaseRepository _repository = null;

        public TestCasesController(ITestCaseRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [EnableQuery]
        public async Task<IEnumerable<TestCase>> Get()
        {
            return await _repository.GetTestCases();
        }
    }
}
