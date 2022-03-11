using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace projetoAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("AREA DO CIRCULO");
            for (int i = 1; i <= 50; i++)
            {
                CalculoArea(i);
                Thread.Sleep(200);
            }
           
            Console.ReadKey();
        }
        public static void CalculoArea(double raio)
        {                
            double area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine("A area do circulo de raio {0:N0} é: {1:N2}", raio, area);
        }
    }
}