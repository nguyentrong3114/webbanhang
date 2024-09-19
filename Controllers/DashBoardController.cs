using Microsoft.AspNetCore.Mvc;
namespace MyMvcApi{
    public class DashBoardController : Controller{
        public IActionResult DashBoard(){
            return View();
        }
    }
}