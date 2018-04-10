using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTest2.Core.Interfaces
{
    public interface IBillCalculatorService
    {
        double TipAmount(double subTotal, int gratuity);
        double BillTotal(double subTotal, int gratuity);
    }
}
