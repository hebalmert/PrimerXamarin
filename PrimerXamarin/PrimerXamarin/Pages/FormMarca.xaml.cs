using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrimerXamarin.Pages
{	
	public partial class FormMarca : ContentPage
	{	
		public FormMarca ()
		{
			InitializeComponent ();
		}

        void BtnRegresar_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}

