using System;

namespace Programa2_solucion2
{
    // Tema: Funciones
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");

            Console.WriteLine("Seleccione una opción:");
            String opc = Console.ReadLine();

            if (opc == "1")
            {
                sumar();
            }

            if (opc == "2")
            {
                float resultado = restar();
                Console.WriteLine("El resultado de la resta es {0}", resultado);
            }

            if (opc == "3")
            {


                var nums = pedirNumeros();
                float a = nums.Item1;
                float b = nums.Item2; 
                multiplicar(a, b);
            }

            if (opc == "4")
            {
                // declarar variables
                float a = 0.0f;
                float b = 0.0f;
                String numero = "";

                // mostrar mensajes y asignar valores
                Console.WriteLine("Digite el primer número:");
                numero = Console.ReadLine();
                a = Convert.ToSingle(numero);

                Console.WriteLine("Digite el segundo número:");
                numero = Console.ReadLine();
                b = Convert.ToSingle(numero);

                float resultado = dividir(a, b);
                Console.WriteLine("El resultado de la división es {0}", resultado);
            }
        } // fin del Main

        static void sumar()
        {
            // declarar variables
            float a = 0.0f;
            float b = 0.0f;
            float c = 0.0f;
            String numero = "";

            // mostrar mensajes y asignar valores
            Console.WriteLine("Digite el primer número:");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.WriteLine("Digite el segundo número:");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            c = a + b;

            Console.WriteLine("El resultado de la suma es {0}", c);
        }

        static float restar()
        {
            // declarar variables
            float a = 0.0f;
            float b = 0.0f;
            float c = 0.0f;
            String numero = "";

            // mostrar mensajes y asignar valores
            Console.WriteLine("Digite el primer número:");
            numero = Console.ReadLine();
            a = Convert.ToSingle(numero);

            Console.WriteLine("Digite el segundo número:");
            numero = Console.ReadLine();
            b = Convert.ToSingle(numero);

            // calcular la operación
            c = a - b;

            // retornamos el valor
            return c;
        }

        static void multiplicar(float n1, float n2)
        {
            float c = 0.0f;

            c = n1 * n2;

            Console.WriteLine("El resultado de la multiplicación es {0}", c);
        }

        static float dividir(float n1, float n2)
        {
            // declarar variables
            float c = 0.0f;

            if (n2 != 0)
            {
                // calcular la operación
                c = n1 / n2;
            }
            else
            {
                c = 0.0f;
            }

            // retornamos el valor
            return c;
        }

        static Tuple<float,float> pedirNumeros()
        {
            // declarar variables

            float n1 = 0.0f;
            float n2 = 0.0f;
            String numero = "";

            // mostrar mensajes y asignar valores
            Console.WriteLine("escriba el primer numero");
            numero = Console.ReadLine();
            n1 = Convert.ToSingle(numero);

            Console.WriteLine("escriba el segundo numero");
            numero = Console.ReadLine();
            n2 = Convert.ToSingle(numero);
            return Tuple.Create(n1,n2);
        }

    }
}