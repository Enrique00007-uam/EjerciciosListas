class Program
{
    static void Main()
    {
        List<Tuple<string, string>> diccionario = crearDicionario();

        Console.WriteLine();
        traducion(diccionario);

        Console.WriteLine();
         traducion(diccionario);

        Console.WriteLine();
        traducion(diccionario);

        Console.ReadKey();

    }

    public static List<Tuple<string, string>> crearDicionario()
    {
        List<Tuple<string, string>> diccionario = new List<Tuple<string, string>>();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Escribe la palabra {i+1} en ingles ");
            string palabra1 = Console.ReadLine();

            Console.WriteLine($"Escribe la palabra {i+1} en español ");
            string palabra2 = Console.ReadLine();

            Console.WriteLine();

            diccionario.Add(new Tuple<string, string>(palabra1, palabra2));

        }
        return diccionario;

    }

    public static void traducion(List<Tuple<string, string>> diccionario)
    {
        Console.WriteLine("Escribe la palabra a traducir.");
        string palabra = Console.ReadLine();

        foreach (Tuple<string, string> elem in diccionario) 
        {
            if (elem.Item1.Equals(palabra,StringComparison.OrdinalIgnoreCase)) 
            {
                Console.WriteLine("La palabra " + palabra +" traducida a español: " + elem.Item2);
                return;
               
            }
            else if(elem.Item2.Equals(palabra,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("La palabra " + palabra + " traducida a ingles: " + elem.Item1);
                return;
            }
           

        }

        Console.WriteLine("No se encontro la palabra. ");

    }
}

