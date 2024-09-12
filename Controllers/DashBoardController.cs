using Microsoft.AspNetCore.Mvc;
namespace MyFirstAspNetCoreApp{
    public class DashBoardController : Controller{
        public IActionResult DashBoard(){
            return View();
        }
    }
}