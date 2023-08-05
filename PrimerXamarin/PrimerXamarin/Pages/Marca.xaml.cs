using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrimerXamarin.Pages
{	
	public partial class Marca : ContentPage
	{	
		public Marca ()
		{
			InitializeComponent ();
		}

        void RegistrarMarca_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PushAsync(new FormMarca());
        }
    }
}

