
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyMvcApi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ManageDashBoardController : Controller
    {
        public IActionResult DeliveryDashBoard()
        {
            return View();
        }
        public IActionResult OverviewDashBoard()
        {
            return View();
        }
        public IActionResult CustomerDashBoard()
        {
            return View();
        }
    }
}