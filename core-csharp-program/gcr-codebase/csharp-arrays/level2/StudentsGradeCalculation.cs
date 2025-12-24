using System;
class StudentsGradeCalculation{
    static void Main(string[] args){
        Console.WriteLine("Please enter the number of students: ");
        int studentsCount = int.Parse(Console.ReadLine());

        double[] physicsMarks = new double[studentsCount];
        double[] chemistryMarks = new double[studentsCount];
        double[] mathsMarks = new double[studentsCount];
        double[] percentages = new double[studentsCount];
        char[] grades = new char[studentsCount];

        for (int i = 0; i < studentsCount; i++){
            Console.WriteLine("Enter the marks of student " + (i + 1) + " in Physics, Chemistry & Maths, respectively: ");
            physicsMarks[i] = Convert.ToDouble(Console.ReadLine());
            chemistryMarks[i] = Convert.ToDouble(Console.ReadLine());
            mathsMarks[i] = Convert.ToDouble(Console.ReadLine());
            percentages[i] = (physicsMarks[i] + chemistryMarks[i] + mathsMarks[i]) / 300 * 100;

            if (percentages[i] >= 80)
            {
                grades[i] = 'A';
            }
            else if (percentages[i] >= 70 && percentages[i] <= 79)
            {
                grades[i] = 'B';
            }
            else if (percentages[i] >= 60 && percentages[i] <= 69)
            {
                grades[i] = 'C';
            }
            else if (percentages[i] >= 50 && percentages[i] <= 59){
                grades[i] = 'D';
            }
            else if (percentages[i] >= 40 && percentages[i] <= 49){
                grades[i] = 'E';
            }
            else {
                grades[i] = 'R';
            }
        }
        for (int x = 0; x < studentsCount; x++)
        {
            Console.WriteLine("Results of student " + (x + 1) + " are : ");
            Console.WriteLine("Marks in Physics: " + physicsMarks[x]);
            Console.WriteLine("Marks in Chemistry: " + chemistryMarks[x]);
            Console.WriteLine("Marks in Maths: " + mathsMarks[x]);
            Console.WriteLine("Percentage: " + percentages[x]);
            Console.WriteLine("Grade: " + grades[x]);
        }
    }
}