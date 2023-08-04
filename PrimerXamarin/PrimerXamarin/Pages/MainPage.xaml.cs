using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimerXamarin
{
    public partial class MainPage : ContentPage
    {
        public string NombreUsuario { get; set; }

        public string Contra { get; set; }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            if (NombreUsuario == "hebalmert" && Contra == "1234")
            {
                Application.Current.MainPage = new paginaPrincipal();
            }
            else
            {
                DisplayAlert("Error", "Usuario o clave Incorrecto", "Cancelar");
            }
        }

        void btnRegistrar_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PaginaRegistro());
        }
    }
}

