using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhongDaoTao_Web.Data;

namespace PhongDaoTao_Web.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

