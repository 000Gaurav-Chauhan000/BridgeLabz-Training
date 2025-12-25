using System;

class BMI{
    static void CalculateBMI(double[,] data){

        for (int i = 0; i < data.GetLength(0); i++){
            double heightInMeters = data[i, 1] / 100;
            data[i, 2] = data[i, 0] / (heightInMeters * heightInMeters);
        }
    }

    static string[] GetBMIStatus(double[,] data){

        string[] status = new string[data.GetLength(0)];
        for (int i = 0; i < data.GetLength(0); i++){
            double bmi = data[i, 2];

            if (bmi <= 18.4)      status[i] = "Underweight";
            else if (bmi <= 24.9)    status[i] = "Normal";
            else if (bmi <= 39.9)    status[i] = "Overweight";
            else    status[i] = "Obese";
        }
        return status;
    }

    static void Main()
    {
        double[,] personData = new double[10, 3];
        string[] bmiStatus;

        for (int i = 0; i < 10; i++){
            Console.WriteLine("Enter weight (kg) for person " + (i + 1));
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height (cm) for person " + (i + 1));
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        CalculateBMI(personData);

        bmiStatus = GetBMIStatus(personData);

        for (int i = 0; i < 10; i++){
            Console.WriteLine(
                "Weight: " + personData[i, 0] +
                " Height: " + personData[i, 1] +
                " BMI: " + personData[i, 2] +
                " Status: " + bmiStatus[i]
            );
        }
    }
}
