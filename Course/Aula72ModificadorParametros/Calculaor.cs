using System;
using System.Collections.Generic;
using System.Text;

namespace Aula72ModificadorParametros {
    class Calculaor {

        public static int Sum(params int[] args) {
            int sum = 0;
            for(int i = 0; i < args.Length; i++) {
                sum += args[i];
            }
            return sum;
        }

    }
}
