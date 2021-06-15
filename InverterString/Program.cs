using System;
using System.Linq;

namespace InverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            //continue a solução
           
            string textoInvertido = new string(n.Reverse().ToArray());
            Console.WriteLine(textoInvertido);
        }
    }
}
