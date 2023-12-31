﻿using Android.Content;
using Android.Graphics.Drawables;
using MauiApp1.Controls;
using MauiApp1.Platforms.Android.Renderers;
using AndroidWidget = Android.Widget;
using AndroidGraphics = Android.Graphics;
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Graphics;

namespace MauiApp1.Platforms.Android.Renderers
{
    public class BorderedEntryRenderer : Microsoft.Maui.Controls.Handlers.Compatibility.ViewRenderer<BorderedEntry, AndroidWidget.EditText>
    {
        public BorderedEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<BorderedEntry> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var editText = new AndroidWidget.EditText(Context);
                SetNativeControl(editText);
            }

            if (e.NewElement != null)
            {
                // Apply a border to the EditText control
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetColor(AndroidGraphics.Color.White);
                gradientDrawable.SetStroke(2, AndroidGraphics.Color.Blue);
                gradientDrawable.SetCornerRadius(10);
                Control.SetBackground(gradientDrawable);
            }
        }
    }
}
