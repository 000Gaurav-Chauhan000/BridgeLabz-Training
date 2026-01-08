using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    class StudentNode : IStudent
    {
        private int rollNo;
        private string name;
        private int age;
        private string grade;

        public StudentNode Next { get; set; }

        public int RollNo => rollNo;
        public string Name => name;
        public int Age => age;
        public string Grade
        {
            get => grade;
            set => grade = value;
        }

        public StudentNode(int rollNo, string name, int age, string grade)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.age = age;
            this.grade = grade;
            Next = null;
        }
    }
}
