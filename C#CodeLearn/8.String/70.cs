using System;

namespace String {
    class Program {
        static void Main(string[] args) {
			string s = Console.ReadLine();
            char c = char.Parse(Console.ReadLine());

            for (int i = 0; i < s.Length; i++) {
                if (s[i] == c) {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine(-1);
            return;
		}
    }
}