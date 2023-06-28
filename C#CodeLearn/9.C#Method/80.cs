using System;

namespace Method {
    class Program {
        public static int Factorial(int n) {
            if (n == 1) {
                return 1;
            } else {
                return Factorial(n-1) * n;
            }
        } 

        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}