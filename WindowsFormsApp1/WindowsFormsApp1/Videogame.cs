﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public  class Videogame
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }
        public int Año { get; set; }
        public int Peso { get; set; } // en MB o GB
        public string Precio { get; set; }
    }
}