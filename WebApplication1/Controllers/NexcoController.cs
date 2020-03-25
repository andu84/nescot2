using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NexcoController: Controller
    {

        private IncomeRepository _incomeRepository = null;
        public NexcoController()
        {
            _incomeRepository = new IncomeRepository();
        }
        public ActionResult Income(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var income = _incomeRepository.GetIncome((int)id);
           
            return View(income); 
        }

    }
}