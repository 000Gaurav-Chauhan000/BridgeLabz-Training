using System;

class BMIArray
{
    static void Main(){

        Console.WriteLine("Enter number of persons:");
        int count = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[count];
        double[] height = new double[count];
        double[] bmi = new double[count];
        string[] status = new string[count];

        for (int i = 0; i < count; i++){

            Console.WriteLine("Enter weight of person " +(i+1)+" in kg:");
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height of person "+(i+1)+" in meters:");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < count; i++){

            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] <= 18.4)
                status[i] = "Underweight";
            else if (bmi[i] <= 24.9)
                status[i] = "Normal";
            else if (bmi[i] <= 39.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        Console.WriteLine("Height   Weight   BMI        Status");
        for (int i = 0; i < count; i++){

            Console.WriteLine(
            height[i] + "\t" +
            weight[i] + "\t" +
            bmi[i] + "\t" +
            status[i] );
}
    }
}
