using System;
class GradeCalculator{
	static void Main(string[] args){
		Console.WriteLine("Enter marks in Physics: ");
		int physics = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter marks in Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());

		Console.WriteLine("Enter marks in Maths: ");
        int maths = int.Parse(Console.ReadLine());

		int obtainedMarks = physics + chemistry + maths;

		int totalMarks = 300;

		double averageMarks = (double)(obtainedMarks)/3;

		double percentage = ((double)(obtainedMarks)/totalMarks)*100;
		if(percentage >= 80){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade A");
            Console.WriteLine("above agency normalized students");
		}
		else if(percentage >= 70 && percentage <= 79){
			Console.WriteLine("Average Marks: " + averageMarks +" and grade B");
            Console.WriteLine("at agency normalized students");
		}
		else if(percentage >= 60 && percentage <= 69){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade C");
            Console.WriteLine("below, but approaching agency normalized students");
		}
		else if(percentage >= 50 && percentage <= 59){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade D");
            Console.WriteLine("well below agency normalized students");
		}
		else if(percentage >= 40 && percentage <= 49){
			Console.WriteLine("Average Marks: " + averageMarks + " and grade E");
            Console.WriteLine("too below agency normalized students");
		}
		else{
			Console.WriteLine("Average Marks: " + averageMarks + " and grade R");
            Console.WriteLine("Remedial Students");
		}
	}
}