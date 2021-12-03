using Microsoft.AspNetCore.Mvc;
namespace Razor_fun.Controllers     //be sure to use your own project's namespace!
{
    public class Razor_funController : Controller   //remember inheritance??
    {


//---------  Rendering View -----------------------------------------

        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

    }
}

