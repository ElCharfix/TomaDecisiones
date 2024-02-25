using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;

        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Determinar el mayor de dos números");
            Console.WriteLine("2. Determinar el mayor y el menor de dos sueldos");
            Console.WriteLine("3. Determinar el mayor, la sumatoria y el promedio de cuatro números");
            Console.WriteLine("4. Determinar la nota literal a partir de una nota numérica");
            Console.WriteLine("5. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    DeterminarMayorDeDosNumeros();
                    break;
                case "2":
                    DeterminarMayorYMenorSueldo();
                    break;
                case "3":
                    DeterminarMayorSumatoriaYPromedio();
                    break;
                case "4":
                    DeterminarNotaLiteral();
                    break;
                case "5":
                    Console.WriteLine("¡Hasta luego!");
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            if (!salir)
            {
                Console.Write("\n¿Quieres cerrar la consola? (s/n): ");
                string cerrarConsola = Console.ReadLine();
                if (cerrarConsola.ToLower() == "s")
                {
                    Console.WriteLine("¡Hasta luego!");
                    break;
                }
            }
        } while (!salir);
    }

    static void DeterminarMayorDeDosNumeros()
    {
        Console.Write("Por favor, ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Por favor, ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        if (numero1 > numero2)
            Console.WriteLine("El mayor número es: " + numero1);
        else if (numero2 > numero1)
            Console.WriteLine("El mayor número es: " + numero2);
        else
            Console.WriteLine("Los números son iguales.");
    }

    static void DeterminarMayorYMenorSueldo()
    {
        Console.Write("Por favor, ingrese el primer sueldo: ");
        double sueldo1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Por favor, ingrese el segundo sueldo: ");
        double sueldo2 = Convert.ToDouble(Console.ReadLine());

        if (sueldo1 > sueldo2)
        {
            Console.WriteLine("El mayor sueldo es: " + sueldo1);
            Console.WriteLine("El menor sueldo es: " + sueldo2);
        }
        else if (sueldo2 > sueldo1)
        {
            Console.WriteLine("El mayor sueldo es: " + sueldo2);
            Console.WriteLine("El menor sueldo es: " + sueldo1);
        }
        else
        {
            Console.WriteLine("Los sueldos son iguales.");
        }
    }

    static void DeterminarMayorSumatoriaYPromedio()
    {
        Console.Write("Por favor, ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Por favor, ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Por favor, ingrese el tercer número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Por favor, ingrese el cuarto número: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        double mayor = num1;
        if (num2 > mayor)
            mayor = num2;
        if (num3 > mayor)
            mayor = num3;
        if (num4 > mayor)
            mayor = num4;

        double sumatoria = num1 + num2 + num3 + num4;
        double promedio = sumatoria / 4;

        Console.WriteLine("El mayor número es: " + mayor);
        Console.WriteLine("La sumatoria de los números es: " + sumatoria);
        Console.WriteLine("El promedio de los números es: " + promedio);
    }

    static void DeterminarNotaLiteral()
    {
        Console.Write("Por favor, ingrese su nota (de 0 a 100): ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 90 && nota <= 100)
            Console.WriteLine("Nota literal: A");
        else if (nota >= 87 && nota < 90)
            Console.WriteLine("Nota literal: B+");
        else if (nota >= 83 && nota < 87)
            Console.WriteLine("Nota literal: B");
        else if (nota >= 80 && nota < 83)
            Console.WriteLine("Nota literal: B-");
        else if (nota >= 77 && nota < 80)
            Console.WriteLine("Nota literal: C+");
        else if (nota >= 73 && nota < 77)
            Console.WriteLine("Nota literal: C");
        else if (nota >= 70 && nota < 73)
            Console.WriteLine("Nota literal: C-");
        else if (nota >= 60 && nota < 70)
            Console.WriteLine("Nota literal: D");
        else
            Console.WriteLine("Nota literal: F");
    }
}
