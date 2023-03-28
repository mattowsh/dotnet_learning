using Microsoft.EntityFrameworkCore;

namespace first_project.Models
{
    public class first_projectContext : DbContext
    {
        // Constructor:
        public first_projectContext(DbContextOptions<first_projectContext> opciones)
        : base(opciones)
        {

        }

        // Create the entity == the db, based on our model Especialidad.cs:
        // In SQL Server the table will be called "Especialidad"
        public DbSet<Especialidad> Especialidad { get; set; }
    }
}