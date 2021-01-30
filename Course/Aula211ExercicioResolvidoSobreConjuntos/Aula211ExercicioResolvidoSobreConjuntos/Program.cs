/* Um site de internet registra um log de acessos dos usuários. Um registro de log consiste no nome de usuário e o 
* instante em que o usuário acessou o site no padrão ISO 8601, separados por espaço, conforme exemplo. Fazer um
* programa que leia o log de acessos a partir de um arquico e daí informe quantos usuários distintos acessaram o site. 
*/
using System;
using System.IO;
using System.Collections.Generic;
using Aula211ExercicioResolvidoSobreConjuntos.Entities;


namespace Aula211ExercicioResolvidoSobreConjuntos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter log file name: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(@"..\..\..\" + path +".txt"))
                {
                    HashSet<LogRegister> logRegisters = new HashSet<LogRegister>();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        logRegisters.Add(new LogRegister(line));
                    }
                    Console.WriteLine("Total users: " + logRegisters.Count);
                    logRegisters.PrintItens();
                    
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
