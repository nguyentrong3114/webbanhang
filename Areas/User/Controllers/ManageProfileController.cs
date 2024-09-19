
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MyMvcApi.Areas.User.Controllers{
[Area("User")]
[Authorize]
public class ManageProfileController : Controller
{
    public IActionResult ManageProfile()
    {
        return View();
    }
}
}