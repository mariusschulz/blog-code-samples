using System.Web.Mvc;

namespace AngularMvcDemo.Controllers
{
    public class AngularController : Controller
    {
        [ChildActionOnly]
        public ActionResult InitialData()
        {
            // You'd probably get that data from a database or some API.
            // For the sake of simplicity of this demo, I've inlined the data here.
            object companionship = new
            {
                Dwarves = new[]
                {
                    "Fili", "Kili",
                    "Dori", "Nori", "Ori", "Oin", "Gloin",
                    "Balin", "Dwalin",
                    "Bifur", "Bofur", "Bombur", "Thorin"
                },
                Hobbits = new[] { "Bilbo" },
                Wizards = new[] { "Gandalf" }
            };

            var serializedCompanions = JavaScriptConvert.SerializeObject(companionship);

            return PartialView(serializedCompanions);
        }
    }
}
