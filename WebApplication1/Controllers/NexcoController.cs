using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class NexcoController: Controller
    {
        public ActionResult Income()
        {
            ViewBag.Title = "Income";
            ViewBag.Details = "Detail here";
            ViewBag.InteresRate= 50;
            ViewBag.Salary = 1200;
            ViewBag.OtherJob = 220;
            ViewBag.OtherIncome = 0;
            ViewBag.TotalIncome = ViewBag.InteresRate + ViewBag.Salary + ViewBag.OtherJob + ViewBag.OtherIncome;
            return View(); 
        }

    }
}