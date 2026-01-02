using System.Data.Entity;

namespace SchoolApp.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name=SchoolDB") { }
        public DbSet<Student> Students { get; set; }
    }
}