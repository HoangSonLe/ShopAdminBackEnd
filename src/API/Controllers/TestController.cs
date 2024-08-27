using Application.Base;
using Application.Services.WebInterfaces;
using Core.CommonModels.BaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("/api/[controller]")]
    [Authorize]
    public class TestController : BaseController<TestController>
    {

        public TestController(
            ILogger<TestController> logger,
            IUserService userService
            ) : base(logger, userService)
        {
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("GetMockDataAPI")]
        public async Task<Acknowledgement> GetMockDataAPI()
        {
            return new Acknowledgement();
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //// the code that you want to measure comes here

            ////var result1= await UserService.MockDataRole();
            ////var result = await UserService.GetMockData();
            ////result.Data = result.Data.Take(10).ToList();
            //watch.Stop();
            //var elapsedMs = watch.ElapsedMilliseconds;
            //return Ok(new { Time = elapsedMs });
        }
    }
}
