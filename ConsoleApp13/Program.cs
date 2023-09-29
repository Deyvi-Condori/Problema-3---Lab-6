using System;

namespace Tiendita
{
    class Program
    {
        static void Main()
        {
            int maximoPersonas = 50, contadorActual = 3;

            while (true)
            {
                Console.Clear();

                double porcentajeAforo = ((double)contadorActual / maximoPersonas) * 100;

                Console.WriteLine($"=================================\n| Asistentes actuales | {contadorActual}\n| Aforo               | {porcentajeAforo:0.00}%\n| Máximo              | {maximoPersonas} personas\n====================================\nPresione\n[ i ] si ingresa una persona\n[ s ] si sale una persona\n[ x ] para terminar");
                char opcion = Console.ReadKey().KeyChar;

                if (opcion == 'i' && contadorActual < maximoPersonas)
                {
                    contadorActual++;
                }
                else if (opcion == 's' && contadorActual > 0)
                {
                    contadorActual--;
                }
                else if (opcion == 'x')
                {
                    return;
                }
            }
        }
    }
}
