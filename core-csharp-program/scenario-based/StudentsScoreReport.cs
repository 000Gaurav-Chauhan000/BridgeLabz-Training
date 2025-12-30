using System;
using System.Numerics;

class StudentsScoreReport{
    static void Main(){
        RunApp();
    }
    static void RunApp(){
        Console.WriteLine("Enter the number of students : ");
        int numberOfstudents = ReadNonNegativeInt();
        Console.WriteLine("Enter the Marks of students : ");

        int[] studentMarks = new int[numberOfstudents];
        int totalMarks = 0;       
        
        for(int i = 0; i < numberOfstudents; i++){
            studentMarks[i] = ReadNonNegativeInt();
            totalMarks += studentMarks[i];
        }

        float average = (float)totalMarks/numberOfstudents;

        Console.WriteLine("The total Score is : " + totalMarks);
        Console.WriteLine("The average score of the students is : "+ average.ToString("0.00"));

        Console.WriteLine("The marks above average are : ");

        foreach(int i in studentMarks){
            if(i > average){
                Console.WriteLine(i);
            }
        }
    }
    static void FindMaxAndMin(int[] arr){
        int max = int.MinValue;
        int min = int.MaxValue;
        for(int i = 0; i<arr.Length; i++){
            if(arr[i] > max){
                max = arr[i];
            }
            if(arr[i] < min){
                min = arr[i];
            }
        }
        Console.WriteLine("The maximum marks scored are : "+ max);
        Console.WriteLine("The least marks scored are : " + min);
    }
    static int ReadNonNegativeInt(){
        int value;
        while (true){
            if (!int.TryParse(Console.ReadLine(), out value)){
                Console.WriteLine(" Enter a valid number:");
            }
            else if (value < 0){
                Console.WriteLine("Enter a positive value:");
            }
            else{
                return value;
            }
        }
    }

}