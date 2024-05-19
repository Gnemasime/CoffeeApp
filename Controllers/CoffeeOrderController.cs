using CoffeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeApp.Controllers
{
    public class CoffeeOrderController : Controller
    {
        // GET: CoffeeOrder
        public ActionResult CalcFinalDue()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcFinalDue(CoffeeOrder mp)
        {
            mp.BasicCost = mp.calcBasicTotal();
            mp.ExtraCost = mp.calcExtra();
            mp.TotalCostSingle = mp.calcTotalCostSingle();
            mp.TotalCost = mp.calcTotalCost();
            mp.VatDue = mp.calcVatDue();
            mp.FinalCost = mp.calcFinalCost();

            return View(mp);
        }
    }
}