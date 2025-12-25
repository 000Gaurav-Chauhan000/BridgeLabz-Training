using System;

class QuadraticRoots{
    static double[] FindRoots(double a, double b, double c){
        double delta = (b * b) - (4 * a * c);

        if (delta > 0){
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0){
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else{
            return new double[0];
        }
    }

    static void Main(){
        Console.WriteLine("enter a : ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter b :");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("enter c : ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0){
            Console.WriteLine("no real roots");
        }
        else{
            for (int i = 0; i < roots.Length; i++){
                Console.WriteLine("root: " + roots[i]);
            }
        }
    }
}