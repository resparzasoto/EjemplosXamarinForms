using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace WriteFile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private IFileSystemService fileSystemService;

        public MainPage()
        {
            InitializeComponent();

            fileSystemService = DependencyService.Get<IFileSystemService>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var contentFile = await fileSystemService.GetContentFileAsync("prueba.txt");

            contentEditor.Text = contentFile;
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            var result = fileSystemService.WriteFileAsync("prueba.txt", contentEditor.Text);

            if (result.IsCompleted)
            {
                await DisplayAlert(Title, "Archivo guardado con éxito!", "Aceptar");
            }
        }
    }
}
