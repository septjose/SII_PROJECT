using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SiiProyect.Vistas
{
    class Header : Frame
    {
        public Header()
        {
            Padding = new Thickness(0, 20, 0, 0);
            HeightRequest = 250;

            //Fondo del Header
            var Backgroundbox = new BoxView
            {
                Color = Color.DarkSlateBlue,
                HeightRequest = 100,
            };

            Image BackgroundImg = new Image
            {
                Source = "logoItc.png",
                WidthRequest = 100,
                HeightRequest = 100
            };

            //Imagen de la escuela que esta siguiendo
            Image imgSchool = new Image
            {
                //Source = App.imgSchool,
            };

            //Imagen del evento deportivo
            Image imgEvento = new Image
            {
                Source = "logoItc.png",
                WidthRequest = 100,
                HeightRequest = 100
            };

            Image imgLince = new Image
            {
                Source = "fondo.png",
                Opacity = 0.6,
                WidthRequest = 100,
                HeightRequest = 100
            };

            //Enfasis de fondo del nombre de escuela y lema
            var Blackbox = new BoxView
            {
                Color = Color.Black,
                HeightRequest = 30,
                Opacity = 0.25
            };

            Label lblSchoolName = new Label
            {
                //Text = App.nameSchoolCorto,
                //Text = App.SportTitle,
                Text = "SII",
                FontAttributes = FontAttributes.Bold,
                FontSize = 14,
                TextColor = Color.White,
                FontFamily = "Roboto"
            };

            Label lblSchoolMotto = new Label
            {
                Text = "Especialidad: Ingenieria en Sistemas Computacionales",
                FontSize = 12,
                TextColor = Color.White,
                FontFamily = "Roboto"
            };
            Label lblNoControl = new Label
            {
                Text = "No. Control: 14030678",
                FontSize = 12,
                TextColor = Color.White,
                FontFamily = "Roboto"
            };
            Label lblNombre = new Label
            {
                Text = "Nombre: Jose Antonio Medina Malagon",
                FontSize = 12,
                TextColor = Color.White,
                FontFamily = "Roboto"
            };

            //Estructura del Header
            var layoutConstant = new RelativeLayout();

            layoutConstant.Children.Add(
            Backgroundbox,
            Constraint.Constant(0),
            Constraint.Constant(0),
            Constraint.RelativeToParent((parent) => { return parent.Width; }),
            Constraint.RelativeToParent((parent) => { return parent.Height; })
            );
            layoutConstant.Children.Add(
            imgLince,
            Constraint.Constant(55),
            Constraint.Constant(0),
            Constraint.RelativeToParent((parent) => { return parent.Width * 1.1; }),
            Constraint.RelativeToParent((parent) => { return parent.Height * 1.1; })
            );
            layoutConstant.Children.Add(
            Blackbox,
            Constraint.Constant(0),
            Constraint.Constant(125),
            Constraint.RelativeToParent((parent) => { return parent.Width; }),
            Constraint.RelativeToParent((parent) => { return parent.Height; })
            );
            layoutConstant.Children.Add(
            imgSchool,
            Constraint.Constant(10),
            Constraint.Constant(30),
            Constraint.Constant(90),
            Constraint.Constant(90)
            );
            layoutConstant.Children.Add(
            imgEvento,
            //Constraint.Constant(245),
            Constraint.RelativeToParent((parent) => {
                return (parent.Width * 1) - 50;
            }),
            Constraint.Constant(30),
            Constraint.Constant(35),
            Constraint.Constant(35)
            );
            layoutConstant.Children.Add(
            lblSchoolName,
            Constraint.Constant(5),
            Constraint.Constant(130),
            Constraint.RelativeToParent((parent) => { return parent.Width; }),
            Constraint.RelativeToParent((parent) => { return parent.Height; })
            );
            layoutConstant.Children.Add(
            lblSchoolMotto,
            Constraint.Constant(5),
            Constraint.Constant(145),
            Constraint.RelativeToParent((parent) => { return parent.Width; }),
            Constraint.RelativeToParent((parent) => { return parent.Height; })
            );
            layoutConstant.Children.Add(
            lblNoControl,
            Constraint.Constant(5),
            Constraint.Constant(160),
            Constraint.RelativeToParent((parent) => { return parent.Width; }),
            Constraint.RelativeToParent((parent) => { return parent.Height; })
            );
            layoutConstant.Children.Add(
            lblNombre,
            Constraint.Constant(5),
            Constraint.Constant(175),
            Constraint.RelativeToParent((parent) => { return parent.Width; }),
            Constraint.RelativeToParent((parent) => { return parent.Height; })
            );

            //Main Stack
            Content = layoutConstant;
        }
    }
}
