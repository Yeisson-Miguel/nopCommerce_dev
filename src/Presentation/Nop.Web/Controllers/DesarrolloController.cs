using Microsoft.AspNetCore.Mvc;

namespace aspnetapp.Controllers;

public partial class DesarrolloController: Controller
{
    public virtual IActionResult Desarrollo()
    {
        return View();
    }
}