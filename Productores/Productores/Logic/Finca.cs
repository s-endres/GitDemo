﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Productores.Logic
{
    public class Finca
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int area { get; set; }
        public int idProductor { get; set; }

        public Finca()
        {

        }
        public Finca(int pid, string pnombre, int parea, int pidProductor)
        {
            this.id = pid;

            this.nombre = "Hayrom Blanco";

           this.nombre = “Armando Alfonzo Ramirez Echenique”;

            this.nombre = "Alfredo puto";


            this.nombre = "Ricardoputo";
            this.nombre = "Alfredo Valverde";


            this.area = parea;
            this.idProductor = pidProductor;
        }
    }
}