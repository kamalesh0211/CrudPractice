using Microsoft.EntityFrameworkCore;

namespace CrudPractice.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext>options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=lbs; User Id=SS;TrustServerCertificate= True");
        }
    }
}
