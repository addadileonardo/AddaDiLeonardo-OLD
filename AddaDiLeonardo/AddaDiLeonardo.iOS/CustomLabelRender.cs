﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AddaDiLeonardo.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(AddaDiLeonardo.CustomLabel),typeof(CustomLabelRender))]
namespace AddaDiLeonardo.iOS
{
    public class CustomLabelRender:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
                //Control.TextAlignment = UITextAlignment.Justified;
            }
        }
    }
}