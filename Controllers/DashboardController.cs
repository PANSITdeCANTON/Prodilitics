using Microsoft.AspNetCore.Mvc;

namespace Productivity_Analytics.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View(); // Views/Dashboard/Dashboard.cshtml
        }

        public IActionResult Chart()
        {
            return View(); // Views/Dashboard/Chart.cshtml
        }

        public IActionResult Tables()
        {
            return View(); // Views/Dashboard/Tables.cshtml
        }

        public IActionResult sidenav()
        {
            return View(); // Views/Dashboard/sidenav.cshtml
        }

        public IActionResult Static()
        {
            return View(); // Views/Dashboard/Static.cshtml
        }
    }
}
