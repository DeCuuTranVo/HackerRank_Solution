using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int cumsum = 0;
            for (int i = a; i <= b; i++) {
                cumsum += i;
            }
            Console.WriteLine(cumsum);
        }
    }
}
