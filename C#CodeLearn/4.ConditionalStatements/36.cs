using System;

namespace Statement {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a != 0 && b != 0) {
                Console.WriteLine("a is not equal to 0 and b is not equal to 0");
            } else {
                Console.WriteLine("a is equal to 0 or b is equal to 0");
            }
        }
    }
}
