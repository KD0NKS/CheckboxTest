using CheckboxTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckboxTest.Controllers {
    public class HomeController : Controller {
        public HomeController() {
            ViewBag.SelectOptions = new List<SelectListItem> {
                new SelectListItem { Text = "CB 1",  Value = Guid.NewGuid().ToString() }
                , new SelectListItem { Text = "CB 2",  Value = Guid.NewGuid().ToString() }
                , new SelectListItem { Text = "CB 3",  Value = Guid.NewGuid().ToString() }
                , new SelectListItem { Text = "CB 4",  Value = Guid.NewGuid().ToString() }
                , new SelectListItem { Text = "CB 5",  Value = Guid.NewGuid().ToString() }
            };
    }

        public ActionResult Index() {
            return View(new TestViewModel());
        }

        [HttpPost]
        public ActionResult FormTest(TestViewModel model) {
            if(ViewData.ModelState.Values.Any(e => e.Errors.Count > 0)) {
                return View("Index", model);
            }

            return View("About");
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}