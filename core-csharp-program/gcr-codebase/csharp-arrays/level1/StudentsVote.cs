using System;

class StudentsVote{
    static void Main()
    {
        int[] age = new int[10];

        for (int i = 0; i < age.Length; i++){

            Console.Write("Enter age "+(i + 1)+" : ");
            age[i] = Convert.ToInt32(Console.ReadLine());
            }
            
             for (int i= 0;i <age.Length;i++){
            if (age[i] < 0){
                Console.WriteLine("age cannot be negative");
            }
            else if (age[i] >= 18){
                Console.WriteLine("The student with the age "+age[i]+" can vote");
            }
            else{
                Console.WriteLine("The student with the age "+age[i]+" cannot vote");
            }
        }
    }
}
