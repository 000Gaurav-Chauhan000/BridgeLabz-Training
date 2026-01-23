using System;

class ExceptionPropagationAlgo
{
    static void Method1()
    {
        int x = 10 / 0; // Throws ArithmeticException
    }

    static void Method2()
    {
        Method1();
    }

    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
