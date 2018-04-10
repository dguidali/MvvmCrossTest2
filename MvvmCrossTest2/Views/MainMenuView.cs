﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace MvvmCrossTest2.Views
{
    [Activity(Label = "Main Menu", MainLauncher=true)]
    public class MainMenuView : MvxActivity
    {
        /// <summary>
        /// Use OnViewModelSet to inflate the view's ContentView from AXML.
        /// </summary>
        protected override void OnViewModelSet()
        {
            // This uses a resource identifier generated by Android to identify the view.
            SetContentView(Resource.Layout.View_MainMenu);
        }
    }
}