using System;
using System.Globalization;

namespace Exercicio_8 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira o valor do seu salário:");

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            double faixa1 = 2000.0;
            double faixa2 = 3000.0;
            double faixa3 = 4500.0;
            if (salario <= 2000.00) {
                imposto = 0.0;
            }
            else if (salario > 2000.00 && salario <= 3000.00) {
                imposto = (salario - faixa1) * 0.08;
            }
            else if (salario > 3000.00 && salario <= 4500.00) {
                imposto = (salario - faixa2) * 0.18 + 1000.0 * 0.08;
            }
            else {
                imposto = (salario - faixa3) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
