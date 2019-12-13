using System;

namespace Aula72ModificadorParametros {
    class Program {
        static void Main(string[] args) {
            int soma = 0;
            soma = Calculaor.Sum( 2, 3, 4 );
            Console.WriteLine(soma);
        }
    }
}
