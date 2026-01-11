using System;

class CountingSort
{
    static void Main()
    {
        int[] studentAges = { 12, 15, 10, 14, 18, 13, 15, 11, 16 };

        CountingSortAlgo(studentAges, 10, 18);

        foreach (int age in studentAges)
        {
            Console.Write(age + " ");
        }
    }

    static void CountingSortAlgo(int[] ages, int minimumAge, int maximumAge)
    {
        int range = maximumAge - minimumAge + 1;
        int[] ageFrequency = new int[range];
        int[] sortedAges = new int[ages.Length];

        for (int index = 0; index < ages.Length; index++)
        {
            ageFrequency[ages[index] - minimumAge]++;
        }

        for (int index = 1; index < ageFrequency.Length; index++)
        {
            ageFrequency[index] += ageFrequency[index - 1];
        }

        for (int index = ages.Length - 1; index >= 0; index--)
        {
            int currentAge = ages[index];
            int position = ageFrequency[currentAge - minimumAge] - 1;
            sortedAges[position] = currentAge;
            ageFrequency[currentAge - minimumAge]--;
        }

        for (int index = 0; index < ages.Length; index++)
        {
            ages[index] = sortedAges[index];
        }
    }
}
