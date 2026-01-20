using UniversityCourses;

class Program
{
    static void Main()
    {
        var examCourse = new Course<ExamCourse>
        {
            CourseCode = "dveee",
            CourseName = "Course1",
            EvaluationType = new ExamCourse()
        };

        var assignmentCourse = new Course<AssignmentCourse>
        {
            CourseCode = "Random",
            CourseName = "Course2",
            EvaluationType = new AssignmentCourse()
        };

        List<Course<CourseType>> courses = new List<Course<CourseType>>
        {
            examCourse,
            assignmentCourse
        };

        foreach (var course in courses)
        {
            course.Display();
        }
    }
}
