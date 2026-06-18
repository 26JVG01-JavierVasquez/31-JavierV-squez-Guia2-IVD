using System;

class Program
{
    static void Main()
    {
        int[] edadesPersonas = new int[7];
        int cantidadMayoresEdad = 0;

        for (int indice = 0; indice < 7; indice++)
        {
            Console.Write("Ingrese la edad de la persona " + (indice + 1) + ": ");
            edadesPersonas[indice] = Convert.ToInt32(Console.ReadLine());

            if (edadesPersonas[indice] >= 18)
            {
                cantidadMayoresEdad++;
            }
        }

        Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadMayoresEdad);
    }
}