internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Condicionales en c#");

        // ESTAS PRUEBAS SON PARA PROBAR LAS SINTAXIS DE C#

        // IF, ELSE IF, ELSE

        Console.WriteLine("Bienvenido, ingrese su edad: ");
        var input = Console.ReadLine();
        
        var numero = 0;

        // TRY - CATCH
        try
        {
            numero = int.Parse(input);
        }
        catch (FormatException)
        {
            numero = 0;
        }


        if ((numero <= 0) || (numero > 120))
        {
            Console.WriteLine("Ingrese una edad valida por favor!");
        }
        else if (numero < 18)
        {
            Console.WriteLine("Su edad no es suficiente, eres menor de edad");
        }
        else if (numero < 30)
        {
            Console.WriteLine("Adelante! Puede pasar.");
        }
        else
        {
            Console.WriteLine("Debe pasar al sector de mayores, por la izquierda por favor!");
        }


        // SWITCH

        Console.WriteLine("Ingrese un dia de la semana!");

        var inputDia = Console.ReadLine();

        int dia = 0;

        try
        {
            dia = int.Parse(inputDia);
        }
        catch (FormatException)
        {
            dia = 0;
        }
        

        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes!");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("No es un dia valido!");
                break;
        }

        // BUCLE WHILE

        int contador = 0;

        while (contador <= 100)
        {
            if ((contador % 2 == 0))
            {
                Console.WriteLine("Contador del While (Solo pares): "+ contador);
            }
            contador++;
            //++contador;
        }

        // Bucle For

        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine("Contador  del for:  "+ i);
        }



        // Try Catch Finally

        Console.WriteLine("Bien, terminamos con los bucles, aprendamos try catch y Finally!");

        Console.WriteLine("Ingrese un numero para dividirlo por otro. ");

        var input_prueba = Console.ReadLine();

        Console.WriteLine("Bien, ahora ingresa el segundo numero,  si pongo 0 deberia salir un error ya que no vamos a poder dividir.");
        
        var input2 = Console.ReadLine();
        int x = 0;
        int y = 0;
        try
        {
            x = int.Parse(input_prueba);
            y = int.Parse(input2);
        }
        catch (FormatException)
        {
            Console.WriteLine("No se puede usar esos numero!");
        }

        try
        {
            int result = x / y;
            Console.WriteLine("La  respuesta es: "+ result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Intentaste dividir por 0! Error.");
        }
        finally
        {
            Console.WriteLine("La etapa de manejo de errores termino correctamente, este mensaje se mostrara siempre.");
        }
    }
}