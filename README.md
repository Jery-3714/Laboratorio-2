# Laboratorio-2

¿Para qué crees que se usan los operadores lógicos en programación?
># Son símbolos o palabras clave que se usan para combinar o evaluar expresiones y obtener un resultado verdadero o falso. Se usan principalmente en condiciones para tomar decisiones en un programa.

¿Por qué es importante declarar correctamente el tipo de dato de una variable?
># Porque se minimiza el riesgo de contener fallas en el programa, es decir si quisieramos sumar un dato de tipo int con uno de tipo char, este nos daria un error.
---

# Enunciado 1: Clasificación de edad
Un programa debe determinar la categoría de una persona según su edad: ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
*if-else porque los rangos de edad son cambiantes y no valores definitivos o fijos*

```csharp
        int edad;
 Console.Write("*/*/Ingresa tu edad: */*/\n");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 12)
    Console.WriteLine("***Eres un Niño.***");
        else if (edad <= 17)
   Console.WriteLine("***Eres un Adolescente.***");
        else if (edad <= 59)
   Console.WriteLine("***Eres un Adulto.***");
        else
   Console.WriteLine("***Eres un Adulto Mayor.***");
```
---
# Enunciado 2: Día de la semana
Se quiere crear un programa que reciba un número del 1 al 7 y devuelva el nombre del día correspondiente.
¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
*Switch porque hay valores exactos y no variables.*

 ```csharp 
    Console.Write("Ingresa un número (1-7): ");
        int dia = Convert.ToInt32(Console.ReadLine());

        switch (dia)
        {
            case 1: Console.WriteLine("El día es Lunes"); break;
            case 2: Console.WriteLine("El día es Martes"); break;
            case 3: Console.WriteLine("El día es Miércoles"); break;
            case 4: Console.WriteLine("El día es Jueves"); break;
            case 5: Console.WriteLine("El día es Viernes"); break;
            case 6: Console.WriteLine("El día es Sábado"); break;
            case 7: Console.WriteLine("El día es Domingo"); break;
            default: Console.WriteLine("Número inválido"); break;
 ```
---
# Enunciado 3: Verificación de acceso
Un usuario intenta iniciar sesión en una aplicación.
¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?

 ```csharp 
*if-else porque hay múltiples combinaciones de usuario y contraseña.*

    string usuarioCorrecto = "Jery";
    string contrasenaCorrecta = "2025";

        Console.Write("Ingresa tu usuario: ");
    string usuario = Console.ReadLine();

        Console.Write("Ingresa tu contraseña: ");
    string contrasena = Console.ReadLine();

        if (usuario == usuarioCorrecto && contrasena == contrasenaCorrecta)
            Console.WriteLine("Acceso concedido");
        else if (usuario == usuarioCorrecto)
            Console.WriteLine("Contraseña incorrecta");
        else
            Console.WriteLine("Usuario no registrado");
 ```
---





