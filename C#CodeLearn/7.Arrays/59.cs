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

			int maxVal = a[0];
			for (int i = 0; i < n; i++) {
				if (maxVal < a[i]) {
					maxVal = a[i];
				}
			}
			Console.WriteLine(maxVal);
		}
	}
}
