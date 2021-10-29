using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class StudentServiceWithEF : IStudentService
    {
        public StudentServiceWithEF()
        {
            using (var ctx = new UniversityContext())
            {
                ctx.Database.EnsureCreated();
            }
        }
        public void DeleteStudentById(int id)
        {
            using (var ctx = new UniversityContext())
            {
                var deletedStudent = ctx.Students.Find(id);
                ctx.Students.Remove(deletedStudent);
                ctx.SaveChanges();
            }
        }

        public Student LoadStudentById(long id)
        {
            using (var ctx = new UniversityContext())
            {
                return ctx.Students.FirstOrDefault(x => x.studentId == id);
            }
        }

        public IList<Student> SearchStudent(string keyword, string hutechClass)
        {
            using (var ctx = new UniversityContext())
            {
                var result = ctx.Students.Where(s => (s.Class == hutechClass || string.IsNullOrEmpty(hutechClass)) && (s.firstname == keyword || s.lastname == keyword || string.IsNullOrEmpty(keyword))).OrderBy(s => s.studentId).ToList();
                return result.ToList();
            }
        }

        public void UpdateOrCreateStudent(Student student)
        {
            using (var ctx = new UniversityContext())
            {
                if (student.studentId > 0)
                {
                    var dbStudent = ctx.Students.Find(student.studentId);
                    dbStudent.studentId = student.studentId;
                    dbStudent.firstname = student.firstname;
                    dbStudent.lastname = student.lastname;
                    dbStudent.gender = student.gender;
                    dbStudent.email = student.email;
                    dbStudent.Class = student.Class;
                }
                else
                {
                    ctx.Students.Add(student);
                }
                ctx.SaveChanges();
            }
        }
    }
}
