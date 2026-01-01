using System;

namespace MathematicalOperations{
    internal class GCDofNumber{
       public static int calculateGCD(int a, int b){
            if (a < 0 || b < 0){
                throw new ArgumentException("Numbers must be non-negative.");
            }
            while (b != 0){
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
            
    }             
}
