using Microsoft.AspNetCore.Mvc;

namespace WebCameraApp.Controllers
{
    public class CameraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
