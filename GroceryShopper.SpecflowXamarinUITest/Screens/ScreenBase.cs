﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace GroceryShopper.SpecflowXamarinUITest.Screens
{
    public abstract class ScreenBase
    {
        protected readonly IApp App;

        protected ScreenBase()
        {
            App = GroceryShopperFeature.App;
        }

        public virtual void DoScreenshot(string stepTitle)
        {
            App.Screenshot(stepTitle);
        }

        public abstract ScreenBase AssertIsOnScreen();
    }
}
