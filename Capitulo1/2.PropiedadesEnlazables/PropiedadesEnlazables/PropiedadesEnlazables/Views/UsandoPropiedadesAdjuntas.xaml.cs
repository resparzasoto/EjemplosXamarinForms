using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PropiedadesEnlazables
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsandoPropiedadesAdjuntas : ContentPage
    {
        public UsandoPropiedadesAdjuntas()
        {
            InitializeComponent();
        }

        private void BoxingUnBoxing_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var column = (int)button.GetValue(Grid.ColumnProperty);

            if (column == 0)
            {
                button.SetValue(Grid.ColumnProperty, 1);
            }
            else
            {
                button.SetValue(Grid.ColumnProperty, 0);
            }
        }

        private void WithoutBoxingUnBoxing_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (Grid.GetColumn(button) == 0)
            {
                button.SetValue(Grid.ColumnProperty, 1);
            }
            else
            {
                button.SetValue(Grid.ColumnProperty, 0);
            }
        }
    }
}