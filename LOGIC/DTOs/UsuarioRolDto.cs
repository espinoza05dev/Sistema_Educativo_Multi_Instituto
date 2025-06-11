using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class UsuarioRolDto
    {
        public int UsuarioRolID { get; set; }
        public int UsuarioID { get; set; }
        public int RolID { get; set; }
        public int InstitutoID { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public bool? Activo { get; set; }

        // Propiedades de navegación
        public string? NombreUsuario { get; set; }
        public string? NombreRol { get; set; }
        public string? NombreInstituto { get; set; }
        public bool EstaVencido => FechaVencimiento.HasValue && FechaVencimiento < DateTime.Now;
    }

    public class UsuarioRolCreateDto
    {
        [Required]
        public int UsuarioID { get; set; }

        [Required]
        public int RolID { get; set; }

        [Required]
        public int InstitutoID { get; set; }

        public DateTime? FechaAsignacion { get; set; } = DateTime.Now;
        public DateTime? FechaVencimiento { get; set; }
        public bool? Activo { get; set; } = true;
    }
}
