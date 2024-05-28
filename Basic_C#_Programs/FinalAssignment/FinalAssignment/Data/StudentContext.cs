using FinalAssignment.Models;
using System.Data.Entity;

namespace FinalAssignment.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}