using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
			for (int i = 1; i <= 100; i++) {
				if ( i > 50) {
					break;
				}
				Console.Write(i + " ");
			}
		}
    }
}
