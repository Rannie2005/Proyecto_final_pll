using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudioGrabacion.Models
{
    public class Ingeniero
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; } // Agregar ?

        [Required]
        [StringLength(100)]
        public string? Especialidad { get; set; } // Agregar ?

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TarifaPorHora { get; set; }

        [Required]
        public bool Disponible { get; set; } = true;

        [EmailAddress]
        public string? Email { get; set; }

        [Phone]
        public string? Telefono { get; set; }

        // Relación con Sesiones
        public virtual ICollection<Sesion> Sesiones { get; set; } = new List<Sesion>();
    }
}