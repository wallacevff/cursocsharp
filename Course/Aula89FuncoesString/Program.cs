using System;

namespace Aula89FuncoesString {
    class Program {
        static void Main(string[] args) {
            string original = "abcde FHIJ ABC abc DEFG    ";
            string whitespace = "    ";

            string s2 = original.ToUpper();
            string s1 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3,5);

            string s6 = original.Replace('a','x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: - " + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("toLower: - " + s2 + "-");
            Console.WriteLine("Trim: - " + s3 + "-");
            Console.WriteLine("indexOf('bc'): " + n1);
            Console.WriteLine("indexOf('bc'): " + n2);
            Console.WriteLine("SubString(3): - " + s4 + "-");
            Console.WriteLine("SubString(3,5): - " + s5 + "-");
            Console.WriteLine("Replace('a','x'): - " + s6 + "-");
            Console.WriteLine("Replace('abc','xy'): - " + s7 + "-");
            Console.WriteLine("IsNullOrEmpty(original): " + b1);
            Console.WriteLine("IsNullOrEmpty(original): " + b2);


        }
    }
}
