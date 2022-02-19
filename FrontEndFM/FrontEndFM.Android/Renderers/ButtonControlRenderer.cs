﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FrontEndFM.Controls;
using FrontEndFM.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ButtonControl), typeof(ButtonControlRenderer))]

namespace FrontEndFM.Droid.Renderers
{
    public class ButtonControlRenderer : ButtonRenderer
    {
        public ButtonControlRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var button = this.Control; button.SetAllCaps(false);
        }
     


    }
}