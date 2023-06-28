using System;

namespace Input {
    class Program {
        static void Main(string[] args) {
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine((char)(c + 1));
        }
    }
}
