using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ManejoEventos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //SintaxisEstandar
            botonSintaxisEstandar.Clicked += BotonSintaxisEstandar_Clicked;

            //Expresión Lambda
            botonLambda.Clicked += (s, e) => etiqueta.Text = "Manejo de eventos con expresión Lambda";
        }

        private void XAML_Clicked(object sender, EventArgs e)
        {
            etiqueta.Text = "Manejo de eventos desde XAML";
        }

        private void BotonSintaxisEstandar_Clicked(object sender, EventArgs e)
        {
            etiqueta.Text = "Manejo de eventos con sintaxis estándar";
        }
    }
}
