using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Leon : Carnivoro
    {
        public string ColorPelaje { get; set; }
        public char Sexo { get; set; }

        // CONSTRUCTOR - Se ejecuta al crear el objeto
        public Leon()
        {
            if(this.Nombre == null || !this.Nombre.Equals(""))
            this.Nombre = "Leon";
        }

        // CONSTRUCTOR + SOBRECARGA - 

        public Leon(string name)
        {
            this.Nombre = name;
        }

        public void Rugido()
        {
            Console.WriteLine("GRRRRR");
        }


        // Sobrecarga

        private int velocidadXDefecto = 20;

        public void Correr()
        {
            Console.WriteLine("Corriendo a "+velocidadXDefecto+ "km x hora");
        }
        public void Correr(int velocidad)
        {
            Console.WriteLine("Corriendo a " + velocidad + "km x hora");
        }

        public override string getNombre()
        {
            return "soy un  leon llamado " + Nombre;
        }
    }
}
