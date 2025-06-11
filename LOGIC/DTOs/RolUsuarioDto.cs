using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class RolUsuarioDto
    {
        public int RolID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Permisos { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public int? TotalUsuarios { get; set; }
    }

    public class RolUsuarioCreateDto
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        [StringLength(200)]
        public string? Descripcion { get; set; }

        public string? Permisos { get; set; }
        public bool? Activo { get; set; } = true;
    }
}
