using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrimerXamarin.Pages
{	
	public partial class FormBus : ContentPage
	{
		public string TituloForm { get; set; }

		public FormBus (string Titulo)
		{
			InitializeComponent ();
			TituloForm = Titulo;
			BindingContext = this; 
		}

        void btnRegresar_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PopAsync();
        }

    }
}

