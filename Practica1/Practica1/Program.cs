internal class Program
{
    public static int Calculo_edad(int a)
    {
        int current_year = DateTime.Now.Year;

        return current_year - a;

    }
    public static void Data()
    {
        Console.WriteLine("Ingrese su año de nacimiento!");

        var input = Console.ReadLine();

        int born_year;

        try
        {
            born_year = int.Parse(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Año incorrecto!");
            born_year = 0;
            Data();
        }

        int result = Calculo_edad(born_year);

        Console.WriteLine("Tu edad es "+result);
        
    }
    public static void Menu()
    {
        Console.WriteLine("Programa de calculo de edad!");
        Data();
    }


    private static void Main(string[] args)
    {
        Menu();
    }
}



