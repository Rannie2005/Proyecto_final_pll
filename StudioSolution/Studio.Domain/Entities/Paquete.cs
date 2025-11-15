using Studio.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Studio.Domain.Entities
{
    public class Paquete : BaseEntity
    {
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioTotal { get; set; }
        public int SesionesIncluidas { get; set; }
        public bool Activo { get; set; } = true;
    }
}