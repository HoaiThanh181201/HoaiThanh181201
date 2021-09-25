using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01
{
    class Student
    {
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public float AverageScore { get; set; }
        public string Faculty { get; set; }


        public Student(string studentID, string fullName, float averageScore, string faculty)
        {
            StudentID = studentID;
            FullName = fullName;
            AverageScore = averageScore;
            Faculty = faculty;
        }

        public Student() { }

        public void Input()
        {
            Console.Write("Enter StudentID: ");
            StudentID = Console.ReadLine();
            Console.Write("Enter Fullname: ");
            FullName = Console.ReadLine();
            Console.Write("Enter Average score:");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Enter Faculty:");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("StudentID: {0}   Name: {1}   Faculty: {2}    AverScore: {3}", this.StudentID,
            this.FullName, this.Faculty, this.AverageScore);
        }

    }
    class Program
    {
        private static void OutputList(List<Student> LStudent)
        {
            foreach (Student item in LStudent)
                item.Show();
        }
        static void Main(string[] args)
        {
            List<Student> LStudent = new List<Student>();
            LStudent.Add(new Student("SV01", "Dinh", 8, "NHKS"));
            LStudent.Add(new Student("SV02", "Dang ", 9, "CNTT"));
            LStudent.Add(new Student("SV03", "Tran ", 8, "DLT"));
            LStudent.Add(new Student("SV04", "Huynh ", 7, "QTKD"));
            LStudent.Add(new Student("SV05", "Bui ", 10, "CNTT"));
            LStudent.Add(new Student("SV06", "Dao ", 6, "CNTT"));
            LStudent.Add(new Student("SV07", "Bach ", 8, "QTKD"));
            LStudent.Add(new Student("SV08", "Trang ", 9, "CNTT"));
            LStudent.Add(new Student("SV09", "Nam", 4, "NNA"));
            LStudent.Add(new Student("SV10", "Dung", 8, "DL"));
            LStudent.Add(new Student("SV11", "Phuoc", 10, "CNTT"));
            LStudent.Add(new Student("SV12", "Vinh", 5, "CNTT"));
            LStudent.Add(new Student("SV13", "Thu", 3, "NHKS"));
            Console.WriteLine("\n======1.1======");
            var CNTTStudents = LStudent.FindAll(x => x.Faculty == "CNTT");
            OutputList(CNTTStudents);
            Console.WriteLine("\n======1.2======");
            var HighScoreStudent = LStudent.FindAll(x => x.AverageScore >= 5);
            OutputList(HighScoreStudent);
            Console.WriteLine("\n======1.3======");
            List<Student> StudentSort = LStudent.OrderBy(x => x.AverageScore).ToList();
            OutputList(StudentSort);
            Console.WriteLine("\n======1.4======");
            var HighScoreCNTT = LStudent.FindAll(x => x.AverageScore >= 5);
            HighScoreCNTT = HighScoreCNTT.FindAll(x => x.Faculty == "CNTT");
            OutputList(HighScoreCNTT);
            Console.WriteLine("\n======1.5======");
            var Max = LStudent.FindAll(x => x.AverageScore == LStudent.Max(y => y.AverageScore));
            var HighestCNTT = Max.FindAll(x => x.Faculty == "CNTT");
            OutputList(HighScoreCNTT);
        }
    }
}