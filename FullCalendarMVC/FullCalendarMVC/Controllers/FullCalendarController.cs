using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult GetResources()
        {
            object[] obj = new object[]
            {
                new {id = "a" ,title = "專案A"},
                new {id = "b" ,title = "專案B"},
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
                    start = "2015-08-3",
                    end = "2015-8-5",
                    overlap = true,
                    rendering = "inverse-background",
                    color = "#ff9f89"
                },
                new{ resourceId = "a", start = "2015-08-07T02:00:00", end = "2015-08-07T07:00:00", title = "E組" , overlap = false, allDay=true},
                new{ resourceId = "b", start = "2015-08-07T02:00:00", end = "2015-08-07T07:00:00", title = "F組" , allDay=true},
            };

            string jsonString = new JavaScriptSerializer().Serialize(obj);
            return Content(jsonString);
        }

        public ActionResult EventRender()
        {

            return View();
            
        }

        public ActionResult EventRender_GetResources()
        {
            object[] obj = new object[]
            {
                new{ id = "a" ,title = "101母親節檔" , numberPeople = 50 , 假日需求人數 = 100, 平日需求人數 = 200 ,
                    eventColor = "#eee",
                    eventBorderColor = "#eee",
                    eventTextColor = "black" ,
                    eventOverlap = false, children = new []
                    {
                        new  { id = "a1" , title = "A組(12)" , numberPeople = 10 , 假日需求人數 = 20 , 平日需求人數 = 40 , 假日誤差人數 = 0 , 平日誤差人數 = 1 },
                        new  { id = "a2" , title = "B組(11)" , numberPeople = 10 , 假日需求人數 = 20 , 平日需求人數 = 40 , 假日誤差人數 = 0 , 平日誤差人數 = -1 },
                        new  { id = "a3" , title = "C組(14)" , numberPeople = 10 , 假日需求人數 = 20 , 平日需求人數 = 40 , 假日誤差人數 = -1, 平日誤差人數 = -1 },
                        new  { id = "a4" , title = "D組(13)" , numberPeople = 20 , 假日需求人數 = 40 , 平日需求人數 = 80 , 假日誤差人數 = 1 , 平日誤差人數 = 1 }
                    },
                },

                new{ id = "b" ,title = "新竹大遠百母親節檔期" , numberPeople = 50 , 假日需求人數 = 100 , 平日需求人數 = 200 ,
                    eventColor = "#eee",
                    eventBorderColor = "#eee",
                    eventTextColor = "black" ,
                    eventOverlap = false, children = new []
                    {
                        new  { id = "b1" , title = "A組(12)" , numberPeople = 12 , 假日需求人數 = 24, 平日需求人數 = 48 ,假日誤差人數 = 2 , 平日誤差人數 = 1 },
                        new  { id = "b2" , title = "B組(11)" , numberPeople = 11 , 假日需求人數 = 22, 平日需求人數 = 44 ,假日誤差人數 = -2 , 平日誤差人數 = 1},
                        new  { id = "b3" , title = "C組(14)" , numberPeople = 14 , 假日需求人數 = 28, 平日需求人數 = 56 ,假日誤差人數 = 0  , 平日誤差人數 = -1},
                        new  { id = "b4" , title = "D組(13)" , numberPeople = 13 , 假日需求人數 = 26, 平日需求人數 = 52 ,假日誤差人數 = 0  , 平日誤差人數 = -1}
                    },
                },

                new {id = "b" ,title = "專案B"},
            };
            string jsonString = new JavaScriptSerializer().Serialize(obj);


            return Content(jsonString);
        }

        public ActionResult EventRender_GetEvents()
        {
            object[] obj = new object[]
            {
                new { resourceId = "a", start = "2015-08-3", end = "2015-8-5", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new { resourceId = "a1", start = "2015-08-3", end = "2015-8-5", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new { resourceId = "a2", start = "2015-08-3", end = "2015-8-5", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new { resourceId = "a3", start = "2015-08-3", end = "2015-8-5", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new { resourceId = "a4", start = "2015-08-3", end = "2015-8-5", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new{ resourceId = "a1", start = "2015-08-04", title = "10" , people = 1 },
                new{ resourceId = "a1", start = "2015-08-03", title = "10" , people = 1 },
                new{ resourceId = "a2", start = "2015-08-04", title = "10" , people = 1 },
                new{ resourceId = "a2", start = "2015-08-03", title = "10" , people = 1 },
                new{ resourceId = "a3", start = "2015-08-04", title = "25" , people = 1 },
                new{ resourceId = "a4", start = "2015-08-03", title = "28" , people = 1 },
                
                new { resourceId = "b", start = "2015-08-2", end = "2015-8-10", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new { resourceId = "b1", start = "2015-08-2", end = "2015-8-10", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new { resourceId = "b2", start = "2015-08-2", end = "2015-8-10", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new { resourceId = "b3", start = "2015-08-2", end = "2015-8-10", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new { resourceId = "b4", start = "2015-08-2", end = "2015-8-10", ooverlap = true, rendering = "background", color = "#FBD3B3" },
                new{ resourceId = "b1", start = "2015-08-04", title = "10" , people = 1 },
                new{ resourceId = "b1", start = "2015-08-08", title = "1" , people = 1 },
                new{ resourceId = "b1", start = "2015-08-09", title = "4" , people = 1 },
                new{ resourceId = "b1", start = "2015-08-7", title = "5" , people = 1 },
                new{ resourceId = "b2", start = "2015-08-04", title = "10" , people = 1 },
                new{ resourceId = "b2", start = "2015-08-03", title = "10" , people = 1 },
                new{ resourceId = "b3", start = "2015-08-04", title = "25" , people = 1 },
                new{ resourceId = "b4", start = "2015-08-02", title = "28" , people = 1 },
            };

            string jsonString = new JavaScriptSerializer().Serialize(obj);
            return Content(jsonString);
        }

        public ActionResult PostEvents(test[] Roles)
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

    }

    public class test
    {
        public string resourceId { get; set; }

        public int id { get; set; }

        public DateTime start { get; set; }

        public DateTime end { get; set; }
    }
}