using System;

namespace CalcularConsumoMedio
{
    class Program
    {
        static void Main(string[] args) { 

            int distancia;
            double combustivelGasto, consumoMedio;

            distancia = Convert.ToInt32(Console.ReadLine());
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = distancia/combustivelGasto; 

            Console.WriteLine($"{consumoMedio, 0:0.000} km/l");

    }
    }
}
