﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class CAnimal
    {
        public string Nombre { get; set; }

        public virtual string getNombre ()
        {
            return Nombre;
        } 
    }
}
