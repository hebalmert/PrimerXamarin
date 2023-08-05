using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PrimerXamarin.Pages
{	
	public partial class Bus : ContentPage
	{	
		public Bus ()
		{
			InitializeComponent ();
		}

        void ToolBarVer_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FormBus("Ver Bus"));
        }

        void ToolBarNuevo_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FormBus("Nuevo Bus"));
        }
    }
}

