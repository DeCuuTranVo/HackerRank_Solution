using System;

namespace String {
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            
            int upperCounter = 0;
            for (int i = 0; i < s.Length; i++) {
                if (Char.IsUpper(s[i])) {
                    upperCounter++;
                }    
            }

            Console.WriteLine(upperCounter);
		}
    }
}