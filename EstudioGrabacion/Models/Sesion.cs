using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace EstudioGrabacion.Models
{
    public class Sesion
    {
        [Key]
        public int Id { get; set; }

        public DateTime FechaHoraInicio { get; set; } = DateTime.Now;
        public DateTime FechaHoraFin { get; set; } = DateTime.Now.AddHours(1);

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostoTotal { get; set; }

        [Required]
        public string Estado { get; set; } = "Pendiente";

        [StringLength(500)]
        public string? Notas { get; set; }

        // Relación con Cliente (Usuario)
        [Required]
        public string? UsuarioId { get; set; } // Agregar ?
        public virtual IdentityUser? Usuario { get; set; } // Agregar ? y virtual

        // Relación con Ingeniero
        [Required]
        public int IngenieroId { get; set; }
        public virtual Ingeniero? Ingeniero { get; set; } // Agregar ? y virtual

        // Relación con Servicio
        [Required]
        public int ServicioId { get; set; }
        public virtual Servicio? Servicio { get; set; } // Agregar ? y virtual
    }
}