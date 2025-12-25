using System;

class YoungestAndTallest{
    static int FindYoungest(int[] ages){
        int youngest = ages[0];
        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < youngest)    youngest = ages[i];
        }
        return youngest;
    }

    static double FindTallest(double[] heights){
        double tallest = heights[0];
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > tallest)
                tallest = heights[i];
        }
        return tallest;
    }

    static void Main(){

        string[] names = {"Amar", "Akbar", "Anthony"};

        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++){

            Console.WriteLine("Enter age of " + names[i]);
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height of " + names[i]);
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngestAge = FindYoungest(ages);
        double tallestHeight = FindTallest(heights);

        for (int i = 0; i < 3; i++){

            if (ages[i] == youngestAge)    Console.WriteLine(names[i] + " is the youngest");

            if (heights[i] == tallestHeight)    Console.WriteLine(names[i] + " is the tallest");
        }
    }
}
