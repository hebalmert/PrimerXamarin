using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrimerXamarin.Pages
{	
	public partial class Modelo : ContentPage
	{	
		public Modelo ()
		{
			InitializeComponent ();
		}

        void RegistrarMarca_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PushAsync(new FormModelo("Registrar Modelo"));
        }

        void VerMarca_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FormModelo("Ver Moelo"));
        }
    }
}

