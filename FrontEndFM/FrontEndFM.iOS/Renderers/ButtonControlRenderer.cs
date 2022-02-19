using Foundation;
using FrontEndFM.Controls;
using FrontEndFM.iOS.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(Button), typeof(ButtonControlRenderer), new[] { typeof(VisualMarker.MaterialVisual) })]

namespace FrontEndFM.iOS.Renderers
{
    public class ButtonControlRenderer : MaterialButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.UppercaseTitle = false;
            }
        }
    }
}