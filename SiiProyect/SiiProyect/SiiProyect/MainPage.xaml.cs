using SiiProyect.Vistas;
using SiiProyect.WebServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace SiiProyect
{
    public partial class MainPage : ContentPage
    {
        private ActivityIndicator aiIndicadorLogin;
        private Image imgLogin;
        private Entry txtUsuarioLogin, txtContrasenaLogin;
        private CheckBox checkbox;
        private Button btnLogin;
        private Label lblLogin;
        private StackLayout stkLogin;
        private RelativeLayout rlLogin;
        public MainPage()
        {
            checkbox = new CheckBox
            {
                DefaultText = "Recordar",
                FontSize = 13,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 200,
                HeightRequest = 50
            };
            //InitializeComponent();
            BackgroundColor = Color.Azure;
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            imgLogin = new Image
            {
                Source = "logoItc.png",
                WidthRequest = 200,
                HeightRequest = 200
            };
            sub.Children.Add(imgLogin);
            this.BackgroundColor = Color.White;
            this.Content = sub;
            txtUsuarioLogin = new Entry
            {
                Placeholder = "Usuario",
                PlaceholderColor = Color.Green,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Green,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 400,
                HeightRequest = 50
            };
            txtContrasenaLogin = new Entry
            {
                IsPassword = true,
                Placeholder = "Contraseña",
                PlaceholderColor = Color.Green,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.Green,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 400,
                HeightRequest = 50
            };
            btnLogin = new Button
            {
                Text = "Iniciar",
                BackgroundColor = Color.Gray,
                TextColor = Color.White
            };
            btnLogin.Clicked += Btn_Cliked;
            aiIndicadorLogin = new ActivityIndicator
            {
                HorizontalOptions = LayoutOptions.Center
            };
            stkLogin = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.Center,
                BackgroundColor = Color.Azure,
                WidthRequest = 500,
                Children =
                {
                    imgLogin,
                    txtUsuarioLogin,
                    txtContrasenaLogin,
                    checkbox,
                    btnLogin,
                    aiIndicadorLogin
                }
            };
            rlLogin = new RelativeLayout();
            rlLogin.Children.Add(
                stkLogin,
                Constraint.RelativeToParent((parent) => { return 0; }),/*Posision X*/
                Constraint.RelativeToParent((parent) => { return parent.Height * 0.1; }),/*Posicion Y*/
                Constraint.RelativeToParent((parent) => { return parent.Width; }),/*Ancho*/
                Constraint.RelativeToParent((parent) => { return parent.Width; })/*Alto*/
            );
            lblLogin = new Label
            {
                Text = "Antony Medyna",
                FontSize = 20,
                TextColor = Color.Green,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            rlLogin.Children.Add(
                lblLogin,
                Constraint.RelativeToParent((parent) => { return 0; }),
                Constraint.RelativeToView(stkLogin, (parent, view) => { return view.Y + view.Height + 100; }),
                Constraint.RelativeToParent((parent) => { return parent.Width; }),
                Constraint.RelativeToParent((parent) => { return parent.Width; })
            );
            if (!String.IsNullOrEmpty(Settings.Settings.nocont) && !String.IsNullOrEmpty(Settings.Settings.password))
            {
                txtUsuarioLogin.Text = Settings.Settings.nocont;
                txtContrasenaLogin.Text = Settings.Settings.password;
            }
            Content = rlLogin;
        }

        private async void Btn_Cliked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuarioLogin.Text))
            {
                await DisplayAlert("Error", "Debes introducir un usuario", "Aceptar");
                txtUsuarioLogin.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtContrasenaLogin.Text))
            {
                await DisplayAlert("Error", "Debes de introducir una contraseña", "Aceptar");
                txtContrasenaLogin.Focus();
                return;
            }
            aiIndicadorLogin.IsRunning = true;
            WSLogin objWSL = new WSLogin();
            try
            {
                List<String> resultado = await objWSL.Conexion(txtUsuarioLogin.Text, txtContrasenaLogin.Text);
                if (!resultado.Equals("Acceso Denegado"))
                {
                    if (checkbox.Checked)
                    {
                        Settings.Settings.nocont = txtUsuarioLogin.Text;
                        Settings.Settings.password = txtContrasenaLogin.Text;
                    }
                    else
                    {
                        Settings.Settings.nocont = null;
                        Settings.Settings.password = null;
                    }
                    //await DisplayAlert("Bienvenido","Usuario Correcto","Aceptar");
                    await imgLogin.ScaleTo(1, 2000);
                    await imgLogin.ScaleTo(0.9, 1500, Easing.Linear);
                    await imgLogin.ScaleTo(150, 1200, Easing.Linear);
                    //Application.Current.MainPage = new MainPage();
                    await Navigation.PushModalAsync(new DashBoardAlumno());
                }
            }
            catch (Exception) { }
            aiIndicadorLogin.IsRunning = false;
        }

    }
}
