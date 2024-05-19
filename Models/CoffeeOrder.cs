using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeApp.Models
{
    public class CoffeeOrder
    {
       
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer name must be between 3 and 50 characters.")]
        public string CustomerName { get; set; }

        public string CoffeeSize { get; set; }

        public bool ExtraShot { get; set; }

        public bool FlavoredSyrup { get; set; }

        public int Qty { get; set; }

        public double BasicCost { get; set; }

        public double ExtraCost { get; set; }

        public double TotalCostSingle { get; set; }

        public double TotalCost { get; set; }

        public double VatDue { get; set; }

        public double FinalCost { get; set; }


        public double calcBasicTotal()
        {
            double basic = 0.00;
            if (CoffeeSize == "Small")
            {
                basic = 25;
            }
            else if (CoffeeSize == "Medium")
            {
                basic = 35;
            }
            else if (CoffeeSize == "Large")
            {
                basic = 45;
            }
            return basic;
        }

        public double calcExtra()
        {
            double extra = 0.00;
            if (ExtraShot == true)
            {
                extra += 10;
            }
            if (FlavoredSyrup == true)
            {
                extra += 5;
            }
            return extra;
        }

        public double calcTotalCostSingle()
        {
            return calcBasicTotal() * Qty;
        }

        public double calcTotalCost()
        {
            return calcTotalCostSingle() + calcExtra();
        }


        public double calcVatDue()
        {
            return 0.15 * calcTotalCost();
        }

        public double calcFinalCost()
        {
        return calcVatDue() + calcTotalCost();
    }

    }

}