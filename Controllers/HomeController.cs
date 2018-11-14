using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new TestModel
            {
                TopLevelRate = 10m,
                InnerModels = new TestInnerModel[2]
                {
                    new TestInnerModel { Rate = 2.0m },
                    new TestInnerModel { Rate = 0.2m }
                }
            });
        }

        [HttpPost]
        public IActionResult Index(TestModel model)
        {
            return Ok();
        }
    }
}
