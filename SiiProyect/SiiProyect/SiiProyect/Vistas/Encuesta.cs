﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SiiProyect.Vistas
{
    class Encuesta:ContentPage
    {
        public Encuesta(string alumno)
        {
            crearGUI();
        }
        public void crearGUI()
        {
            Title = "Encuesta";
        }
    }
}
