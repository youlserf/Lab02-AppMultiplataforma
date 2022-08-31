using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largo, ancho, perimetro, area;

            // ENTRADA
            Console.WriteLine("Ingresa el largo del rectangulo");
            largo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el ancho del rectangulo");
            ancho = Convert.ToDouble(Console.ReadLine());

            // PROCESO
            perimetro = (2 * ancho) + (2 * largo);
            area = ancho * largo;
            int i = 0;
            int j = 0;
            while (i < ancho)
            {
                if (i == 0)
                {
                    for (int b = 0; b < largo; b++)
                    {
                        Console.Write("# ");
                    }
                    Console.WriteLine();
                }
                while (j < ancho - 2)
                {
                    Console.Write("#");
                    for (int c = 0; c < largo - 2; c++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(" ");
                    Console.Write("#");
                    Console.WriteLine();
                    j++;
                }
                if (i == ancho - 1)
                {
                    for (int b = 0; b < largo; b++)
                    {
                        Console.Write("# ");
                    }
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El perímetro del rectangulo es");
            Console.WriteLine(perimetro);
            Console.WriteLine("El area del rectangulo es");
            Console.WriteLine(area);
            Console.Read();
        }
    }
}
