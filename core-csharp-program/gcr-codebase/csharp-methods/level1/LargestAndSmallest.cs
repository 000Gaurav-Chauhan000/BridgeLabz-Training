using System;
using System.Globalization;
class LargestAndSmallest
{
    static int[] findLargestAndSmallest(int[] nums)
    {
        int[] ans = new int[2];
        int smallest = nums[0];
        int largest = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < smallest)
            {
                smallest = nums[i];
            }
            if (nums[i] > largest)
            {
                largest = nums[i];
            }
        }

        ans[0] = smallest;
        ans[1] = largest;

        return ans;
    }
    static void Main()
    {
        Console.WriteLine("Enter the numbers in the Array ");

        int[] nums = new int[3];
        for (int i = 0; i < nums.Length; i++){
            
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] result = findLargestAndSmallest(nums);

        Console.WriteLine("Smallest number: " + result[0]);
        Console.WriteLine("Largest number: " + result[1]);
    }
}