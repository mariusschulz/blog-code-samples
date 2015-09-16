using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web.Mvc;

namespace InliningAngularTemplates.Controllers
{
    public class AngularTemplatesController : Controller
    {
        [ChildActionOnly]
        public ActionResult Inline()
        {
            IEnumerable<string> templateNames = Directory
                .GetFiles(Server.MapPath("~/Views/AngularTemplates/Templates/"))
                .Select(Path.GetFileNameWithoutExtension);

            return View(templateNames);
        }

        public ActionResult Template(string name)
        {
            // Simulate network latency and a slow server
            Thread.Sleep(1000);

            if (name == null || !Regex.IsMatch(name, @"^[-\w]+$"))
                throw new ArgumentException("Illegal template name", "name");

            string relativeViewPath = string.Format("~/Views/AngularTemplates/Templates/{0}.cshtml", name);

            return View(relativeViewPath);
        }
    }
}
