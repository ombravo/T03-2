using System;

namespace T03_basics_2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            //Declaración de variables 
            int N;
            double A;
            char C;
            double Resultado;
            int c;

            //Asignar valores a variables
            N = 10;
            A = 2.50;
            C = 'B';
            Resultado = 0;
            c = 0;

            //Mostrar resultados
            Console.WriteLine("Los valores de las variables son los siguientes:");
            Console.WriteLine("N = {0}", N);
            Console.WriteLine("A = {0}", A);
            Console.WriteLine("C = {0}", C);

            Resultado = N + A; //suma
            Console.WriteLine("El resultado de la suma de N y A es {0}", Resultado);
            
            Resultado = A - N; //diferencia
            Console.WriteLine("El resultado de la diferencia de A y N es {0}", Resultado);

            c = (int) C; //Conversión explicita de tipo de dato de variable C
            Console.WriteLine("Valor numérico del carácter C = {0}", c);
        }
    }
}