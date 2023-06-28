using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            while (n <= 100) {
                if (n % 2 == 0) {
                    Console.Write(n + " ");
                }
                n++;
		    }
        }
    }
}
