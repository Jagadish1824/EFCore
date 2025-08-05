using Microsoft.EntityFrameworkCore;

namespace CodeFirstPractice.Models
{
    public class StudentContext:DbContext
    {
        public DbSet<Students> Students { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = JAGADISH; database = practice; integrated security = true; trustservercertificate = true; ");
        }
    }
}
