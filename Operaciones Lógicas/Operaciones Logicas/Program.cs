using System;

class Program
{
    static void Main()
    {
  Console.Write("Ingresa el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

     Console.Write("Ingresa el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("\n***Comparaciones lógicas:***");

        if (num1 > num2)
        {
  Console.WriteLine($"El número {num1} es mayor que el número {num2}.");
        }
        else if (num1 < num2)
        {
    Console.WriteLine($"El número {num1} es menor que el número {num2}.");
        }
        else
        {
 Console.WriteLine($"El número {num1} es igual al número {num2}.");
        }

        if (num1 > 10 && num2 < 50)
        {
   Console.WriteLine($"El número {num1} es mayor que 10 y el número {num2} es menor que 50.");
        }

        if (num1 > 10 || num2 < 50)
        {
 Console.WriteLine($"El número {num1} es mayor que 10 o el número {num2} es menor que 50.");
        }

     Console.WriteLine("\nPresiona ENTER para salir...");
     Console.ReadLine();
 }
}
