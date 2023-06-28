using System;

namespace Statement {
    class Program {
        static void Main(string[] args) {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            if (name1 == name2) {
                Console.WriteLine("two people have the same name");
            } else {
                Console.WriteLine("two people don't have the same name");
            }
		}
    }
}
