using System;

namespace Aula80MatrizExercicioResolvido {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com a dimensão da Matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            int[] diagonal = new int[n];
            int[] diagonal_inversa = new int[n];
            int diag = 0;
            for (int i = 0; i < n; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("\n\nMatriz:\n");
            for (int i = 0; i < n; i++) {
                Console.Write("| ");
                for (int j = 0; j < n; j++) {
                    Console.Write(mat[i, j] + " ");
                    if (i == j) {
                        diagonal[j] = mat[i, j];
                    }
                    if (j == n) {
                        diagonal_inversa[diag] = mat[i, j - diag];
                        diag++;
                    }

                }
                Console.Write("| ");
                Console.WriteLine();
            }

            Console.WriteLine("\nDiagonal:\n");
            for (int i = 0; i < n; i++) {
                Console.Write("| ");
                for (int j = 0; j < n; j++) {
                    if (i == j) {
                        Console.Write(diagonal[j] + " ");
                    } else {
                        Console.Write("0 ");
                    }
                    
                }
                Console.Write("| ");
                Console.WriteLine();
            }


        }
    }
}
