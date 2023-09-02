using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        // Operadores aritmeticos: 

        Console.WriteLine("Ingrese un numero: ");
        string entrada1 = Console.ReadLine();

        Console.WriteLine("Ingrese otro numero: ");
        string entrada2 = Console.ReadLine();

        int x = int.Parse(entrada1); 
        int y = int.Parse(entrada2);

        int suma = x + y;

        int resta = x - y;

        int multiplicacion = x * y;

        float division = x / y;

        int mod = x % y;

        Console.WriteLine("La suma es " + suma + ", la resta es " + resta + ", la multiplicacion es" + multiplicacion + ", la division " + division + " y por ultimo el mod " + mod);


    }
}