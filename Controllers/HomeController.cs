using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcJenkinsDemo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your MVC application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your MVC application contact page.";

			return View();
		}
	}
}