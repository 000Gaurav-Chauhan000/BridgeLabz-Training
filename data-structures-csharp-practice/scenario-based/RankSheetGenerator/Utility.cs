using System;

namespace RankSheetGenerator { 
class Utility : IData
    {
        IList<Student> students = new List<Student>();
        public void AddStudent()
        {
            Console.Write("\nEnter Name Of Student : ");
            string name = Console.ReadLine();
            Console.Write("Enter Id Of Student : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter The District Of Student : ");
            string district = Console.ReadLine();
            Console.Write("Enter The Marks Of Student out of 100 : ");
            double marks = double.Parse(Console.ReadLine());
            students.Add(new Student(id,name,district,marks));
            Sort(0,students.Count-1);
        }
        public void DisplayAllStudents()
        {
            Console.WriteLine("\n Processing All Students Data ..... \n");
            for(int i=0;i<students.Count;i++)Console.WriteLine($"Rank : {i+1} | {students[i]}\n-----------------------");
        }

        void Sort(int l,int r)
        {
            if(l>=r)return;
            int mid = (l+r)/2;
            Sort(l,mid);
            Sort(mid+1,r);
            Merge(l,mid,r);
        }

        void Merge(int l,int mid,int r)
        {
            Student[] arr1 = new Student[mid-l+1];
            Student[] arr2 = new Student[r-mid];
            int idx1=0,idx2=0;
            for(int i=l;i<=mid;i++)arr1[idx1++] = students[i];
            for(int i=mid+1;i<=r;i++)arr2[idx2++] = students[i];
            idx1=0;idx2=0;
            while(idx1<arr1.Length && idx2 < arr2.Length)
            {
                if (arr1[idx1].Marks >= arr2[idx2].Marks)students[l++] = arr1[idx1++];
                else students[l++] = arr2[idx2++];
            }
            while(idx1<arr1.Length)students[l++] = arr1[idx1++];
            while(idx2<arr2.Length)students[l++] = arr2[idx2++];
        }
    }
}