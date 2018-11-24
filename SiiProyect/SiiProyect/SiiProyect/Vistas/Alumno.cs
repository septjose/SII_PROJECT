using SiiProyect.Settings;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SiiProyect.Vistas
{
    class Alumno:ContentPage
    {
        private ImageButton btnKardex;
        private ImageButton btnCargaAcademica;
        private ImageButton btnOrdenEntrada;
        private ImageButton btnDatosPersonales;
        private ImageButton btnEncuesta;
        private ImageButton btnprueba1;
        private ImageButton btnpruabe2;
        private StackLayout stkLinea1;
        private StackLayout stkLinea2;
        private StackLayout stkLinea3;
        private StackLayout stkLinea4;
        private StackLayout stkLinea5;
        private StackLayout stkLinea6;
        private StackLayout stkLinea7;
        private RelativeLayout rlFondo;
        private StackLayout layout;
        private ScrollView scroll;

        public Alumno()
        {
            crearGUI();
        }

        private void crearGUI()
        {
            Title = Settings.Settings.nocont;
            btnKardex = new ImageButton
            {
                Source = "iconoFondoKardex.png",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 100
            };
            btnKardex.Clicked += async (sender,args)=> await Navigation.PushModalAsync(new DashBoardKardex());
            btnCargaAcademica = new ImageButton
            {
                Source = "iconoFondoCargaAcademica.png",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 100
            };
            btnCargaAcademica.Clicked += async (sender, args) => await Navigation.PushModalAsync(new DashBoardCargaAcademica());
            btnCargaAcademica.Clicked += async (sender, args) => await DisplayAlert("Error", "Boton Carga Academica", "Aceptar");
            //btnCargaAcademica.Clicked += OnImageButtonClicked;
            btnOrdenEntrada = new ImageButton
            {
                Source = "iconoFondoOrdenEntrada.png",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 100
            };
            btnOrdenEntrada.Clicked += async (sender, args) => await Navigation.PushModalAsync(new DashBoardOrdenEntrada());
            btnDatosPersonales = new ImageButton
            {
                Source = "iconoFondoDatosPersonales.png",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 100
            };
            btnDatosPersonales.Clicked += async (sender, args) => await Navigation.PushModalAsync(new DashBoardDatosPersonales());
            btnEncuesta = new ImageButton
            {
                Source = "iconoFondoEncuesta.png",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = Application.Current.MainPage.Width,
                HeightRequest = 100
            };
            btnEncuesta.Clicked += async (sender, args) => await Navigation.PushModalAsync(new DashBoardEncuesta());
            stkLinea1 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { btnKardex }
            };
            stkLinea2 = new StackLayout
            {
                
                Orientation = StackOrientation.Horizontal,
                Children = { btnCargaAcademica }
            };
            stkLinea3 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { btnDatosPersonales }
            };
            stkLinea4 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { btnEncuesta }
            };
            stkLinea5 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { btnOrdenEntrada }
            };
            layout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Vertical,
                Children = {
                    stkLinea1,
                    stkLinea2,
                    stkLinea3,
                    stkLinea4,
                    stkLinea5
                }
            };

            scroll = new ScrollView
            {
                Content = layout
            };
            Content = scroll;
        }
    }
}
