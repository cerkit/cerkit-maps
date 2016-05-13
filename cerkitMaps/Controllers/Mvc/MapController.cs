using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cerkitMaps.Controllers.Mvc
{
    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult State(int? id)
        {
            id = id ?? 13; // default to Georgia

            // store the state id in the ViewBag so we can pass it to the api
            ViewBag.StateId = id;

            return View();
        }

		public ActionResult GoogleMapWithDistricts() 
		{
			return View();
		}
    }
}