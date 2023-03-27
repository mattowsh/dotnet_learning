using System.ComponentModel.DataAnnotations;

namespace first_project.Models
{
    // Define the class Especialidad and their properties:
    // Those properties will define the table in SQL server
    public class Especialidad
    {
        // Create the table primary key calling the Key class (imported):
        [Key]
        public int IdEspecialidad { get; set; }
        
        // Create other properties, not primary key:
        public string Descripcion { get; set; }
    }
}