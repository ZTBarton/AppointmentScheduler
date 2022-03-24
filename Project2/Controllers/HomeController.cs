using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project2.Models;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {

        private ApptContext blahContext { get; set; }

        public HomeController(ApptContext someName)
        {

            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Add Appt Methods

        [HttpGet]
        public IActionResult TimeList()
        {
            ViewBag.month = Convert.ToString(DateTime.Now.Month);
            ViewBag.day = Convert.ToString(DateTime.Now.Day);
            ViewBag.dayofweek = ((int)DateTime.Now.DayOfWeek);
            ViewBag.date = DateTime.Now.Date;

            return View("TimeList", ViewBag);
        }

        [HttpGet]
        public IActionResult AddAppt(int id)
        {
            //ViewBag.majors = blahContext.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddAppt(Appt ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();

            return View("Confirmation", ar);
        }
        //Edit Methods

        [HttpGet]

        public IActionResult Edit(DateTime ApptDate)
        {
            //ViewBag.Category = blahContext.Category.ToList();

            Appt myAppt = blahContext.Appts.Single(x => x.ApptDate == ApptDate);
            return View("ApptList", myAppt);
        }

        [HttpPost]
        public IActionResult Edit(Appt test)
        {
            blahContext.Update(test);
            blahContext.SaveChanges();

            return RedirectToAction("ApptList");

        }
        //Appt List
        public IActionResult ApptList()
        {

            var Groups = blahContext.Appts
                //.Include(x => x.Category)
                //.OrderBy(x => x.Title)
                .ToList();
            return View(Groups);
        }

        // Delete Methods

        [HttpGet]
        public IActionResult Delete(DateTime ApptDate)
        {
            var application = blahContext.Appts.Single(x => x.ApptDate == ApptDate);


            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(Appt ar)
        {

            blahContext.Remove(ar);
            blahContext.SaveChanges();

            return RedirectToAction("WaitList");
        }


    }
}



        

