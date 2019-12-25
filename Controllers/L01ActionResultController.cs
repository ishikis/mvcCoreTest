using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class L01ActionResultController : Controller
    {
        public IActionResult Index()
        {
            //Content
            //Metin Göndeririz
            return Content("Merhaba");

            //Boş sayfa 
            // return new EmptyResult();

            // /Views/L01_ActionResult/index.cshtml
            // return View();

            // /Views/L01_ActionResult/MyView.cshtml
            // return View("MyView");

            // //Redirection
            //     // /L01_ActionResult/Index
            // return RedirectToAction("Index");

            // return RedirectToAction("Index","Home",new {id=5,sortby="name"});

            //     // www.google.com
            // return Redirect("www.google.com");

            // //Status
            //     // NotFound
            // return NotFound();

            //     // UnAuthorized
            // return Unauthorized();

        }

        public JsonResult JsonActionResult()
        {
            var data = new { Name = "Alex", LastName = "DeLarge" };
            return Json(data);
        }

        // public PartialViewResult PartialViewActionResult()
        // {
        //     var model = new List<int> { 2, 3 };
        //     return PartialView("_PartialViewActionResult", model);
        // }

        // public ViewResult Index1()
        // {
        //     // /Views/L01_ActionResult/index.cshtml
        //     return View();
        //     // /Views/L01_ActionResult/MyView.cshtml
        //     return View("MyView");
        // }

        // public RedirectToRouteResult Index2()
        // {
        //     // /L01_ActionResult/Index
        //     return RedirectToAction("Index");
        // }

        // public RedirectResult Index3()
        // {
        //     // www.google.com
        //     return Redirect("www.google.com");
        // }

        public NotFoundObjectResult NotFoundObjectActionResult()
        {
            return NotFound(new { Id = 2, error = "There was no customer with an id of 2." });
        }

        //a response with an object but a null status code
        public ObjectResult ObjectActionResult()
        {
            return new ObjectResult(new { Name = "TomDickHarry" });
        }

        public NotFoundResult Index4()
        {
            // NotFound
            return NotFound();
        }

        public UnauthorizedResult Index5()
        {
            //UnAuthorized
            return Unauthorized();
        }
    }
}