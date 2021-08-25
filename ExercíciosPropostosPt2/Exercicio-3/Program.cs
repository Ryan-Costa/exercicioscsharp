using System;

namespace Exercicio_3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira dois números inteiros:");
            string[] valores = Console.ReadLine().Split(' ');

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if(A % B == 0 || B % A == 0) {
                Console.WriteLine("São multiplos");
            }else {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}
