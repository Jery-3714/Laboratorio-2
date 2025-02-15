using System;

class Program
{
    static void Main()
    {
        // Declaración de variables
        int intNum1, intNum2;
        decimal decNum1, decNum2;
        float floatNum1, floatNum2;
        short shortNum1, shortNum2;
        byte byteNum1, byteNum2;

        Console.WriteLine("*OPERACIONES CON ENTEROS:(Ejemplo 1,2,3,4) *");
        Console.Write("Ingrese el primer número ENTERO: ");
        intNum1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número ENTERO: ");
        intNum2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n Operaciones con núros ENTEROS:");
        Console.WriteLine($"Suma: {intNum1} + {intNum2} = {intNum1 + intNum2}");
        Console.WriteLine($"Resta: {intNum1} - {intNum2} = {intNum1 - intNum2}");
        Console.WriteLine($"Multiplicación: {intNum1} * {intNum2} = {intNum1 * intNum2}");
        Console.WriteLine($"División: {intNum1} / {intNum2} = {(intNum2 != 0 ? (intNum1 / intNum2).ToString() : "Error: División por cero")}");

        Console.WriteLine("\n*OPERACIONES CON DECIMALES:(Ejemplo 5.56) *");
        Console.Write("Ingrese el primer número DECIMAL: ");
        decNum1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el segundo número DECIMAL: ");
        decNum2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("\nOperaciones con DECIMALES:");
        Console.WriteLine($"Suma: {decNum1} + {decNum2} = {decNum1 + decNum2}");
        Console.WriteLine($"Resta: {decNum1} - {decNum2} = {decNum1 - decNum2}");
        Console.WriteLine($"Multiplicación: {decNum1} * {decNum2} = {decNum1 * decNum2}");
        Console.WriteLine($"División: {decNum1} / {decNum2} = {(decNum2 != 0 ? (decNum1 / decNum2).ToString() : "Error: División por cero")}");

        Console.WriteLine("\n*OPERACIONES CON FLOAT:(Ejemplo 3.14) *");
        Console.Write("Ingrese el primer número FLOAT: ");
        floatNum1 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número FLOAT: ");
        floatNum2 = float.Parse(Console.ReadLine());

        Console.WriteLine("\nOperaciones con FLOAT:");
        Console.WriteLine($"Suma: {floatNum1} + {floatNum2} = {floatNum1 + floatNum2}");
        Console.WriteLine($"Resta: {floatNum1} - {floatNum2} = {floatNum1 - floatNum2}");
        Console.WriteLine($"Multiplicación: {floatNum1} * {floatNum2} = {floatNum1 * floatNum2}");
        Console.WriteLine($"División: {floatNum1} / {floatNum2} = {(floatNum2 != 0 ? (floatNum1 / floatNum2).ToString() : "Error: División por cero")}");

        Console.WriteLine("\n*OPERACIONES CON Int16:(Ejemplo numeros entre -32,768 a 32,767) *");
        Console.Write("Ingrese el primer número: ");
        shortNum1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        shortNum2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("\nOperaciones con Int16:");
        Console.WriteLine($"Suma: {shortNum1} + {shortNum2} = {shortNum1 + shortNum2}");
        Console.WriteLine($"Resta: {shortNum1} - {shortNum2} = {shortNum1 - shortNum2}");
        Console.WriteLine($"Multiplicación: {shortNum1} * {shortNum2} = {shortNum1 * shortNum2}");
        Console.WriteLine($"División: {shortNum1} / {shortNum2} = {(shortNum2 != 0 ? (shortNum1 / shortNum2).ToString() : "Error: División por cero")}");

        Console.WriteLine("\n*OPERACIONES CON BYTE:(Ejemplo de 0 a 255) *");
        Console.Write("Ingrese el primer número BYTE: ");
        byteNum1 = Convert.ToByte(Console.ReadLine());

        Console.Write("Ingrese el segundo número BYTE: ");
        byteNum2 = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("\nOperaciones con BYTE:");
        Console.WriteLine($"Suma: {byteNum1} + {byteNum2} = {byteNum1 + byteNum2}");
        Console.WriteLine($"Resta: {byteNum1} - {byteNum2} = {byteNum1 - byteNum2}");
        Console.WriteLine($"Multiplicación: {byteNum1} * {byteNum2} = {byteNum1 * byteNum2}");
        Console.WriteLine($"División: {byteNum1} / {byteNum2} = {(byteNum2 != 0 ? (byteNum1 / byteNum2).ToString() : "Error: División por cero")}");

        Console.WriteLine("\nPresiona ENTER para salir...");
        Console.ReadLine();
    }
}

