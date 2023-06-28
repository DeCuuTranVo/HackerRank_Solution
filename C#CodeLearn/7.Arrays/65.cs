using System;

namespace Array {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++) {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // insertion sort
            for (int i = 0; i < n; i++) {
                // choose smallest value in the array from i
                int currMin = arr[i];
                int minIdx = i;
                for (int j = i; j < n; j++) {
                    if (currMin > arr[j]) {
                        currMin = arr[j];
                        minIdx = j;
                    }
                }

                // swap arr[i] and arr[smallest_value_index]
                int temp = arr[i];
                arr[i] = arr[minIdx];
                arr[minIdx] = temp;
            }

            // Print result
            for (int i = 0; i < n; i++) {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
