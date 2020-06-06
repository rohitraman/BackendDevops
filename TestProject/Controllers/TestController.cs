using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestProject.Models;

namespace TestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        TestDBContext testDBContext;
        public TestController(TestDBContext testDBContext)
        {
            this.testDBContext = testDBContext;
        }

        [HttpGet]
        public IEnumerable<TestModel> Get()
        {
            return testDBContext.testModels;
        }

        [HttpPost]
        public void Post([FromBody]TestModel testModel)
        {
            testDBContext.testModels.Add(testModel);
            testDBContext.SaveChanges();
        }
    }
}
