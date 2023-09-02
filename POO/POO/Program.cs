using POO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la fabrica de cerveza!");
        // Creando una cerveza
        Cerveza brahma = new Cerveza(5, 6.5m,300);
        brahma.Fermentacion();


        // Herencia: 
        Leon rey = new Leon();

        rey.Rugido();
        rey.Nombre = "El rey leon";
        Elefante bimbo = new Elefante();

        bimbo.Dormir();
        bimbo.Nombre = "Bambisito";

        Console.WriteLine("El elefante se llama... " + bimbo.Nombre);

        // Sobrecarga 
        // Cuando tenemos un metodo en una clase 

        rey.Correr();
        rey.Correr(120);

        Leon Zimba = new Leon("Simba"); // El constructor asigna el  nombre del  primer parametro.

        Console.WriteLine(Zimba.Nombre);

        Console.WriteLine(Zimba.getNombre());
    }
}