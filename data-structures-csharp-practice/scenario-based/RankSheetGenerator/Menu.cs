namespace RankSheetGenerator
{
    public class Menu
    {
        public static void DisplayMenu()
        {
            IData obj = new Utility();
            do
            {
                Console.WriteLine("\n---------- Home Page----------");
                Console.WriteLine("Press 1. To Add new Student");
                Console.WriteLine("Press 2. To Display All Students");
                Console.WriteLine("Press 3. To Exit");
                int input = int.Parse(Console.ReadLine());
                if(input==1)obj.AddStudent();
                else if(input==2)obj.DisplayAllStudents();
                else if(input==3)return;
                else Console.WriteLine("Invalid input");
            }while(true);
        }
    }
}