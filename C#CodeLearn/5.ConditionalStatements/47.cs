using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
           int n = int.Parse(Console.ReadLine());
           int cumprod = 1;

           for (int i = 1; i <= n; i++) {
               cumprod *= i;
           }
           Console.WriteLine(cumprod);
		}
    }
}
