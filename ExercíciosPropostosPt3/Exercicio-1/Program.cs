using System;

namespace Exercicio_1 {
    class Program {
        static void Main(string[] args) {

            int senha = 2002;
            Console.Write("Digite a senha: ");
            int senhaDigitada = int.Parse(Console.ReadLine());

            while (senhaDigitada != senha) {
                Console.WriteLine("Senha inválida");
                Console.Write("Digite a senha: ");
                senhaDigitada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido!");

        }
    }
}
