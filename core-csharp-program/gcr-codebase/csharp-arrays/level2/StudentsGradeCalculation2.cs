
using System;
class StudentsGradeCalculation2{
        static void Main(string[] args){
                Console.WriteLine("Please enter the number of students: ");
                int studentsCount = Convert.ToInt32(Console.ReadLine());

                double[,] studentsMarks = new double[studentsCount, 3];  
                double[] percentages = new double[studentsCount];
                char[] grades = new char[studentsCount];

                for(int i = 0; i < studentsCount; i++){
                        Console.WriteLine("Enter the marks of student " + (i+1) + " in Physics, Chemistry & Maths, respectively : ");
                        studentsMarks[i, 0] = Convert.ToDouble(Console.ReadLine()); 
                        studentsMarks[i, 1] = Convert.ToDouble(Console.ReadLine());
                        studentsMarks[i, 2] = Convert.ToDouble(Console.ReadLine());  
                        percentages[i] = (studentsMarks[i, 0] + studentsMarks[i, 1] + studentsMarks[i, 2]) /300 * 100;

                        if(percentages[i] >= 80){
                                grades[i] = 'A';
                        }
                        else if(percentages[i] >= 70 && percentages[i] <= 79){
                                grades[i] = 'B';
                        }
                        else if(percentages[i] >= 60 && percentages[i] <= 69){
                                grades[i] = 'C';
                        }
                        else if(percentages[i] >= 50 && percentages[i] <= 59){
                                grades[i] = 'D';
                        }
                        else if(percentages[i] >= 40 && percentages[i] <= 49){
                                grades[i] = 'E';
                        }
                        else{
                                grades[i] = 'R';
                        }
                }

                for(int x = 0; x < studentsCount; x++){
                        Console.WriteLine("Results of student " + (x+1) + " are : ");
                        Console.WriteLine("Marks in Physics: " + studentsMarks[x, 0]);
                        Console.WriteLine("Marks in Chemistry: " + studentsMarks[x, 1]);
                        Console.WriteLine("Marks in Maths: " + studentsMarks[x, 2]);
                        Console.WriteLine("Percentage: " + percentages[x]);
                        Console.WriteLine("Grade: " + grades[x]);
                }
        }
}