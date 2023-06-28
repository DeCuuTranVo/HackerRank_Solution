using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int cumsumodd = 0;
            for (int i = 0; i <= n; i++) {
                if (i %2 == 1) {
                    cumsumodd += i;
                }
            }
            Console.WriteLine(cumsumodd);
		}
    }
}