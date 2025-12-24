using System;

class BMIArray2{
    static void Main()
    {
        Console.WriteLine("Enter number of persons:");
        int number = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            personData[i] = new double[3];

            Console.WriteLine("Enter weight of person " + (i + 1) + " in kg:");
            double weight = Convert.ToDouble(Console.ReadLine());

            if (weight <= 0)
            {
                i--;
                continue;
            }

            Console.WriteLine("Enter height of person " + (i + 1) + " in meters:");
            double height = Convert.ToDouble(Console.ReadLine());

            if (height <= 0)
            {
                i--;
                continue;
            }

            personData[i][0] = weight;
            personData[i][1] = height;
        }

        for (int i = 0; i < number; i++)
        {
            double weight = personData[i][0];
            double height = personData[i][1];

            double bmi = weight / (height * height);
            personData[i][2] = bmi;

            if (bmi <= 18.4)
                weightStatus[i] = "Underweight";
            else if (bmi <= 24.9)
                weightStatus[i] = "Normal";
            else if (bmi <= 39.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        Console.WriteLine("Height   Weight   BMI       Status");

        for (int i = 0; i < number; i++)
        {
           Console.WriteLine(
            personData[i][1] + "   " +
             personData[i][0] + "   " +
             personData[i][2] + "   " +
             weightStatus[i]
            );

        }
    }
}
