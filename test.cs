using System;

class Name
{

    public static int calcular (int x, int y, int op) {

        int resposta = 0;

        switch (op)
        {
            case 1:
                resposta = x + y;
            break;

            case 2:
                resposta = x - y;
            break;

            case 3:
                resposta = x * y;
            break;

            case 4:
                try
                {
                    resposta = x / y;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Divisao por zero");
                    Console.WriteLine(e.ToString());
                }
            break;
        }
        
        return resposta;
    }

    public static void Main (String[] args) {
        Console.WriteLine("Hello World");
        Console.WriteLine(calcular(1, 5, 1));
        Console.WriteLine(calcular(1, 5, 1));
        Console.WriteLine(calcular(1, 5, 1));
        Console.WriteLine(calcular(5, 5, 2));
        Console.WriteLine(calcular(5, 7, 2));
        Console.WriteLine(calcular(5, 7, 2));
        Console.WriteLine(calcular(8, 7, 3));
        Console.WriteLine(calcular(8, 7, 3));
        Console.WriteLine(calcular(8, 7, 3));
        Console.WriteLine(calcular(7, 0, 4));
        Console.WriteLine(calcular(7, 1, 4));
        Console.WriteLine(calcular(7, 0, 4));
        Console.WriteLine(calcular(0, 4, 0));
    }
}