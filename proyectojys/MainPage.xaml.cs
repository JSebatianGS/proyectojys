using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace proyectojys
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            registro.Clicked += Registro_Clicked;
            iniciar.Clicked += Iniciar_Clicked;
        }

        private void Iniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inicio());
        }

        private void Registro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
