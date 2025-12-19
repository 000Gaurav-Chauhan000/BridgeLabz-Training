using System;

class Operators
{
    static void Main()
    {
        int firstNum = 8;
        int secondNum = 2;

        // Arithmetic operators
        int add = firstNum + secondNum;
        int subtract = firstNum - secondNum;
        int product = firstNum * secondNum;
        int divide = firstNum / secondNum;
        int mod = firstNum % secondNum;

        Console.WriteLine("Addition: " + add);
        Console.WriteLine("Subtraction: " + subtract);
        Console.WriteLine("Multiplication: " + product);
        Console.WriteLine("Division: " + divide);
        Console.WriteLine("Modulo: " + mod);

        // Relational Operators
        Console.WriteLine("Equals to: " + (firstNum == secondNum));
        Console.WriteLine("Greater than: " + (firstNum > secondNum));
        Console.WriteLine("Lesser than: " + (firstNum < secondNum));
        Console.WriteLine("Greater than equals: " + (firstNum >= secondNum));
        Console.WriteLine("Less than equals: " + (firstNum <= secondNum));

        // Logical Operators
        bool a = true;
        bool b = false;

        Console.WriteLine("Logical AND: " + (a && b));
        Console.WriteLine("Logical OR: " + (a || b));
        Console.WriteLine("Logical NOT: " + (!a));

        // Assignment Operators
        int x = 5;
        int y = 10;

        Console.WriteLine("Original Value: " + x);

        x += y;
        Console.WriteLine("After += : " + x);

        x -= y;
        Console.WriteLine("After -= : " + x);

        // Unary Operators
        x--;
        Console.WriteLine("After -- : " + x);

        x++;
        Console.WriteLine("After ++ : " + x);

        // Ternary Operator (with int)
        int max = (x > y) ? x : y;
        Console.WriteLine("Greater value: " + max);

        // Ternary Operator (with bool)
        string result = (a == true) ? "a is true" : "a is false";
        Console.WriteLine(result);

        // Type Operator: is
        object value = 20;

      if (value is int){
        int n = (int)value;
        Console.WriteLine("Value is int: " + n);
}

    }
}
