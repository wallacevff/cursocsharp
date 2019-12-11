using System;
using System.Collections.Generic;
using System.Text;

namespace Course {
    static class ConversorDeMoeda {
        static double IOF = 0.06;
        static public double Converter(double moeda, double cotacao) {
            return (moeda * cotacao) + ConversorDeMoeda.IOF * (moeda * cotacao);
        }
    }
}
