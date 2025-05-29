using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prom;
            int[] vector;
            vector = new int[100];
            int cont = 0;
            Console.WriteLine("ingresar el primer numero del vector o -1 para salir");
            int m = Convert.ToInt32(Console.ReadLine());
            while (m != -1)
            {
                if (cont < 100)

                {
                    vector[cont] = m;
                    cont++;
                    Console.WriteLine("ingresar el {0} numero del vector o -1 para salir", (cont + 1));
                    m = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(" llego al maximo de numeros ingresados");
                    m = -1;
                }


            }
            int acum = 0;
            int minimo = 0, maximo = 0;
            if (cont != 0)
            {
                for (int i = 0; i < cont - 1; i++)
                {
                    for (int j = i + 1; j < cont; j++)
                    {
                        if (vector[i] > vector[j])
                        {
                            int aux = vector[i];
                            vector[i] = vector[j];
                            vector[j] = aux;
                        }
                    }
                }

                for (int i = 0; i < cont; i++)
                {
                    Console.WriteLine("el numero en la posicion {0}:{1} ", i, vector[i]);
                    acum = acum + vector[i];
                    if (i == 0)
                    {
                        minimo = i;
                        maximo = i;
                    }
                    if (vector[i] < vector[minimo])
                    {
                        minimo = i;
                    }
                    if (vector[i] > vector[maximo])
                    {
                        maximo = i;
                    }
                    
                }
                    if (acum != 0)
                    {
                        prom = 1.0 * acum / cont;
                        Console.WriteLine("el promedio es : " + prom);
                        Console.WriteLine("el maximo en el indice {0}: {1} ", maximo, vector[maximo]);
                        Console.WriteLine("el minimo es {0}: {1} ", minimo, vector[minimo]);

                    }
                    else
                    {
                        Console.WriteLine(" no se pudo calcular promedio");
                    }
            }
            else
            {
                Console.WriteLine(" no se ingresaron valores ");
            }
            Console.ReadKey();
        }
    }
}
