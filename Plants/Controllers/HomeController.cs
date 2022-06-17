using Microsoft.AspNetCore.Mvc;

namespace Plants.Controllers
{
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "hello.";
        }
    }
}
