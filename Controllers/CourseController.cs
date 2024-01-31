using assignmentjan31WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assignmentjan31WebApplication1.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Course> listOfCouses = new List<Course>()
        {
        new Course() { cid = 1,Cname = "btech",CFee = 25000,Technology="java",CstartDate=new DateTime(day:12,month:11,year:2022) },
        new Course() { cid = 2,Cname = "btech",CFee = 27000,Technology="c#",CstartDate=new DateTime(day:21,month:06,year:2022) },
        new Course() { cid = 3,Cname = "mtech",CFee = 30000,Technology="python",CstartDate=new DateTime(day:14,month:07,year:2022) },
        new Course() { cid = 4,Cname = "diploma",CFee = 46000,Technology="machinelearning",CstartDate=new DateTime(day:01,month:01,year:2022)}
    };
        public ActionResult Index()
        {
            return View(listOfCouses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Course());

        }
        [HttpPost]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                listOfCouses.Add(course);
                return RedirectToAction("Index");
            }
            return View(course);
        }

    }
}