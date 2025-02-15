using System;
class Program
{
    static void Main()
    { 
 int numeroENTERO;
 double numeroDECIMAL;
 string TEXTO;
 bool BOOLEANO;
    
        Console.Write("Por favor ingresa un número ENTERO: ");
        numeroENTERO = Convert.ToInt32(Console.ReadLine());

        Console.Write("Por favor ingresa un numero DECIMAL: ");
        numeroDECIMAL = Convert.ToDouble(Console.ReadLine());

        Console.Write("Por favotr ingresa un texto: ");
        TEXTO = Console.ReadLine();

        Console.Write("Por favor ingresa un valor true/false: ");
        BOOLEANO = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("\nValores ingresados: ");
        Console.WriteLine("Número entero: " + numeroENTERO);
        Console.WriteLine("Número decimal: " + numeroDECIMAL);
        Console.WriteLine("Texto : " + TEXTO);
        Console.WriteLine("Valor booleano : " + BOOLEANO);

    }
}
