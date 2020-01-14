using ControlesPersonalizados.Interfaces;
using System;
using Xamarin.Forms;

namespace ControlesPersonalizados
{
    public class ProgressButton : View, IProgressButtonController
    {
        public event EventHandler Clicked;

        public static readonly BindableProperty IndeterminateProperty =
            BindableProperty.Create(nameof(Indeterminate), typeof(bool), typeof(ProgressButton), default(bool));

        public bool Indeterminate
        {
            get
            {
                return (bool)GetValue(IndeterminateProperty);
            }
            set
            {
                SetValue(IndeterminateProperty, value);
            }
        }

        public static readonly BindableProperty IndeterminateIntervalProperty =
            BindableProperty.Create(nameof(IndeterminateInterval), typeof(int), typeof(ProgressButton), 100);

        public int IndeterminateInterval
        {
            get
            {
                return (int)GetValue(IndeterminateIntervalProperty);
            }
            set
            {
                SetValue(IndeterminateIntervalProperty, value);
            }
        }

        public static readonly BindableProperty ProgressProperty = 
            BindableProperty.Create(nameof(Progress), typeof(int), typeof(ProgressButton), default(int));

        public int Progress 
        {
            get
            {
                return (int)GetValue(ProgressProperty);
            }
            set
            {
                SetValue(ProgressProperty, value);
            } 
        }

        public static readonly BindableProperty ProgressColorProperty =
            BindableProperty.Create(nameof(ProgressColor), typeof(Color), typeof(ProgressButton), Color.Red);

        public Color ProgressColor
        {
            get
            {
                return (Color)GetValue(ProgressColorProperty);
            }
            set
            {
                SetValue(ProgressColorProperty, value);
            }
        }

        public static readonly BindableProperty CircularColorProperty =
            BindableProperty.Create(nameof(CircularColor), typeof(Color), typeof(ProgressButton), Color.White);

        public Color CircularColor
        {
            get
            {
                return (Color)GetValue(CircularColorProperty);
            }
            set
            {
                SetValue(CircularColorProperty, value);
            }
        }

        public static readonly BindableProperty MaxProperty =
            BindableProperty.Create(nameof(Max), typeof(int), typeof(ProgressButton), 100);

        public int Max
        {
            get
            {
                return (int)GetValue(MaxProperty);
            }
            set
            {
                SetValue(MaxProperty, value);
            }
        }

        void IProgressButtonController.ProgressButtonClicked()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
