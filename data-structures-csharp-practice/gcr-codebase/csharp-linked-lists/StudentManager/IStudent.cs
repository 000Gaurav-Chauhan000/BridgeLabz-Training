namespace StudentManager
{
    public interface IStudent
    {
        int RollNo { get; }
        string Name { get; }
        int Age { get; }
        string Grade { get; set; }
    }
}