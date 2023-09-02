using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cerveza
    {
        // Atributos
        
        // El get y el set es para otorgarle un valor.
        public int Amargor { get; set; }
        public decimal Alcohol { get; set; }
        public int TiempoFermentacion { get; set; }

        // Consutructor

        public Cerveza(int Amargor, decimal Alcohol, int TiempoFermentacion)
        {
            // Con this. hace referencia a los atributos de la clase.
            this.Amargor = Amargor;
            this.Alcohol = Alcohol;
            this.TiempoFermentacion = TiempoFermentacion;
        }

        // Metodos

        public void Fermentacion()
        {
            // Algo
            for (int i = 0; i < TiempoFermentacion; i++) ;
            Console.WriteLine("Se fermento la cerveza");
        }

    }
}
