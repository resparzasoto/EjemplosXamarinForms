using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Reto
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private TapGestureRecognizer tapGesture = null;

        public MainPage()
        {
            InitializeComponent();

            tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += TapGesture_Tapped;

            box1.GestureRecognizers.Add(tapGesture);
            box2.GestureRecognizers.Add(tapGesture);
            box3.GestureRecognizers.Add(tapGesture);
            box4.GestureRecognizers.Add(tapGesture);
            box5.GestureRecognizers.Add(tapGesture);
            box6.GestureRecognizers.Add(tapGesture);
            box7.GestureRecognizers.Add(tapGesture);
            box8.GestureRecognizers.Add(tapGesture);
            box9.GestureRecognizers.Add(tapGesture);
        }

        private void TapGesture_Tapped(object sender, EventArgs e)
        {
            var box = sender as BoxView;
            box.Color = (box.Color == Color.White) ? Color.Red : Color.White; 
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            tapGesture.Tapped -= TapGesture_Tapped;
        }
    }
}
