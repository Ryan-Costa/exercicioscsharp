using System;
using System.Globalization;

namespace Exercicio_4 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o número do funcionário:");
            int numeroFuncionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas:");
            double numeroDeHoras = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora trabalhada:");
            double valorPorHoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = numeroDeHoras * valorPorHoras;
            Console.WriteLine("NUMBER = "+numeroFuncionario);
            Console.WriteLine("SALARY = US$"+resultado.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
