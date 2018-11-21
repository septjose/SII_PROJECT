using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SiiProyect.Vistas
{
    class Fondo:ContentPage
    {
        private ImageButton btnKardex;
        private ImageButton btnCargaAcademica;
        private ImageButton btnOrdenEntrada;
        private ImageButton btnDatosPersonales;
        private StackLayout stkLinea1;
        private StackLayout stkLinea2;
        private RelativeLayout rlFondo;

        public Fondo()
        {
            crearGUI();
        }

        private void crearGUI()
        {
            Title = "SII";
            btnKardex = new ImageButton
            {
                Source = "fondo.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 100,
                HeightRequest = 100
            };
            btnKardex.Clicked += async (sender,args)=> await Navigation.PushModalAsync(new MainPage());
            btnCargaAcademica = new ImageButton
            {
                Source = "fondo.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 100,
                HeightRequest = 100
            };
            btnCargaAcademica.Clicked += async (sender, args) => await DisplayAlert("Error", "Boton Carga Academica", "Aceptar");
            //btnCargaAcademica.Clicked += OnImageButtonClicked;
            btnOrdenEntrada = new ImageButton
            {
                Source = "fondo.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 100,
                HeightRequest = 100
            };
            btnDatosPersonales = new ImageButton
            {
                Source = "fondo.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 100,
                HeightRequest = 100
            };
            stkLinea1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { btnKardex, btnCargaAcademica }
            };
            stkLinea2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { btnDatosPersonales, btnOrdenEntrada }
            };
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Vertical,
                Children = {
                    stkLinea1,
                    stkLinea2
                }
            };
        }
    }
}
