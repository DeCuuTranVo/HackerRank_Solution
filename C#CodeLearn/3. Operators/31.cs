using System;

namespace Input {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool fact = a > b;
            Console.WriteLine(fact);
        }
    }
}