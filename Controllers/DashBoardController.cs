using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
using System.Threading.Tasks;

public class DashBoardController : Controller{
    public IActionResult DashBoard(){
        return View();
    }
}