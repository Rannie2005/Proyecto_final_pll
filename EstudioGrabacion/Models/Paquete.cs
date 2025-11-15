using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudioGrabacion.Models
{
    public class Paquete
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; } // Agregar ?

        [Required]
        [StringLength(500)]
        public string? Descripcion { get; set; } // Agregar ?

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioTotal { get; set; }

        [Required]
        public int DuracionTotalHoras { get; set; }

        [Required]
        public bool Activo { get; set; } = true;

        // Relación muchos a muchos con Servicios
        public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
    }
}