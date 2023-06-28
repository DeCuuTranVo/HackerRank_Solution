using System;

namespace Input {
    class Program {
        static void Main(string[] args) {
            double pi = 3.14;
            double r = double.Parse(Console.ReadLine());
            double circumference = r * 2 * pi; 
            Console.WriteLine("Circumference = " + circumference); 
        }
    }
}
