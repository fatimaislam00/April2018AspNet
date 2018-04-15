




using Microsoft.AspNetCore.Mvc;

namespace April2018AspNet.Controllers
{
    public class FourthController : Controller
    {
        int a = 10;

        public string AddTwoNumbers()
        {
            return ""; 
        }


        public IActionResult SomeFunction()
        {
            return View();

        }

        public IActionResult SomeFunction2()
        {
            return View();

        }




    }
}