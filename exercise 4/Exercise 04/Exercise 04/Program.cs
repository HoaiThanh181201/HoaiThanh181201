using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics.CodeAnalysis;
using static ListOfStudents.IComparable;
using static ListOfStudents.IComparer;

namespace ListOfStudents
{

    public class IComparable
    {
        public class Student : IComparable<Student>
        {


            public string StudentID { get; set; }
            public string FullName { get; set; }


            public Student()
            {
            }
            public Student(string id, string name)
            {
                StudentID = id;
                FullName = name;
            }

            public int CompareTo(Student other)
            {
                return this.StudentID.CompareTo(other.StudentID);
            }
        }


    }
    public class IComparer
    {
        public class SortPersonByName : IComparer<Student>
        {
            public int Compare([AllowNull] Student x, [AllowNull] Student y)
            {
                return x.FullName.CompareTo(y.FullName);
            }
        }
    }

    public class Students
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<Student> ListOfStudents = new List<Student>();
            ListOfStudents.Add(new Student("SV_13", "Nguyễn văn A"));
            ListOfStudents.Add(new Student("SV_01", "Nguyễn văn B"));
            ListOfStudents.Add(new Student("SV_33", "Nguyễn văn I"));
            ListOfStudents.Add(new Student("SV_22", "Nguyễn văn G"));
            ListOfStudents.Add(new Student("SV_11", "Nguyễn văn V"));
            ListOfStudents.Add(new Student("SV_32", "Nguyễn văn C"));
            ListOfStudents.Add(new Student("SV_88", "Nguyễn văn L"));
            ListOfStudents.Add(new Student("SV_12", "Nguyễn văn P"));
            ListOfStudents.Add(new Student("SV_13", "Nguyễn văn O"));

            ListOfStudents.Sort();
            Console.WriteLine("Using IComparable ");
            foreach (Student student in ListOfStudents)
            {
                Console.WriteLine("Name: {0}, ID: {1}", student.FullName, student.StudentID);

            }
            Console.WriteLine("");
            Console.WriteLine("Using IComparer ");
            ListOfStudents.Sort(new SortPersonByName());
            foreach (Student student in ListOfStudents)
            {
                Console.WriteLine("Name: {0}, ID: {1}", student.FullName, student.StudentID);

            }
        }
    }
}