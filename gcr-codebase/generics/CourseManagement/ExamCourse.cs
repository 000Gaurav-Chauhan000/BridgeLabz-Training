namespace UniversityCourses
{
    public class ExamCourse : CourseType
    {
        public override string EvaluationMode => "Written Exam";
    }

    public class AssignmentCourse : CourseType
    {
        public override string EvaluationMode => "Assignments & Projects";
    }
}
