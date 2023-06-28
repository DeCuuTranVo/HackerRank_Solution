using System;

namespace Input {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("after swapping, a = " + a + ", b = " + b);
        }
    }
}
