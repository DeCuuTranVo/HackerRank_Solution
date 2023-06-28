using System;

namespace Loop {
    class Program {
        static void Main(string[] args) {
			int[] a = new int[10];
			// Use for loop to enter the values of elements in array
			for (int i = 0; i < 10; i++) {
				a[i] = int.Parse(Console.ReadLine());
			}
			// Use for loop to display the entered values of elements in array
			for (int i = 0; i < 10; i++) {
				Console.Write(a[i] + " ");
			}
		}
    }
}
