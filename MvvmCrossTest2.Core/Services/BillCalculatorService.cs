using MvvmCrossTest2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTest2.Core.Services
{
    public class BillCalculatorService : IBillCalculatorService
    {
        public double TipAmount(double subTotal, int gratuity)
        {
            return subTotal * ((double)gratuity) / 100.0;
        }

        public double BillTotal(double subTotal, int gratuity)
        {
            return subTotal + TipAmount(subTotal, gratuity);
        }
    }
}
