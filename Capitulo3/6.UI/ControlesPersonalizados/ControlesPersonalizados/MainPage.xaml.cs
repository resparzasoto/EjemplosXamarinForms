using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace ControlesPersonalizados
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClick_ProgressButton(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje", "Evento detonado!", "Cancelar");
        }
    }
}
