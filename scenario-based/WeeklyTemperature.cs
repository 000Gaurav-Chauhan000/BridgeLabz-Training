using System;
using System.ComponentModel;

class WeeklyTemperature{
    static void Main(){
        RunProgram();
    }
      static void RunProgram(){
        int days = 7;
        int hours = 24;

        float[,] temperatures = new float[days, hours];

        Console.WriteLine("Enter the weekly temperatures : ");
        Random randomTemperatures = new Random();

        for(int i = 0; i<days; i++){
            for(int j = 0; j<hours; j++){
                temperatures[i,j] = (float) randomTemperatures.NextDouble() * 10;
                Console.Write( temperatures[i,j].ToString("0.00" )+ "  ");
            }
            Console.WriteLine("\n");
        }
        float[] temperatureArray = AverageTemperatures(temperatures);
        ShowHottestAndColdestDay(temperatureArray);
        
    }
    static float[] AverageTemperatures(float[,] arr){
       
        int days = arr.GetLength(0);       
        int hours = arr.GetLength(1);

        String[] daysOfWeek =  {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        float[] averageTemperature = new float[days];

        for(int i = 0; i<days; i++){

            float totalTemperature = 0.0f;

            for(int j = 0; j <hours; j++){
                totalTemperature += arr[i,j];
            }
            averageTemperature[i] = totalTemperature/hours;
        }
        for(int i = 0; i < days; i++){
            Console.WriteLine("The average temperature for " +daysOfWeek[i] + " : " + averageTemperature[i].ToString("0.00"));
        }
        return averageTemperature;
    }

    static void ShowHottestAndColdestDay(float[] averageTemperatures){
        string[] daysOfWeek ={"Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday"};

        float maxTemp = averageTemperatures[0];
        float minTemp = averageTemperatures[0];

        int hottestDay = 0;
        int coldestDay = 0;

        for (int i = 1; i < averageTemperatures.Length; i++){
        if (Math.Max(maxTemp, averageTemperatures[i]) != maxTemp){
            maxTemp = averageTemperatures[i];
            hottestDay = i;
        }

            if (Math.Min(minTemp, averageTemperatures[i]) != minTemp){
                minTemp = averageTemperatures[ i ];
                coldestDay = i;
            }
        }
        Console.WriteLine("\n\nHottest Day: " + daysOfWeek[hottestDay]+" with temperature " + maxTemp.ToString("0.00"));
        Console.WriteLine("\nColdest Day: " + daysOfWeek[coldestDay] +" with temperature " +minTemp.ToString("0.00"));
    }
}