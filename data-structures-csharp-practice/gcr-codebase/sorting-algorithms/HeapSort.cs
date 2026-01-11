using System;

class HeapSort
{
    static void Main()
    {
        int[] expectedSalaries = { 60000, 45000, 80000, 50000, 70000 };

        HeapSortAlgo(expectedSalaries);

        foreach (int salary in expectedSalaries)
        {
            Console.Write(salary + " ");
        }
    }

    static void HeapSortAlgo(int[] salaries)
    {
        int totalElements = salaries.Length;

        for (int index = totalElements / 2 - 1; index >= 0; index--)
        {
            HeapifyAlgo(salaries, totalElements, index);
        }

        for (int index = totalElements - 1; index > 0; index--)
        {
            int tempValue = salaries[0];
            salaries[0] = salaries[index];
            salaries[index] = tempValue;

            HeapifyAlgo(salaries, index, 0);
        }
    }

    static void HeapifyAlgo(int[] salaries, int heapSize, int rootIndex)
    {
        int largestIndex = rootIndex;
        int leftChildIndex = 2 * rootIndex + 1;
        int rightChildIndex = 2 * rootIndex + 2;

        if (leftChildIndex < heapSize && salaries[leftChildIndex] > salaries[largestIndex])
        {
            largestIndex = leftChildIndex;
        }

        if (rightChildIndex < heapSize && salaries[rightChildIndex] > salaries[largestIndex])
        {
            largestIndex = rightChildIndex;
        }

        if (largestIndex != rootIndex)
        {
            int tempValue = salaries[rootIndex];
            salaries[rootIndex] = salaries[largestIndex];
            salaries[largestIndex] = tempValue;

            HeapifyAlgo(salaries, heapSize, largestIndex);
        }
    }
}
