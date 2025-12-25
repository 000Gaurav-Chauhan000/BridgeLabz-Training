using System;

class VoteChecker
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0) return false;

        if (age >= 18) return true;
        return false;
    }
}

class VotingTest{
    static void Main(){

        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++){
            Console.WriteLine("Enter age of student "+(i+1));
            ages[i] = Convert.ToInt32(Console.ReadLine());

            if (VoteChecker.CanStudentVote(ages[i])) Console.WriteLine(" can vote");
            
            else Console.WriteLine(" cannot vote.");
        }
    }
}
