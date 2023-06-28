using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int divisor_counter = 0;
            int i = 1;
            while (i <= n) {
                if (n % i == 0) {
                    divisor_counter++;
                }
                i++;
            }
            Console.WriteLine(divisor_counter);
        }
    }
}
