using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCrossTest2.Core.Interfaces;
using MvvmCrossTest2.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossTest2.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            // Whenever Mvx.Resolve is used, a new instance of Calculation is provided.
            Mvx.RegisterType<IBillCalculatorService, BillCalculatorService>();
            var calcExample = Mvx.Resolve<IBillCalculatorService>();

            // Tells the MvvmCross framework that whenever any code requests an IMvxAppStart reference,
            // the framework should return that same appStart instance.
            var appStart = new AppStart();
            Mvx.RegisterSingleton<IMvxAppStart>(appStart);

            // Another option is to utilize a default App Start object with 
            // var appStart = new MvxAppStart<TipViewModel>();
        }
    }
}
