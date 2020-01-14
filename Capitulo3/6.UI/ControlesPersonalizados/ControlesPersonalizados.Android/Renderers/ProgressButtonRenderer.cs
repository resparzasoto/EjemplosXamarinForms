using Android.Content;
using ControlesPersonalizados;
using ControlesPersonalizados.Droid.Renderers;
using ControlesPersonalizados.Interfaces;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ProgressButton), typeof(ProgressButtonRenderer))]
namespace ControlesPersonalizados.Droid.Renderers
{
    public class ProgressButtonRenderer : ViewRenderer<ProgressButton, com.refractored.monodroidtoolkit.ProgressButton>
    {
        public ProgressButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ProgressButton> e)
        {
            base.OnElementChanged(e);

            if (!(e.OldElement is null) || Element is null)
            {
                return;
            }

            var nativeControl = new com.refractored.monodroidtoolkit.ProgressButton(Context);

            nativeControl.Indeterminante = Element.Indeterminate;
            nativeControl.IndeterminanteInterval = Element.IndeterminateInterval;
            nativeControl.Progress = Element.Progress;
            nativeControl.ProgressColor = Element.ProgressColor.ToAndroid();
            nativeControl.CircleColor = Element.CircularColor.ToAndroid();
            nativeControl.Max = Element.Max;

            SetNativeControl(nativeControl);

            Control.Click += Control_Click;
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            var progressButtonController = (IProgressButtonController)Element;

            if (progressButtonController == null)
            {
                return;
            }

            progressButtonController.ProgressButtonClicked();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control is null || Element is null)
            {
                return;
            }

            if (e.PropertyName == ProgressButton.IndeterminateProperty.PropertyName)
            {
                Control.Indeterminante = Element.Indeterminate;
            }
            else if (e.PropertyName == ProgressButton.IndeterminateIntervalProperty.PropertyName)
            {
                Control.IndeterminanteInterval = Element.IndeterminateInterval;
            }
            else if (e.PropertyName == ProgressButton.ProgressProperty.PropertyName)
            {
                Control.Progress = Element.Progress;
            }
            else if (e.PropertyName == ProgressButton.ProgressColorProperty.PropertyName)
            {
                Control.ProgressColor = Element.ProgressColor.ToAndroid();
            }
            else if (e.PropertyName == ProgressButton.CircularColorProperty.PropertyName)
            {
                Control.CircleColor = Element.CircularColor.ToAndroid();
            }
            else if (e.PropertyName == ProgressButton.MaxProperty.PropertyName)
            {
                Control.Max = Element.Max;
            }
        }
    }
}