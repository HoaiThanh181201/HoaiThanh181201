using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementWithWS
{
    public class UniversityContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=SchoolDB_EFCore;MultipleActiveResultSets=true;Trusted_Connection=true;Integrated Security=true;");
        }
        public DbSet<Student> Students { get; set; }
    }
}