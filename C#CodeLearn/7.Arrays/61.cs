using System;

namespace Array {
	class Program {
		static void Main(string[] args) {
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			// Use for loop to enter the values of elements in array
			for (int i = 0; i < n; i++) {
				a[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < n; i++) {
				if (a[i] % 2 == 0) {
					Console.Write(a[i] + " ");
				} 
			}

		}
	}
}
