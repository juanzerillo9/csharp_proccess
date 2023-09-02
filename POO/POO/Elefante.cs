using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Elefante:Carnivoro
    {
        public decimal Peso { get; set; }

        public void Dormir()
        {
            Console.WriteLine("El elefante ta mimiendo");
        }

    }
}
