using SiiProyect.Modelos;
using SiiProyect.WebServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SiiProyect.Vistas
{
    class Kardex:ContentPage
    {
        private ListView lv_inst;
        private StackLayout st_inst;
        private List<Kardex> list_inst;
        private WSKardex objWsKardex;
        public Kardex(string nocont,string token)
        {
            objWsKardex = new WSKardex();
            crearGUIAsync(nocont, token);
        }
        public async Task crearGUIAsync(string nocont, string token)
        {
            var lista = await objWsKardex.listaKardex(nocont, token);
            //lv_inst.ItemsSource = list_inst;
            Title = "Kardex";
            //lv_inst = new ListView()
            //{
            //    HasUnevenRows = true, //Estandarizar items
            //    //ItemTemplate = celda
            //};
            Button btn = new Button
            {
                Text = "prueba"
            };
            btn.Clicked += async (sender, args) => await DisplayAlert("Error", nocont+"\n"+token, "Aceptar");
            st_inst = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(20),
                Children =
                {
                    btn
                }
            };
            Content = st_inst;
        }
    }
}
