using System;

class Search2DMatrix
{
    static void Main()
    {
        int[,] matrix =
        {
            { 1, 3, 5 },
            { 7, 9, 11 },
            { 13, 15, 17 }
        };

        int target = 9;

        bool found = SearchMatrixAlgo(matrix, target);

        Console.WriteLine(found ? "Target found" : "Target not found");
    }

    static bool SearchMatrixAlgo(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int left = 0;
        int right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int r = mid / cols;
            int c = mid % cols;

            if (matrix[r, c] == target)
                return true;
            else if (matrix[r, c] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }
}
