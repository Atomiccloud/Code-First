using System.Data.Entity;

namespace Context

{
    public class SchoolContext: DbContext
    {
        public SchoolContext(): base("SchoolDB")
        {
            
        }
            
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}