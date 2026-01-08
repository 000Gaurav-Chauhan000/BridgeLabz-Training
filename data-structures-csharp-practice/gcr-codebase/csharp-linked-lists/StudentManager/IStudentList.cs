using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    public interface IStudentList
    {
        void AddAtBeginning(int rollNo, string name, int age, string grade);
        void AddAtEnd(int rollNo, string name, int age, string grade);
        void AddAtPosition(int position, int rollNo, string name, int age, string grade);
        void DeleteByRollNo(int rollNo);
        void Search(int rollNo);
        void UpdateGrade(int rollNo, string newGrade);
        void Display();
    }

}
