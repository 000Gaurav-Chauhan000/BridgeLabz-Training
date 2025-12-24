using System;
class TwoDimensionalArray{
    static void Main()
    {
        Console.WriteLine("Enter the no. of rows");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the no. of columns");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows,columns];

        for(int i = 0; i< rows; i++){
            for(int j = 0; j<columns; j++){
                
                Console.WriteLine("enter the elements : ");
                array[i,j] = Convert.ToInt32(Console.ReadLine());
            }            
        }
        int []array2 = new int [rows*columns]; 
        int index = 0;
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                array2[index] = array[i, j];
                index++;
            }
        }
        Console.WriteLine("The array becomes :");
        foreach (int i in array2){

            Console.Write(i+" ");
        }
    }

}