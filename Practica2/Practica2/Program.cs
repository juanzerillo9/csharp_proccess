internal class Program
{
    public static float AreaCirculo(float a)
    {
        float parc = a * a;
        return parc * 3.14f;
    }
    
    public static float AreaCuadrado(float a, float b)
    {
        return a * b;
    }

    public static float AreaTriangulo(float a, float b)
    {
        return (a * b) / 2;
    }
    
    public static void Circulo()
    {
        string input;
        float radio = 0;
        bool t_flag;
        do
        {
            t_flag = false;
            Console.WriteLine("Radio del circulo: ");
            input = Console.ReadLine();
            try
            {
                radio = float.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Radio no valido");
                t_flag = true;
            }

        } while (t_flag == true);

        float result = AreaCirculo(radio);

        Console.WriteLine("El area es "+ result);
    }

    public static void Cuadrado()
    {
        string input; string input2;
        float ancho = 0; float altura = 0;
        bool t_flag;
        do
        {
            t_flag = false;
            
            Console.WriteLine("Base del cuadrado: ");
            input = Console.ReadLine();

            Console.WriteLine("Altura del cuadrado: ");
            input2 = Console.ReadLine();
            
            try
            {
                ancho = float.Parse(input);
                altura = float.Parse(input2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Radio no valido");
                t_flag = true;
            }

        } while (t_flag == true);

        float result = AreaCuadrado(ancho, altura);

        Console.WriteLine("El area es " + result);
    }

    public static void Triangulo()
    {
        string input; string input2;
        float ancho = 0; float altura = 0;
        bool t_flag;
        do
        {
            t_flag = false;

            Console.WriteLine("Base del Triangulo: ");
            input = Console.ReadLine();

            Console.WriteLine("Altura del Triangulo: ");
            input2 = Console.ReadLine();

            try
            {
                ancho = float.Parse(input);
                altura = float.Parse(input2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Radio no valido");
                t_flag = true;
            }

        } while (t_flag == true);

        float result = AreaTriangulo(ancho, altura);

        Console.WriteLine("El area es " + result);
    }

    public static void Menu()
    {

        bool flag;
        string input;
        int option = 0;

        do
        {
            Console.WriteLine("Calculadora de Áreas");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triangulo");
            Console.WriteLine("3. Circulo");

            Console.WriteLine("Seleccione una figura ( 1/2/3 ): ");
            flag = false;
            input = Console.ReadLine();
            try
            {
                option = int.Parse(input);
                if (option < 1 || option > 3)
                {
                    Console.Clear();
                    Console.WriteLine("Error, opcion no valida!");
                    flag = true;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Error, opcion no valida!");
                flag = true;

            }
        } while (flag == true);

        switch (option)
        {
            case 1: Cuadrado(); break;
            case 2: Triangulo(); break;
            case 3: Circulo(); break;
        }

        bool s_flag;

        do
        {
            s_flag = false;

            Console.WriteLine("Desea realizar otra operacion? (S/N)");
            var restart = Console.ReadLine();

            if (restart == "S")
            {
                Console.Clear();
                Menu();
            }
            else if (restart == "N")
            {
                // Terminar ejecucion
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Opcion Incorrecta!");
                s_flag = true;
            }
        } while (s_flag == true);

        
    }

    private static void Main(string[] args)
    {
        Menu();
    }
}