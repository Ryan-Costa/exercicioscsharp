using System;

namespace Exercicio_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if(numero < 0) {
                Console.WriteLine("NEGATIVO");
            }else {
                Console.WriteLine("NAO NEGATIVO");
            }

        }
    }
}
