using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NexcoController: Controller
    {
        
        public ActionResult Income()
        {
            var income = new Income()
            {
                Details = "Details here",
                InteresRate = 50,
                Salary = 1200,
                OtherJob = 220,
                OtherIncome = 0,
          
            };
           
            return View(income); 
        }

    }
}