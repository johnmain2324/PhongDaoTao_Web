using Microsoft.AspNetCore.Mvc;

namespace PhongDaoTao_Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
