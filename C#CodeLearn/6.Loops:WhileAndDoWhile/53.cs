using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

            int i = a;
            while (i <= b) {
                if (i%3 == 0 && i%5 == 0) {
                    Console.Write(i + " ");
                }
                i++;
            }
        

		}
    }
}
