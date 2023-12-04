

class Program
{
    public static void Main()
    {

        int opcion;

        Console.WriteLine("Menu de Fibonacci");
        Console.WriteLine("1.Calcular la serie 11 de fibonacci");
        Console.WriteLine("2.Saber si un numero hace parte de la serie de Fibonacci");
        Console.WriteLine("3.Mostrar los m primeros numeros de la serie de fibonacci");
        Console.WriteLine("4.Salir");
        Console.WriteLine("Seleccione en el menu lo que desee realizar");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                int[] listaFib = Fibonacci(11 + 1);
                Console.WriteLine($"F11={listaFib[11]}");
                break;
            case 2:
                Console.WriteLine("Ingrese un numero:");
                int dato = int.Parse(Console.ReadLine());
                int[] listaFib2 = Fibonacci(dato + 1);
                if (listaFib2.Contains(dato))
                    Console.WriteLine($"{dato} es numero de fibonacci.");
                else
                    Console.WriteLine($"{dato} no es numero de fibonacci.");
                break;
            case 3:
                Console.WriteLine("Ingrese m:");
                int dato3 = int.Parse(Console.ReadLine());
                int[] listaFib3 = Fibonacci(dato3);

                for (int i = 0; i < 1; i++)
                {
                    Console.WriteLine(string.Join(",", listaFib3));
                }
                break;
            case 4:
                Console.WriteLine("Adios");
                break;
        }
    }

    public static int[] Fibonacci(int cantidad)
    {
        int[] lista = new int[cantidad];
        lista[0] = 0;
        lista[1] = 1;
        for (int i = 2; i < cantidad; i++)
        {
            lista[i] = lista[i - 1] + lista[i - 2];
        }
        return lista;
    }

}
