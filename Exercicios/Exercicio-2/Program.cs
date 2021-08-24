using System;
using System.Globalization;

namespace Exercicio_2 {
    class Program {
        static void Main(string[] args) {

            double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * raio * raio;

            Console.WriteLine("Área = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
