using System;
class HeightAndAge
{
    static void Main()
    {
        double[] heights = new double[3];
        int[] ages = new int[3];

        Console.WriteLine("Enter the ages : ");
        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = Convert.ToInt16(Console.ReadLine());
        }
        Console.WriteLine("Enter the heights : ");
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        double maxHeight = heights[0];

        for (int i = 1; i < heights.Length; i++){
            if (heights[i - 1] < heights[i])
            {
                maxHeight = heights[i];
            }
        }
        int youngest = ages[0];
        for (int i = 1; i <ages.Length; i++){
            if(ages[i-1] > ages[i]){
                youngest = ages[i];
            }
        }
        Console.WriteLine("The youngest age is : "+ youngest);
        Console.WriteLine("The tallest height is : "+maxHeight);
    }
}
