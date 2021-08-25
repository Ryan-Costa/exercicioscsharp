using System;
using System.Globalization;

namespace Exercicio_5 {
    class Program {
        static void Main(string[] args) {
            int codPeca1, codPeca2, quantidadePeca1, quantidadePeca2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(valores[0]);
            quantidadePeca1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(valores[0]);
            quantidadePeca2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * quantidadePeca1 + preco2 * quantidadePeca2;

            Console.WriteLine("VALOR À PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
