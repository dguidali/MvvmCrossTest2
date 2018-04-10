using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace MvvmCrossTest2.Core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel
    {
        public ICommand NavigateCreateBill
        {
            get
            {
                return new MvxCommand(() =>
                    ShowViewModel<BillViewModel>(new { subTotal = 40 }));
            }
        }
    }
}
