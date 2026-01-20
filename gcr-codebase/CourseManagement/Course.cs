namespace UniversityCourses
{
    public class Course<T> where T : CourseType
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public T EvaluationType { get; set; }

        public void Display()
        {
            Console.WriteLine(
                $"{CourseCode} - {CourseName} | Evaluation: {EvaluationType.EvaluationMode}"
            );
        }
    }
}
