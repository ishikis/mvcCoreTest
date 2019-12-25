
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class L02ActionParametersController : Controller
    {
        /**
            Request -> Controller -> Action
            
            Route       :   /L02ActionParameters/Details/2
            Route Configde root tanımı yaparken 3 parametre ekler isek çagıracagımız metoda aynı isimde parametre(istege baglı) ekleliz 
            
            Query String:   /L02ActionParameters/Details?id=2
            
            Form Data   :   id=2
        */
        public IActionResult Details(int id)
        {

            return Content("id= " + id);

        }


    }
}