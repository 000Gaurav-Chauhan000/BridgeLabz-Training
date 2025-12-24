using System;
class MeanHeight{
    static void Main(){
        double []height = new double[11];
        double sum = 0;

        for(int i = 0; i < height.Length; i++ ){

            Console.WriteLine("Enter the height of player " + (i+1) + " : ");
            height[i] = Convert.ToDouble(Console.ReadLine());
            sum += height[i];
        }

        foreach(double i in height){
            Console.WriteLine(i);
        }
        Console.WriteLine("The mean height is : " + (sum/11));

    }
}