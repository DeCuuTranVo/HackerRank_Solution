using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            
            for (int i = 0; i < s.Length; i++) {
                if (!char.IsLetter(s, i)) {
                    s = s.Replace(s[i] + "", "");
                }
            }

            Console.WriteLine(s);
        }
    }
}