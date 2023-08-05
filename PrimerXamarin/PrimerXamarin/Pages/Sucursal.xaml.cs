using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrimerXamarin.Pages
{	
	public partial class Sucursal : ContentPage
	{	
		public Sucursal ()
		{
			InitializeComponent ();
		}

        void ToolBarRegistrar_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FormSucursal("Registrar Sucursal"));
        }

        void ToolBarVer_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FormSucursal("Ver Sucursal"));
        }
    }
}

