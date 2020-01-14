using System.ComponentModel;
using Xamarin.Forms;

namespace TransformacionesAnimaciones
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        bool animado = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, System.EventArgs e)
        {
            if (animado)
            {
                botonAnimado.ScaleTo(1, 1000, Easing.BounceIn);
            }
            else
            {
                botonAnimado.ScaleTo(2, 1000, Easing.BounceOut);
            }

            animado = !animado;
        }
    }
}
