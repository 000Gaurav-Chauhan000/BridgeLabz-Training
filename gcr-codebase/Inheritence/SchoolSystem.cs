using System;

class Person{
    public string name;
    public int age;

    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
}

class Teacher : Person{
    public string subject;

    public Teacher(string name, int age, string subject): base(name, age){
        this.subject = subject;
    }

    public void DisplayRole(){
        Console.WriteLine("Teacher");
    }
}

class Student : Person{
    public string grade;

    public Student(string name, int age, string grade): base(name, age){
        this.grade = grade;
    }

    public void DisplayRole(){
        Console.WriteLine("Student");
    }
}

class Staff : Person{
    public string dept;

    public Staff(string name, int age, string dept): base(name, age){
        this.dept = dept;
    }

    public void DisplayRole(){
        Console.WriteLine("Staff");
    }
}

class Program{
    static void Main()
    {
        Teacher t = new Teacher("Li Wei", 35, "Math");
        Student s = new Student("Zhang Min", 16, "10");
        Staff st = new Staff("Wang Fang", 40, "Office");

        t.DisplayRole();
        s.DisplayRole();
        st.DisplayRole();
    }
}
