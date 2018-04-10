using MvvmCross.Core.ViewModels;
using MvvmCrossTest2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MvvmCrossTest2.Core.ViewModels
{
    public class BillViewModel : MvxViewModel
    {
        readonly IBillCalculatorService _calculation;
        private string _customerEmail;
        double _subTotal;
        int _gratuity;
        double _tip;
        double _total;

        public ICommand NavBack
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }

        public string CustomerEmail
        {
            get => _customerEmail;
            set
            {
                _customerEmail = value;
                RaisePropertyChanged(() => CustomerEmail);
            }
        }

        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        public int Gratuity
        {
            get => _gratuity;
            set
            {
                _gratuity = value;
                RaisePropertyChanged(() => Gratuity);
                Recalculate();
            }
        }

        public double Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        public double Total
        {
            get => _total;
            set
            {
                _total = value;
                RaisePropertyChanged(() => Total);
            }
        }

        public BillViewModel(IBillCalculatorService calculation)
        {
            _calculation = calculation;
        }

        public void Init(int subTotal)
        {
            SubTotal = subTotal;
        }

        public override void Start()
        {
            _gratuity = 10;
            Recalculate();
            base.Start();
        }

        void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Gratuity);
            Total = _calculation.BillTotal(SubTotal, Gratuity);
        }

        public ICommand BackClicked
        {
            get
            {
                return new MvxCommand(() => Close(this));
            }
        }
    }
}
