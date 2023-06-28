using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
			int i = 1;
			do {
				if (i %10 == 0) {
					Console.Write(i + " ");
				}
				i++;
			} while (i <= 1000);
		}
    }
}
