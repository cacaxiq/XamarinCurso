using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using AulaSeis.Custom;
using AulaSeis.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderedEntry), typeof(BorderedEntryCustom))]
namespace AulaSeis.Droid.Custom
{
    public class BorderedEntryCustom : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {

            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var element = (BorderedEntry)Element;

                var nativeEditText = (global::Android.Widget.EditText)Control;

                float[] R = new float[] { element.TamanhoBorda, element.TamanhoBorda, element.TamanhoBorda, element.TamanhoBorda, element.TamanhoBorda, element.TamanhoBorda, element.TamanhoBorda, element.TamanhoBorda };
                RectF inset = new RectF(10, 10, 10, 10);

                if (element.TipoBorda == 1 || element.TipoBorda > 3)
                {
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RoundRectShape(R, null, null));
                    shape.Paint.Color = element.CorBorda.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.Stroke);
                    nativeEditText.Background = shape;
                }

                if (element.TipoBorda == 2)
                {
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RoundRectShape(R, inset, R));
                    shape.Paint.Color = element.CorBorda.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.Stroke);
                    nativeEditText.Background = shape;
                }

                if (element.TipoBorda == 3)
                {
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.OvalShape());
                    shape.Paint.Color = element.CorBorda.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.Stroke);
                    shape.GetHotspotBounds(new Rect(20, 120, 100, 200));
                    nativeEditText.Background = shape;
                }
            }
        }
    }
}
