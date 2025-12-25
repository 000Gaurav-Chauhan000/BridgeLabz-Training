using System;

class RandomNumbers{
    static int[] generateRandomArray(int size){
        int[] arr = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++){
            arr[i] = rand.Next(1000, 10000);
        }
        return arr;
    }

    static double[] FindAverageMinMax(int[] numbers){
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++){
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double avg = (double)sum / numbers.Length;
        return new double[] { avg, min, max };
    }

    static void Main(){
        int[] values = generateRandomArray(5);

        Console.WriteLine("generated numbers are :");
        for (int i = 0; i < values.Length; i++){
            Console.WriteLine(values[i]);
        }

        double[] result = FindAverageMinMax(values);

        Console.WriteLine("average : " +result[0]);
        Console.WriteLine("minimum : " +result[1]);
        Console.WriteLine("maximum : " +result[2]);
    }
}
