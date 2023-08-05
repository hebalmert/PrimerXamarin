using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrimerXamarin.Pages
{	
	public partial class FormSucursal : ContentPage
	{
		public string TituloForm { get; set; }

		public FormSucursal (string titulo)
		{
			InitializeComponent ();
			TituloForm = titulo;
			BindingContext = this;
		}

        void btnRegresar_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}

