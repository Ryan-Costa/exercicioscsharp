using System;
using System.Globalization;

namespace Exercicio_6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira um número qualquer:");

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(numero < 0.0 || numero > 100.0) {
                Console.WriteLine("Fora de intervalo");
            }else if(numero <= 25.00) {
                Console.WriteLine("Intervalo (0,25]");
            }else if(numero <= 50.00) {
                Console.WriteLine("Intervalo (25.50]");
            }else if(numero <= 75.00) {
                Console.WriteLine("Intervalo (50.75]");
            }else {
                Console.WriteLine("Intervalo (75.100]");
            }

        }
    }
}
