using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PropiedadesEnlazables
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsandoPropiedadesEnlazables : ContentPage
    {
        public UsandoPropiedadesEnlazables()
        {
            InitializeComponent();
        }

        private void CLR_Clicked(object sender, EventArgs e)
        {
            if (etiqueta.TextColor == Color.Red)
            {
                etiqueta.TextColor = Color.Blue;
            }
            else
            {
                etiqueta.TextColor = Color.Red;
            }
        }

        private void GetAndSet_Clicked(object sender, EventArgs e)
        {
            if ((Color)etiqueta.GetValue(Label.TextColorProperty) == Color.Red)
            {
                etiqueta.SetValue(Label.TextColorProperty, Color.Blue);
            }
            else
            {
                etiqueta.SetValue(Label.TextColorProperty, Color.Red);
            }
        }
    }
}
