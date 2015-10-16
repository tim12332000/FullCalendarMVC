using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace FullCalendarMVC.Controllers
{
    public class FullCalendarController : Controller
    {
        // GET: FullCalendar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult external_dragging()
        {
            return View();
        }

        public ActionResult json()
        {
            return View();
        }

        public ActionResult GetResources(int? _ )
        {
            object[] obj = new object[]
            {
                new {id = "a" ,title = "Auditorium A"},
                new {id = "b" ,title = "Auditorium B"},
            };
            string jsonString = new JavaScriptSerializer().Serialize(obj);


            return Content(jsonString);
        }

        public ActionResult GetEvents()
        {
            object[] obj = new object[]
            {
                new {
                    resourceId = "a",
                    start = "2015-08-1",
                    end = "2015-8-6",
                    overlap = false,
                    rendering = "background",
                    color = "#ff9f89"
                },
                new{id = 1 , resourceId = "a", start = "2015-08-07T02:00:00", end = "2015-08-07T07:00:00", title = "event 1"},
                new{id = 2 , resourceId = "b", start = "2015-08-07T02:00:00", end = "2015-08-07T07:00:00", title = "event 2"},
            };

            string jsonString = new JavaScriptSerializer().Serialize(obj);
            return Content(jsonString);
        }
    }
}