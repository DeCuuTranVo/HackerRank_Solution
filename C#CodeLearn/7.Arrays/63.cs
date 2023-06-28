using System;

namespace Array {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            for (int i = 0; i < n; i++) {
				if ((arr[i] % 2 == 1) && (arr[i] > 0)) {
					counter += arr[i];
				} 
			}

            Console.WriteLine(counter);
        }
    }
}
