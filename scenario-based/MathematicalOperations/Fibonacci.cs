using System;

namespace MathematicalOperations{
    internal class Fibonacci{
        public  static int FibonacciOf(int number){
            if (number < 0){
                throw new ArgumentException("Number must be non-negative.");
            }
            if (number == 0){
                return 0;
            }
            if (number == 1){
                return 1;
            }
            int num1 = 0, num2 = 1, num3 = 0;
            for (int i = 2; i <= number; i++){
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            return num3;
        }
    }
}