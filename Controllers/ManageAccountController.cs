using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
using System.Threading.Tasks;

public class ManageAccountController : Controller
{
    public IActionResult ManageAccount()
    {
        return View();
    }
}