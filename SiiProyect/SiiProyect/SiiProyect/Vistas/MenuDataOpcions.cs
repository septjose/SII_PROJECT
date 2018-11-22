using SiiProyect.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiiProyect.Vistas
{
    class MenuDataOptions : List<MenuOpcion>
    {
        public MenuDataOptions()
        {
            this.Add(new MenuOpcion()
            {
                Title = "Inicio",
                IconSource = "iconoInicio.png",
                //TargetType = typeof(MainPage),
            });
            this.Add(new MenuOpcion()
            {
                Title = "Buzon de Quejas",
                IconSource = "iconoBuzon.png",
                //TargetType = typeof(MainPage),
            });
            this.Add(new MenuOpcion()
            {
                Title = "Actividades",
                IconSource = "iconoActividades.png",
                //TargetType = typeof(InstitucionesPage),
            });
            this.Add(new MenuOpcion()
            {
                Title = "Cerrar Sesion",
                IconSource = "iconoCerrarSesion.png",
                //TargetType = typeof(InstitucionesPage),
            });
        }
    }
}
