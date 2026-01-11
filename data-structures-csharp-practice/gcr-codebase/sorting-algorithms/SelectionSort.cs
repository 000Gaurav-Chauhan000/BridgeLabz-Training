using System;

class SelectionSort
{
    static void Main()
    {
        int[] examScores = { 72, 88, 95, 64, 81, 70 };

        SelectionSortAlgo(examScores);

        foreach (int score in examScores)
        {
            Console.Write(score + " ");
        }
    }

    static void SelectionSortAlgo(int[] scores)
    {
        int totalScores = scores.Length;

        for (int currentPosition = 0; currentPosition < totalScores - 1; currentPosition++)
        {
            int minimumPosition = currentPosition;

            for (int nextPosition = currentPosition + 1; nextPosition < totalScores; nextPosition++)
            {
                if (scores[nextPosition] < scores[minimumPosition])
                {
                    minimumPosition = nextPosition;
                }
            }

            int tempValue = scores[minimumPosition];
            scores[minimumPosition] = scores[currentPosition];
            scores[currentPosition] = tempValue;
        }
    }
}
