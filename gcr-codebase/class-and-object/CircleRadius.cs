using System;

class CircleRadius{
    double radius;
    public CircleRadius(double r){
        radius = r;
    }
    public void DisplayArea(){
        Console.WriteLine("Area: " + (Math.PI * radius * radius) + "square meters");
    }

    public void DisplayCircumference(){
        Console.WriteLine("Circumference: " + (2 * Math.PI * radius) + " meter");
    }
     static void Main(){
        Console.Write("Enter radius in meter: ");
        double r = Convert.ToDouble(Console.ReadLine());

        CircleRadius c = new CircleRadius(r);
        c.DisplayArea();
        c.DisplayCircumference();
    }
}


   
