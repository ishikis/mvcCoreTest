using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CourseApp.Controllers
{
    public class L07ModelBindingsController : Controller
    {
        //Model bingin datata okurken ilk önce form dataya barkar
        //belitilen ismi bulamaz ise ardından Route Dataya bakar
        //son olarak query stringe bakar 
        //aynı isimde degişkenler için deger ataması yapılınca sonraki degerlere bakmaz 

        //Formdata kullanımı Post metodu ile gonderilir
        public IActionResult Index(string name)
        {
            //Model binging ile ilgili datayı aldık
            return View();
        }

        public IActionResult Index2()
        {
            //Request nesnesi ile ilgili datayı aldık

            try
            {
                string _name = Request.Form["name"];
            }
            catch
            {

            }

            return View();
        }

        //Route Data        
        //localhost:5000/L07ModelBindingsController/index3/3
        //{controller}/{action}/id
        public IActionResult Index3(int id)
        {
            //Model binging ile ilgili datayı aldık
            return View();
        }


        public IActionResult Index4()
        {
            //RoteData nesnesi ile ilgili datayı aldık
            //? null kontrolu için dir
            try
            {
                int _id = int.Parse(RouteData.Values["id"]?.ToString());
            }
            catch { }
            return View();
        }

        //Query String  Get metodu
        //view den oluşan query string 
        //? den sonra degişken = deyer şeklinde olur
        //localhost:5000/L07ModelBindingsController/index5?q=keyword
        public IActionResult Index5(string q)
        {
            //Model binging ile ilgili datayı aldık

            return View();
        }

        public IActionResult Index6()
        {
            //Model binging ile ilgili datayı aldık
            string q = Request.Query["q"];
            return View();
        }

        public IActionResult Index7(
            [Bind(nameof(test.ad), nameof(test.soyad))] //test nesnesinin sadece ad ve soyad bilgisini alamasını istersek
            test aa)
        {
            //Model binging ile ilgili datayı aldık
            string q = Request.Query["q"];
            return View();
        }

    }

    [Bind(nameof(ad), nameof(soyad))]//bu entity bind edilirken deger alacak emlemanlarını seçebiliriz
    public class test
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        [BindNever]//bind işlemlerinde bu eleman çalışmayacak
        public string email { get; set; }
    }
}