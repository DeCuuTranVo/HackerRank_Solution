using System;

namespace Statement {
    class Program {
        static void Main(string[] args) {
            int score = int.Parse(Console.ReadLine());
            if (score >= 0 && score <= 10) {
                Console.WriteLine("The score is valid");
            } else {
                Console.WriteLine("The score is not valid");
            }
        }
    }
}
