internal class Program
{
    public static void Bienvenido(string name)
    {
        Console.WriteLine("Bienvenido " + name + "!");
    }

    public static int Suma(int a, int b)
    {
        return a + b;
    }

    public static float Calculo(float a, float b)
    {
        float result1 = a * b;

        float result2 = 4.2f * result1;

        float result3 = 4.2f * result2;

        return result3;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese su nombre!");

        string nombre = Console.ReadLine();

        Bienvenido(nombre);

        int resultado = Suma(1, 4);
        Console.WriteLine("El resultado de la suma es "+resultado);

        Console.WriteLine("Ingresa un numero para realizarle una operacion sumamente compleja: ");

        var f_input = Console.ReadLine();
        var s_input = Console.ReadLine();

        float f_num = float.Parse(f_input);
        float s_num = float.Parse(s_input);

        float result = Calculo(f_num, s_num);

        Console.WriteLine("Luego de un largo procesamiento de estos datos, llegamos al resultado " + result);

    }

    

}