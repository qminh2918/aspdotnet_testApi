using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using test.Dal.EntityClasses;
using TestApi.Common;
using TestApi.Manager;

namespace TestApi.Controllers
{
    [Route("TestApi/api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    //[Authorize]
    public class TestController
    {
        private readonly TestManager _testManager = new TestManager();
        public TestController()
        {
        }

        [HttpPost]
        [Route("SelectAll")]
        public async Task<ApiResponse<List<TestEntity>>> SelectAll()
        {
            return await _testManager.SelectAll();
        }
    }
}
