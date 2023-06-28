using System;

namespace Method {
    class Program {
        public static double Circumference(double r) {
            double pi = 3.14;
            return r * pi * 2;
        }

        static void Main(string[] args) {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine(Circumference(r));
        }
    }
}