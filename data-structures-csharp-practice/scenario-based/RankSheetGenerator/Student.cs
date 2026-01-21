class Student
{
    readonly int ID;
    string Name;
    string District;
    public double Marks;
    public Student(int id,string name,string district,double marks)
    {
        ID = id;
        Name = name;
        District = district;
        Marks=marks;
    }
    public int GetId()=>ID;
    public override string ToString()=>$"ID : {ID} | Name : {Name} | District : {District} | Marks : {Marks}";
}