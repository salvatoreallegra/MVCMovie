using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is the default Action, /HelloWorld";
        }
        public string Welcome()
        {
            return "This is the Welcome Action Method";
        }
    }
}
