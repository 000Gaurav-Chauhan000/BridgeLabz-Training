using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    class StudentLinkedList : IStudentList
    {
        private StudentNode head;

        public void AddAtBeginning(int rollNo, string name, int age, string grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.Next = head;
            head = newNode;
        }

        public void AddAtEnd(int rollNo, string name, int age, string grade)
        {
            StudentNode newNode = new StudentNode(rollNo, name, age, grade);

            if (head == null)
            {
                head = newNode;
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }

        public void AddAtPosition(int position, int rollNo, string name, int age, string grade)
        {
            if (position <= 1)
            {
                AddAtBeginning(rollNo, name, age, grade);
                return;
            }

            StudentNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            StudentNode newNode = new StudentNode(rollNo, name, age, grade);
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        public void DeleteByRollNo(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.RollNo == rollNo)
            {
                head = head.Next;
                Console.WriteLine("Student deleted.");
                return;
            }

            StudentNode temp = head;
            while (temp.Next != null && temp.Next.RollNo != rollNo)
                temp = temp.Next;

            if (temp.Next == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Student deleted.");
            }
        }

        public void Search(int rollNo)
        {
            StudentNode temp = head;

            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    Console.WriteLine($"Found: {temp.RollNo}, {temp.Name}, {temp.Age}, {temp.Grade}");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Student not found.");
        }

        public void UpdateGrade(int rollNo, string newGrade)
        {
            StudentNode temp = head;

            while (temp != null)
            {
                if (temp.RollNo == rollNo)
                {
                    temp.Grade = newGrade;
                    Console.WriteLine("Grade updated.");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Student not found.");
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No student records.");
                return;
            }

            StudentNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"RollNo: {temp.RollNo}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                temp = temp.Next;
            }
        }
    }
}
