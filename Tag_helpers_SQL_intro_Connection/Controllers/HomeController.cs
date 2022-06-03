using Microsoft.AspNetCore.Mvc;

namespace Tag_helpers_SQL_intro_Connection.Controllers
{
    public class HomeController:Controller
    {
      public  IActionResult Index()
        {
            return View();
        }
    }
}
