using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudioGrabacion.Models
{
    public class Servicio
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
        public decimal Precio { get; set; }

        [Required]
        public int DuracionHoras { get; set; }

        // Relación con Sesiones
        public virtual ICollection<Sesion> Sesiones { get; set; } = new List<Sesion>();

        // Relación con Paquetes (muchos a muchos)
        public virtual ICollection<Paquete> Paquetes { get; set; } = new List<Paquete>();
    }
}