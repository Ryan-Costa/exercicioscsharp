﻿using System;

namespace Exercicio_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if(numero % 2 == 0) {
                Console.WriteLine("PAR");
            }else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
