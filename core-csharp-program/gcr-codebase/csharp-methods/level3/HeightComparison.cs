using System;

class HeightComparison{
    static int FindSum(int[] heights){
        int sum = 0;
        for (int i = 0; i < heights.Length; i++){
            sum += heights[i];
        }
        return sum;
    }

    static double FindMean(int[] heights){
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    static int FindShortest(int[] heights){

        int shortest = heights[0];
        for (int i = 1; i < heights.Length; i++){

            if (heights[i] < shortest)
                shortest = heights[i];
        }
        return shortest;
    }

    static int FindTallest(int[] heights){

        int tallest = heights[0];
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > tallest)
                tallest = heights[i];
        }
        return tallest;
    }

    static void Main(){
        int[] heights = new int[11];
        Random rand = new Random();

        for (int i=0; i<heights.Length; i++){
            heights[i] = rand.Next(150, 251);
        }

        Console.WriteLine("Player Heights:");

        for (int i = 0; i < heights.Length; i++){
             Console.WriteLine("Player "+(i+1)+": "+heights[i]+" cm");
        }
        Console.WriteLine("shortest height : " + FindShortest(heights) +" cm");
        Console.WriteLine("tallest height : " + FindTallest(heights) +" cm");
        Console.WriteLine("mean height : " + FindMean(heights) +" cm");
    }
}
