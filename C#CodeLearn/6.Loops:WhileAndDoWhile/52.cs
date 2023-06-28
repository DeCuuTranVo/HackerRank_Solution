using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

            int result = 1;
            int i = 1;
            while (i <= b) {
                result *= a;
                i++;
            }
            Console.WriteLine(result);
		}
    }
}