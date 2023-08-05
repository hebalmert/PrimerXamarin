using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrimerXamarin.Pages
{	
	public partial class FormModelo : ContentPage
	{
		public string TituloForm { get; set; }

		public FormModelo (string Titulo)
		{
			InitializeComponent ();
			TituloForm = Titulo;
			BindingContext = this;
		}

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}

