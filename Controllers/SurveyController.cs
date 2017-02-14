// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        // default route that will redirect back
        // to index if there is no form data
        [HttpGet]
        [Route("results")]
        public IActionResult Results()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("results")]
        public IActionResult PostResults(string fullName, string location, string language)
        {
            // validation
            // if (fullName.Length < 1 || location.Length < 1 || language.Length < 1)
            // {
            //     return RedirectToAction("Index");
            // }
            // else
            // {
            //     ViewBag.fullName = fullName;
            //     ViewBag.location = location;
            //     ViewBag.language = language;
            //     System.Console.WriteLine(fullName);
            //     System.Console.WriteLine(location);
            //     System.Console.WriteLine(language);
            //     return View("Results");
            // }

            ViewBag.fullName = fullName;
            ViewBag.location = location;
            ViewBag.language = language;
            System.Console.WriteLine(fullName);
            System.Console.WriteLine(location);
            System.Console.WriteLine(language);
            return View("Results");
        }
    }
}
