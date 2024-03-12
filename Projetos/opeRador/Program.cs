using System;

class Tabuada
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um operador (+, -, *, /):");
        string operador = Console.ReadLine();

        Console.WriteLine("Digite um número (1-9):");
        float numero = float.Parse(Console.ReadLine());

        for (float i = 1; i <= 9; i++)
        {
            float resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = numero + i;
                    break;
                case "-":
                    resultado = numero - i;
                    break;
                case "*":
                    resultado = numero * i;
                    break;
                case "/":
                    resultado = numero / i;
                    break;
            }

            Console.WriteLine("{0} {1} {2} = {3}", numero, operador, i, resultado.ToString("N2"));
        }
    }
}
