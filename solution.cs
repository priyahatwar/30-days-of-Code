using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int a;
        double b;
        string c;

        
        
        // Print the sum of both integer variables on a new line.
         a =Convert.ToInt32(Console.ReadLine());
         b =Convert.ToDouble(Console.ReadLine());
         c =Console.ReadLine();
        // Print the sum of the double variables on a new line.
        Console.WriteLine(i+a);
        Console.WriteLine("{0:F1}",d+b);
        Console.WriteLine(s+c);
        
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        

    }
}