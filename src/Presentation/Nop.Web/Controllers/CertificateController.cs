using Microsoft.AspNetCore.Mvc;

namespace aspnetapp.Controllers;

public partial class CertificateController: Controller
{
    public virtual IActionResult ConfigureCertificate()
    {
        return View();
    }

    public virtual IActionResult AddDetailsCertificate()
    {
        return View();
    }

    public virtual IActionResult CertificateVerification()
    {
        return View();
    }
}