using Bike.model;
using Microsoft.AspNetCore.Mvc;

namespace Bike.Controllers
{
    public class MakeController : Controller
    {
        //make/bikes
        public IActionResult Bikes()
        {
            Make make = new()
            {
                Id = 1,
                Name = "Harley Davidson"
            };
            return View(make);

            //ContentResult contentResult= new ContentResult { Content="Hello World.."};
            //return contentResult;

            //return Redirect("/home");
            //return RedirectToAction("About", "Home");
            //return new EmptyResult();
        }
    }
}
