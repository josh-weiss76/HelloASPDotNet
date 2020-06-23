using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet.Controllers
{
    //[Route("/helloworld")]

    public class HelloController : Controller
    {
        //GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            return View(); ;
        }

        // GET: /hello/welcome
        [HttpPost]
        [Route("/hello/{name?}")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;
            return View();
        }

        
        //[HttpPost]
        //public IActionResult CreateMessage(string name, string language)
        //{
        //    if (language == "english")
        //    {
        //        return Content("<h1>Hello " + name + "!</h1>", "text/html");
        //    }
        //    else if (language == "french")
        //    {
        //        return Content("<h1>Bonjour " + name + "!</h1>", "text/html");
        //    }
        //    else if (language == "spanish")
        //    {
        //        return Content("<h1>Hola " + name + "!</h1>", "text/html");
        //    }
        //    else if (language == "german")
        //    {
        //        return Content("<h1>Hallo " + name + "!</h1>", "text/html");
        //    }
        //    else if (language == "italian")
        //    {
        //        return Content("<h1>Ciao " + name + "!</h1>", "text/html");
        //    }
        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        //}

    }
}
